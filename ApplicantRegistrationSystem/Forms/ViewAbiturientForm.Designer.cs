using ApplicantRegistrationSystem.DAL.Models;
using ApplicantRegistrationSystem.Primitiv;
using ApplicantRegistrationSystem.Services;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace ApplicantRegistrationSystem.Forms
{
    partial class ViewAbiturientForm
    {
        private System.ComponentModel.IContainer components = null;
        private Panel panelHeader;
        private Label labelTitle;
        private Panel panelMain;
        private Button buttonPrint;
        private Button buttonClose;
        private DataGridView dataGridViewGrades;
        private Abiturient _abiturient;
        private List<AbiturientSubject> _abiturientSubjects;

        public ViewAbiturientForm(Abiturient abiturient, List<AbiturientSubject> abiturientSubjects)
        {
            _abiturient = abiturient;
            _abiturientSubjects = abiturientSubjects;
            InitializeComponent();
            PopulateData();
        }

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
            panelHeader = new Panel();
            labelTitle = new Label();
            panelMain = new Panel();
            dataGridViewGrades = new DataGridView();
            buttonPrint = new Button();
            buttonClose = new Button();
            panelHeader.SuspendLayout();
            panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewGrades).BeginInit();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(0, 122, 204);
            panelHeader.Controls.Add(labelTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(716, 60);
            panelHeader.TabIndex = 0;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            labelTitle.ForeColor = Color.White;
            labelTitle.Location = new Point(18, 15);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(252, 32);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Данные абитуриента";
            // 
            // panelMain
            // 
            panelMain.AutoScroll = true;
            panelMain.BackColor = Color.White;
            panelMain.Controls.Add(dataGridViewGrades);
            panelMain.Controls.Add(buttonPrint);
            panelMain.Controls.Add(buttonClose);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 60);
            panelMain.Name = "panelMain";
            panelMain.Padding = new Padding(18, 20, 18, 20);
            panelMain.Size = new Size(716, 818);
            panelMain.TabIndex = 1;
            panelMain.Paint += panelMain_Paint;
            // 
            // dataGridViewGrades
            // 
            dataGridViewGrades.AllowUserToAddRows = false;
            dataGridViewGrades.AllowUserToDeleteRows = false;
            dataGridViewGrades.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewGrades.BackgroundColor = Color.White;
            dataGridViewGrades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewGrades.Location = new Point(23, 490);
            dataGridViewGrades.Name = "dataGridViewGrades";
            dataGridViewGrades.ReadOnly = true;
            dataGridViewGrades.RowHeadersVisible = false;
            dataGridViewGrades.RowHeadersWidth = 62;
            dataGridViewGrades.Size = new Size(672, 250);
            dataGridViewGrades.TabIndex = 3;
            // 
            // buttonPrint
            // 
            buttonPrint.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonPrint.BackColor = Color.FromArgb(0, 122, 204);
            buttonPrint.FlatAppearance.BorderSize = 0;
            buttonPrint.FlatStyle = FlatStyle.Flat;
            buttonPrint.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            buttonPrint.ForeColor = Color.White;
            buttonPrint.Location = new Point(27, 758);
            buttonPrint.Name = "buttonPrint";
            buttonPrint.Size = new Size(107, 40);
            buttonPrint.TabIndex = 0;
            buttonPrint.Text = "Печать";
            buttonPrint.UseVisualStyleBackColor = false;
            buttonPrint.Click += buttonPrint_Click;
            // 
            // buttonClose
            // 
            buttonClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonClose.BackColor = Color.FromArgb(220, 53, 69);
            buttonClose.FlatAppearance.BorderSize = 0;
            buttonClose.FlatStyle = FlatStyle.Flat;
            buttonClose.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            buttonClose.ForeColor = Color.White;
            buttonClose.Location = new Point(583, 758);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(107, 40);
            buttonClose.TabIndex = 1;
            buttonClose.Text = "Закрыть";
            buttonClose.UseVisualStyleBackColor = false;
            buttonClose.Click += buttonClose_Click;
            // 
            // ViewAbiturientForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoScrollMinSize = new Size(120, 600);
            BackColor = Color.White;
            ClientSize = new Size(716, 878);
            Controls.Add(panelMain);
            Controls.Add(panelHeader);
            Font = new Font("Segoe UI", 9F);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ViewAbiturientForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Просмотр данных абитуриента";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewGrades).EndInit();
            ResumeLayout(false);
        }

        private void PopulateData()
        {
            if (_abiturient == null) return;

            // Создаем таблицу для основных данных
            var table = new TableLayoutPanel
            {
                Dock = DockStyle.Top,
                AutoSize = true,
                ColumnCount = 2,
                ColumnStyles = {
                    new ColumnStyle(SizeType.Percent, 30F),
                    new ColumnStyle(SizeType.Percent, 70F)
                },
                Location = new Point(20, 20),
                Name = "tableMainData",
                Padding = new Padding(0, 0, 0, 20),
                Size = new Size(750, 250)
            };

            // Добавляем основные данные
            AddRow(table, "Рег. номер", _abiturient.RegistrationNumber);
            AddRow(table, "ФИО", $"{_abiturient.LastName} {_abiturient.FirstName} {_abiturient.Patronymic}");
            AddRow(table, "Дата рождения", _abiturient.BirthDate.ToShortDateString());
            AddRow(table, "Учебное заведение", $"{_abiturient.EducationalInstitutionName} №{_abiturient.EducationalInstitutionNumber}, {_abiturient.EducationalInstitutionCity}");
            AddRow(table, "Дата окончания", _abiturient.GraduationDate.ToShortDateString());
            AddRow(table, "Награды", GetAwardsString());
            AddRow(table, "Адрес", $"{_abiturient.City}, {_abiturient.Street}, д.{_abiturient.HouseNumber}");
            AddRow(table, "Телефон", _abiturient.Phone);
            AddRow(table, "Специальность", _abiturient.Speciality.Name);
            AddRow(table, "Льгота", GetBenefitDisplayName(_abiturient.BenefitType) == "None"? "Нет": GetBenefitDisplayName(_abiturient.BenefitType));

            panelMain.Controls.Add(table);

            // Настраиваем DataGridView для оценок
            dataGridViewGrades.DataSource = _abiturientSubjects?
                .Select(s => new
                {
                    Предмет = s.Subject?.Name ?? "Неизвестный предмет",
                    Оценка = s.Grade
                })
                .OrderBy(s => s.Предмет)
                .ToList();
        }
        private string GetBenefitDisplayName(BenefitType benefit)
        {
            switch (benefit)
            {
                case BenefitType.None: return "Без льгот";
                case BenefitType.Orphan: return "Сирота";
                case BenefitType.Disabled: return "Инвалид";
                case BenefitType.LargeFamily: return "Многодетная семья";
                case BenefitType.CombatantFamily: return "Семья военнослужащего";
                case BenefitType.Other: return "Другая льгота";
                default: return benefit.ToString();
            }
        }

        private string GetAwardsString()
        {
            var awards = new List<string>();
            if (_abiturient.HasRedDiploma) awards.Add("Красный диплом");
            if (_abiturient.HasMedal) awards.Add("Медаль");
            return awards.Any() ? string.Join(", ", awards) : "Нет";
        }

        private void AddRow(TableLayoutPanel table, string label, string value)
        {
            var labelLabel = new Label
            {
                Text = label,
                Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold),
                ForeColor = Color.FromArgb(64, 64, 64),
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleLeft,
                Margin = new Padding(5)
            };

            var valueLabel = new Label
            {
                Text = value,
                Font = new Font("Segoe UI", 10F),
                ForeColor = Color.Black,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleLeft,
                Margin = new Padding(5),
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.White,
                Padding = new Padding(5)
            };

            table.RowCount++;
            table.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));

            table.Controls.Add(labelLabel, 0, table.RowCount - 1);
            table.Controls.Add(valueLabel, 1, table.RowCount - 1);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            var printer = new AbiturientPrinter(_abiturient, _abiturientSubjects);
            printer.Print();
        }
    }
}