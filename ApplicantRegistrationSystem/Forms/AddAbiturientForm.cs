using ApplicantRegistrationSystem.DAL.Models;
using ApplicantRegistrationSystem.Primitiv;
using ApplicantRegistrationSystem.Repository.Implementation;
using ApplicantRegistrationSystem.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace ApplicantRegistrationSystem.Forms
{
    public partial class AddAbiturientForm : Form
    {
        private readonly IAbiturientRepository _abiturientRepository;
        private readonly ISpecialityRepository _specialityRepository;
        private readonly ISubjectRepository _subjectRepository;
        private readonly IAbiturientSubjectRepository _abiturientSubjectRepository;

        private BindingList<AbiturientSubject> _subjectsWithGrades;

        public AddAbiturientForm()
        {
            InitializeComponent();

            _abiturientRepository = new AbiturientRepository();
            _specialityRepository = new SpecialityRepository();
            _subjectRepository = new SubjectRepository();
            _abiturientSubjectRepository = new AbiturientSubjectRepository();

            _subjectsWithGrades = new BindingList<AbiturientSubject>();
            InitializeBenefits();
            LoadSpecialitiesAsync();
            InitializeSubjectsGrid();
        }

        private async void LoadSpecialitiesAsync()
        {
            try
            {
                var specialities = await _specialityRepository.GetAllAsync();
                comboBoxSpecialities.DataSource = specialities;
                comboBoxSpecialities.DisplayMember = "Name";
                comboBoxSpecialities.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке специальностей: {ex.Message}", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void InitializeBenefits()
        {
            // Заполняем комбобокс типами льгот
            comboBoxBenefitType.DataSource = Enum.GetValues(typeof(BenefitType))
                .Cast<BenefitType>()
                .Select(b => new
                {
                    Value = b,
                    DisplayName = GetBenefitDisplayName(b)
                })
                .ToList();
            comboBoxBenefitType.DisplayMember = "DisplayName";
            comboBoxBenefitType.ValueMember = "Value";

            // Устанавливаем дату по умолчанию
            dateTimePickerBenefitDate.Value = DateTime.Now.AddYears(-1);
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
        private void InitializeSubjectsGrid()
        {
            dataGridViewSubjects.AutoGenerateColumns = false;
            dataGridViewSubjects.Columns.Clear();

            // Колонка для названия предмета
            dataGridViewSubjects.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Предмет",
                DataPropertyName = "SubjectName",
                ReadOnly = true,
                Width = 250
            });

            // Колонка для оценки
            dataGridViewSubjects.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Оценка",
                DataPropertyName = "Grade",
                ReadOnly = true,
                Width = 100
            });

            dataGridViewSubjects.DataSource = _subjectsWithGrades;
        }

        private async void buttonAddGrade_Click(object sender, EventArgs e)
        {
            using (var addGradeForm = new AddGradeForm(_subjectRepository))
            {
                if (addGradeForm.ShowDialog() == DialogResult.OK)
                {
                    var selectedSubject = addGradeForm.SelectedSubject;
                    var grade = addGradeForm.Grade;

                    if (_subjectsWithGrades.Any(s => s.SubjectId == selectedSubject.Id))
                    {
                        MessageBox.Show("Этот предмет уже добавлен!", "Предупреждение",
                                      MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    _subjectsWithGrades.Add(new AbiturientSubject
                    {
                        SubjectId = selectedSubject.Id,
                        Subject = selectedSubject,
                        Grade = grade
                    });
                }
            }
        }

        private async void buttonSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            try
            {
                // Создаем абитуриента
                var abiturient = new Abiturient
                {
                    RegistrationNumber = textBoxRegNumber.Text.Trim(),
                    LastName = textBoxLastName.Text.Trim(),
                    FirstName = textBoxFirstName.Text.Trim(),
                    Patronymic = string.IsNullOrWhiteSpace(textBoxPatronymic.Text) ? null : textBoxPatronymic.Text.Trim(),
                    BirthDate = DateTime.SpecifyKind(dateTimePickerBirthDate.Value.Date, DateTimeKind.Utc),
                    EducationalInstitutionName = textBoxSchoolName.Text.Trim(),
                    EducationalInstitutionNumber = string.IsNullOrWhiteSpace(textBoxSchoolNumber.Text) ? null : textBoxSchoolNumber.Text.Trim(),
                    EducationalInstitutionCity = string.IsNullOrWhiteSpace(textBoxSchoolCity.Text) ? null : textBoxSchoolCity.Text.Trim(),
                    GraduationDate = DateTime.SpecifyKind(dateTimePickerGraduationDate.Value.Date, DateTimeKind.Utc),
                    HasRedDiploma = checkBoxRedDiploma.Checked,
                    HasMedal = checkBoxMedal.Checked,
                    City = textBoxCity.Text.Trim(),
                    Street = string.IsNullOrWhiteSpace(textBoxStreet.Text) ? null : textBoxStreet.Text.Trim(),
                    HouseNumber = string.IsNullOrWhiteSpace(textBoxHouseNumber.Text) ? null : textBoxHouseNumber.Text.Trim(),
                    Phone = string.IsNullOrWhiteSpace(textBoxPhone.Text) ? null : textBoxPhone.Text.Trim(),
                    BenefitType = (BenefitType)comboBoxBenefitType.SelectedValue,
                    BenefitDocumentNumber = textBoxBenefitDocument.Text.Trim(),
                    BenefitDocumentDate = DateTime.SpecifyKind(dateTimePickerBenefitDate.Value.Date, DateTimeKind.Utc),
                    BenefitIssuedBy = string.IsNullOrWhiteSpace(textBoxBenefitIssuedBy.Text) ? null : textBoxBenefitIssuedBy.Text.Trim(),
                    SpecialityId = (int)comboBoxSpecialities.SelectedValue
                };

                // Сохраняем абитуриента
                await _abiturientRepository.AddAsync(abiturient);

                // Получаем контекст для работы с Entity Framework

                foreach (var subjectGrade in _subjectsWithGrades)
                {
                    // Создаем новую связь, используя только ID предмета
                    var abiturientSubject = new AbiturientSubject
                    {
                        AbiturientId = abiturient.Id,
                        SubjectId = subjectGrade.SubjectId,
                        Grade = subjectGrade.Grade
                    };

                    // Помечаем Subject как неизменяемый (уже существует в БД)
                    var subject = await _subjectRepository.GetByIdAsync(subjectGrade.SubjectId);
                    if (subject != null)
                    {
                    }

                    // Добавляем связь
                    await _abiturientSubjectRepository.AddAsync(abiturientSubject);
                }



                MessageBox.Show("Абитуриент успешно добавлен!", "Успех",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении: {ex.Message}\n\nПодробности: {ex.InnerException?.Message}",
                              "Ошибка сохранения",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateInput()
        {
            var selectedBenefit = (BenefitType)comboBoxBenefitType.SelectedValue;
            if (selectedBenefit != BenefitType.None && string.IsNullOrWhiteSpace(textBoxBenefitDocument.Text))
            {
                MessageBox.Show("Для льготного поступления укажите документ!", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxBenefitDocument.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(textBoxRegNumber.Text))
            {
                MessageBox.Show("Введите регистрационный номер!", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxRegNumber.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBoxLastName.Text))
            {
                MessageBox.Show("Введите фамилию!", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxLastName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBoxFirstName.Text))
            {
                MessageBox.Show("Введите имя!", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxFirstName.Focus();
                return false;
            }

            if (dateTimePickerBirthDate.Value >= DateTime.Now)
            {
                MessageBox.Show("Введите корректную дату рождения!", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dateTimePickerBirthDate.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBoxSchoolName.Text))
            {
                MessageBox.Show("Введите название учебного заведения!", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxSchoolName.Focus();
                return false;
            }

            if (dateTimePickerGraduationDate.Value > DateTime.Now)
            {
                MessageBox.Show("Введите корректную дату окончания!", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dateTimePickerGraduationDate.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBoxCity.Text))
            {
                MessageBox.Show("Введите город проживания!", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxCity.Focus();
                return false;
            }

            if (comboBoxSpecialities.SelectedValue == null)
            {
                MessageBox.Show("Выберите специальность!", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBoxSpecialities.Focus();
                return false;
            }

            return true;
        }

        private void AddAbiturientForm_Load(object sender, EventArgs e)
        {
            dateTimePickerBirthDate.MaxDate = DateTime.Now.AddYears(-16);
            dateTimePickerGraduationDate.MaxDate = DateTime.Now;
        }

        private void textBoxLastName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}