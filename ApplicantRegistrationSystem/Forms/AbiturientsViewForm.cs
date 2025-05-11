using ApplicantRegistrationSystem.DAL.Models;
using ApplicantRegistrationSystem.Primitiv;
using ApplicantRegistrationSystem.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ApplicantRegistrationSystem.Forms
{
    public partial class AbiturientsViewForm : Form
    {
        private readonly int _specialityId;
        private readonly string _specialityName;
        private readonly IAbiturientRepository _abiturientRepository;
        private List<Abiturient> _abiturients;

        public AbiturientsViewForm(int specialityId, string specialityName, IAbiturientRepository abiturientRepository)
        {
            InitializeComponent();
            _specialityId = specialityId;
            _specialityName = specialityName;
            _abiturientRepository = abiturientRepository;

            InitializeDataGridView();
            InitializeComboBox();
            LoadAbiturientsAsync();
        }

        private void InitializeDataGridView()
        {
            dataGridViewAbiturients.AutoGenerateColumns = false;
            dataGridViewAbiturients.Columns.Clear();
            labelTitle.Text = $"Абитуриенты специальности:{_specialityName}";
            // Добавляем столбцы вручную с русскими названиями
            dataGridViewAbiturients.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "RegistrationNumber",
                HeaderText = "Рег. номер",
                Name = "RegNumber",
                Width = 120
            });

            dataGridViewAbiturients.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "LastName",
                HeaderText = "Фамилия",
                Name = "LastName",
                Width = 150
            });

            dataGridViewAbiturients.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "FirstName",
                HeaderText = "Имя",
                Name = "FirstName",
                Width = 150
            });

            var gradeColumn = new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "AverageGrade",
                HeaderText = "Средний балл",
                Name = "AverageGrade",
                Width = 120
            };
            gradeColumn.DefaultCellStyle.Format = "F2";
            dataGridViewAbiturients.Columns.Add(gradeColumn);

            dataGridViewAbiturients.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "RedDiploma",
                HeaderText = "Красный диплом",
                Name = "RedDiploma",
                Width = 120
            });

            dataGridViewAbiturients.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Benefit",
                HeaderText = "Льгота",
                Name = "Benefit",
                Width = 150
            });
        }

        private void InitializeComboBox()
        {
            comboBoxSort.Items.AddRange(new[]
            {
                "Фамилия (А-Я)",
                "Фамилия (Я-А)",
                "Средний балл (по убыванию)",
                "Средний балл (по возрастанию)",
                "Только с красным дипломом",
                "Только с медалью",
                "Только льготники",
                "Без льгот"
            });
            comboBoxSort.SelectedIndex = 0;
        }

        private async void LoadAbiturientsAsync()
        {
            try
            {
                _abiturients = await _abiturientRepository.GetBySpecialityWithDetailsAsync(_specialityId);
                ApplySort();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке данных: {ex.Message}",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ApplySort()
        {
            if (_abiturients == null) return;

            IEnumerable<Abiturient> sortedAbiturients = comboBoxSort.SelectedIndex switch
            {
                1 => _abiturients.OrderByDescending(a => a.LastName),
                2 => _abiturients.OrderByDescending(a => a.AbiturientSubjects?.Average(s => s.Grade) ?? 0),
                3 => _abiturients.OrderBy(a => a.AbiturientSubjects?.Average(s => s.Grade) ?? 0),
                4 => _abiturients.Where(a => a.HasRedDiploma).OrderBy(a => a.LastName),
                5 => _abiturients.Where(a => a.HasMedal).OrderBy(a => a.LastName),
                6 => _abiturients.Where(a => a.BenefitType != BenefitType.None).OrderBy(a => a.LastName),
                7 => _abiturients.Where(a => a.BenefitType == BenefitType.None).OrderBy(a => a.LastName),
                _ => _abiturients.OrderBy(a => a.LastName)
            };

            DisplayAbiturients(sortedAbiturients.ToList());
        }

        private void DisplayAbiturients(List<Abiturient> abiturients)
        {
            dataGridViewAbiturients.Rows.Clear();

            foreach (var a in abiturients)
            {
                dataGridViewAbiturients.Rows.Add(
                    a.RegistrationNumber,
                    a.LastName,
                    a.FirstName,
                    a.AbiturientSubjects?.Average(s => s.Grade),
                    a.HasRedDiploma ? "Да" : "Нет",
                    a.BenefitType != BenefitType.None ? a.BenefitType.ToRussianString() : "Нет"
                );
            }
        }

        private void comboBoxSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplySort();
        }

        private void dataGridViewAbiturients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}