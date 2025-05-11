using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicantRegistrationSystem.Service
{
    public class DataGridViewPrinter
    {
        private readonly DataGridView _dataGridView;
        private readonly string _title;
        private readonly PrintDocument _printDocument;
        private int _currentRowIndex;

        public DataGridViewPrinter(DataGridView dataGridView, string title)
        {
            _dataGridView = dataGridView;
            _title = title;
            _printDocument = new PrintDocument();
            _printDocument.PrintPage += PrintDocument_PrintPage;
        }

        public void Print()
        {
            var printDialog = new PrintDialog
            {
                Document = _printDocument,
                AllowSomePages = true
            };

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                _currentRowIndex = 0;
                _printDocument.Print();
            }
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            var font = new Font("Arial", 12);
            var headerFont = new Font("Arial", 14, FontStyle.Bold);
            var brush = Brushes.Black;
            float yPos = 0;
            float xPos = 0;
            int count = 0;

            // Печать заголовка
            e.Graphics.DrawString(_title, headerFont, brush, xPos, yPos);
            yPos += headerFont.GetHeight(e.Graphics) + 20;

            // Печать заголовков столбцов
            foreach (DataGridViewColumn column in _dataGridView.Columns)
            {
                if (column.Visible)
                {
                    e.Graphics.DrawString(column.HeaderText, font, brush, xPos, yPos);
                    xPos += column.Width / 2; // Простое выравнивание
                }
            }

            yPos += font.GetHeight(e.Graphics) + 10;
            xPos = 0;

            // Печать строк данных
            while (_currentRowIndex < _dataGridView.Rows.Count)
            {
                var row = _dataGridView.Rows[_currentRowIndex];
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Visible)
                    {
                        var value = cell.FormattedValue?.ToString() ?? string.Empty;
                        e.Graphics.DrawString(value, font, brush, xPos, yPos);
                        xPos += _dataGridView.Columns[cell.ColumnIndex].Width / 2;
                    }
                }

                _currentRowIndex++;
                yPos += font.GetHeight(e.Graphics) + 5;
                xPos = 0;
                count++;

                // Проверяем, нужно ли создавать новую страницу
                if (yPos + font.GetHeight(e.Graphics) > e.MarginBounds.Height)
                {
                    e.HasMorePages = _currentRowIndex < _dataGridView.Rows.Count;
                    return;
                }
            }

            e.HasMorePages = false;
        }
    }
}
