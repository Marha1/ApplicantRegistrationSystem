using ApplicantRegistrationSystem.Service;

namespace ApplicantRegistrationSystem.Forms
{
    partial class AbiturientsViewForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.DataGridView dataGridViewAbiturients;
        private System.Windows.Forms.ComboBox comboBoxSort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label labelTitle;
        private Button buttonPrint;


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panelTop = new Panel();
            comboBoxSort = new ComboBox();
            label1 = new Label();
            dataGridViewAbiturients = new DataGridView();
            panelHeader = new Panel();
            labelTitle = new Label();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAbiturients).BeginInit();
            panelHeader.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.White;
            panelTop.Controls.Add(comboBoxSort);
            panelTop.Controls.Add(label1);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 60);
            panelTop.Name = "panelTop";
            panelTop.Padding = new Padding(18, 10, 18, 10);
            panelTop.Size = new Size(889, 60);
            panelTop.TabIndex = 0;
            // Добавляем кнопку печати
            buttonPrint = new Button();
            buttonPrint.Text = "Печать";
            buttonPrint.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            buttonPrint.ForeColor = Color.White;
            buttonPrint.BackColor = Color.FromArgb(0, 122, 204);
            buttonPrint.FlatStyle = FlatStyle.Flat;
            buttonPrint.FlatAppearance.BorderSize = 0;
            buttonPrint.Location = new Point(700, 15);
            buttonPrint.Size = new Size(100, 30);
            buttonPrint.Click += ButtonPrint_Click;
            panelTop.Controls.Add(buttonPrint);
            // 
            // comboBoxSort
            // 
            comboBoxSort.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxSort.BackColor = Color.White;
            comboBoxSort.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSort.FlatStyle = FlatStyle.Flat;
            comboBoxSort.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            comboBoxSort.ForeColor = Color.FromArgb(64, 64, 64);
            comboBoxSort.FormattingEnabled = true;
            comboBoxSort.Location = new Point(133, 15);
            comboBoxSort.Name = "comboBoxSort";
            comboBoxSort.Size = new Size(312, 31);
            comboBoxSort.TabIndex = 1;
            comboBoxSort.SelectedIndexChanged += comboBoxSort_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(27, 18);
            label1.Name = "label1";
            label1.Size = new Size(109, 23);
            label1.TabIndex = 2;
            label1.Text = "Сортировка:";
            // 
            // dataGridViewAbiturients
            // 
            dataGridViewAbiturients.AllowUserToAddRows = false;
            dataGridViewAbiturients.AllowUserToDeleteRows = false;
            dataGridViewAbiturients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewAbiturients.BackgroundColor = Color.White;
            dataGridViewAbiturients.BorderStyle = BorderStyle.None;
            dataGridViewAbiturients.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewAbiturients.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 122, 204);
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.Padding = new Padding(10);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewAbiturients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewAbiturients.ColumnHeadersHeight = 50;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(240, 240, 240);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewAbiturients.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewAbiturients.Dock = DockStyle.Fill;
            dataGridViewAbiturients.EnableHeadersVisualStyles = false;
            dataGridViewAbiturients.GridColor = Color.FromArgb(240, 240, 240);
            dataGridViewAbiturients.Location = new Point(0, 120);
            dataGridViewAbiturients.Name = "dataGridViewAbiturients";
            dataGridViewAbiturients.ReadOnly = true;
            dataGridViewAbiturients.RowHeadersVisible = false;
            dataGridViewAbiturients.RowHeadersWidth = 62;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.Padding = new Padding(5, 0, 0, 0);
            dataGridViewAbiturients.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewAbiturients.RowTemplate.Height = 40;
            dataGridViewAbiturients.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewAbiturients.Size = new Size(889, 480);
            dataGridViewAbiturients.TabIndex = 1;
            dataGridViewAbiturients.CellContentClick += dataGridViewAbiturients_CellContentClick;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(0, 122, 204);
            panelHeader.Controls.Add(labelTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(889, 60);
            panelHeader.TabIndex = 2;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            labelTitle.ForeColor = Color.White;
            labelTitle.Location = new Point(18, 15);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(0, 32);
            labelTitle.TabIndex = 0;
            // 
            // AbiturientsViewForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(889, 600);
            Controls.Add(dataGridViewAbiturients);
            Controls.Add(panelTop);
            Controls.Add(panelHeader);
            Font = new Font("Segoe UI", 9F);
            Name = "AbiturientsViewForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Абитуриенты специальности";
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAbiturients).EndInit();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ResumeLayout(false);
        }
        private void ButtonPrint_Click(object sender, EventArgs e)
        {
            try
            {
                var printer = new DataGridViewPrinter(
                    dataGridViewAbiturients,
                    $"Абитуриенты специальности: {_specialityName}");
                printer.Print();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при печати: {ex.Message}",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}