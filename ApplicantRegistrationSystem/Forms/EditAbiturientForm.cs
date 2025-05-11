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
    public partial class EditAbiturientForm : Form
    {
        private readonly IAbiturientRepository _abiturientRepository;
        private readonly ISpecialityRepository _specialityRepository;
        private readonly ISubjectRepository _subjectRepository;
        private readonly IAbiturientSubjectRepository _abiturientSubjectRepository;

        private readonly Abiturient _abiturient;
        private BindingList<AbiturientSubject> _subjectsWithGrades;

        public EditAbiturientForm(Abiturient abiturient)
        {
            InitializeComponent();

            _abiturientRepository = new AbiturientRepository();
            _specialityRepository = new SpecialityRepository();
            _subjectRepository = new SubjectRepository();
            _abiturientSubjectRepository = new AbiturientSubjectRepository();
            _abiturient = abiturient;

            _subjectsWithGrades = new BindingList<AbiturientSubject>();

            InitializeForm();
            LoadSpecialitiesAsync();
            InitializeBenefitTypes();
            InitializeSubjectsGrid();
            LoadSubjectsAsync();
        }

        private async void LoadSubjectsAsync()
        {
            try
            {
                var subjects = await _abiturientSubjectRepository.GetByAbiturientIdAsync(_abiturient.Id);
                foreach (var subject in subjects)
                {
                    subject.Subject = await _subjectRepository.GetByIdAsync(subject.SubjectId);
                    _subjectsWithGrades.Add(subject);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке предметов: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InitializeForm()
        {
            // Основные данные
            textBoxRegNumber.Text = _abiturient.RegistrationNumber;
            textBoxLastName.Text = _abiturient.LastName;
            textBoxFirstName.Text = _abiturient.FirstName;
            textBoxPatronymic.Text = _abiturient.Patronymic;
            dateTimePickerBirthDate.Value = _abiturient.BirthDate.ToLocalTime();
            textBoxSchoolName.Text = _abiturient.EducationalInstitutionName;
            textBoxSchoolNumber.Text = _abiturient.EducationalInstitutionNumber;
            textBoxSchoolCity.Text = _abiturient.EducationalInstitutionCity;
            dateTimePickerGraduationDate.Value = _abiturient.GraduationDate.ToLocalTime();
            checkBoxRedDiploma.Checked = _abiturient.HasRedDiploma;
            checkBoxMedal.Checked = _abiturient.HasMedal;
            textBoxCity.Text = _abiturient.City;
            textBoxStreet.Text = _abiturient.Street;
            textBoxHouseNumber.Text = _abiturient.HouseNumber;
            textBoxPhone.Text = _abiturient.Phone;

            // Данные о льготах
            comboBoxBenefitType.SelectedItem = _abiturient.BenefitType;
            textBoxBenefitDocument.Text = _abiturient.BenefitDocumentNumber;
            if (_abiturient.BenefitDocumentDate.HasValue)
            {
                dateTimePickerBenefitDate.Value = _abiturient.BenefitDocumentDate.Value.ToLocalTime();
            }
            textBoxBenefitIssuedBy.Text = _abiturient.BenefitIssuedBy;

            // Настройка только для чтения
            textBoxRegNumber.ReadOnly = true;
        }

        private async void LoadSpecialitiesAsync()
        {
            try
            {
                var specialities = await _specialityRepository.GetAllAsync();
                comboBoxSpecialities.DataSource = specialities;
                comboBoxSpecialities.DisplayMember = "Name";
                comboBoxSpecialities.ValueMember = "Id";

                if (_abiturient.SpecialityId > 0)
                {
                    comboBoxSpecialities.SelectedValue = _abiturient.SpecialityId;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке специальностей: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InitializeBenefitTypes()
        {
            // Создаем список элементов с отображаемыми именами
            var benefitTypes = Enum.GetValues(typeof(BenefitType))
                .Cast<BenefitType>()
                .Select(b => new
                {
                    Value = b,
                    DisplayName = GetBenefitDisplayName(b)
                })
                .ToList();

            comboBoxBenefitType.DataSource = benefitTypes;
            comboBoxBenefitType.DisplayMember = "DisplayName";
            comboBoxBenefitType.ValueMember = "Value";

            var currentBenefit = benefitTypes.FirstOrDefault(b => b.Value == _abiturient.BenefitType);
            if (currentBenefit != null)
            {
                comboBoxBenefitType.SelectedItem = currentBenefit;
            }
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

            // Колонка для действий (удаление)
            var deleteButtonColumn = new DataGridViewButtonColumn
            {
                Name = "DeleteColumn",
                Text = "Удалить",
                UseColumnTextForButtonValue = true,
                Width = 100
            };
            dataGridViewSubjects.Columns.Add(deleteButtonColumn);

            dataGridViewSubjects.DataSource = _subjectsWithGrades;
        }



        private async void dataGridViewSubjects_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != dataGridViewSubjects.Columns["DeleteColumn"].Index)
                return;

            var subject = _subjectsWithGrades[e.RowIndex];
            if (MessageBox.Show($"Удалить предмет '{subject.Subject.Name}'?", "Подтверждение",
                              MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    await _abiturientSubjectRepository.DeleteAsync(subject);
                    _subjectsWithGrades.RemoveAt(e.RowIndex);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при удалении предмета: {ex.Message}", "Ошибка",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void buttonSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            try
            {
                // Обновляем данные
                _abiturient.LastName = textBoxLastName.Text.Trim();
                _abiturient.FirstName = textBoxFirstName.Text.Trim();
                _abiturient.Patronymic = string.IsNullOrWhiteSpace(textBoxPatronymic.Text) ? null : textBoxPatronymic.Text.Trim();
                _abiturient.BirthDate = DateTime.SpecifyKind(dateTimePickerBirthDate.Value.Date, DateTimeKind.Utc);
                _abiturient.EducationalInstitutionName = textBoxSchoolName.Text.Trim();
                _abiturient.EducationalInstitutionNumber = string.IsNullOrWhiteSpace(textBoxSchoolNumber.Text) ? null : textBoxSchoolNumber.Text.Trim();
                _abiturient.EducationalInstitutionCity = string.IsNullOrWhiteSpace(textBoxSchoolCity.Text) ? null : textBoxSchoolCity.Text.Trim();
                _abiturient.GraduationDate = DateTime.SpecifyKind(dateTimePickerGraduationDate.Value.Date, DateTimeKind.Utc);
                _abiturient.HasRedDiploma = checkBoxRedDiploma.Checked;
                _abiturient.HasMedal = checkBoxMedal.Checked;
                _abiturient.City = textBoxCity.Text.Trim();
                _abiturient.Street = string.IsNullOrWhiteSpace(textBoxStreet.Text) ? null : textBoxStreet.Text.Trim();
                _abiturient.HouseNumber = string.IsNullOrWhiteSpace(textBoxHouseNumber.Text) ? null : textBoxHouseNumber.Text.Trim();
                _abiturient.Phone = string.IsNullOrWhiteSpace(textBoxPhone.Text) ? null : textBoxPhone.Text.Trim();
                _abiturient.SpecialityId = (int)comboBoxSpecialities.SelectedValue;

                // Обновляем льготы
                _abiturient.BenefitType = (BenefitType)comboBoxBenefitType.SelectedValue;
                _abiturient.BenefitDocumentNumber = textBoxBenefitDocument.Text.Trim();
                _abiturient.BenefitDocumentDate = DateTime.SpecifyKind(dateTimePickerBenefitDate.Value.Date, DateTimeKind.Utc);
                _abiturient.BenefitIssuedBy = string.IsNullOrWhiteSpace(textBoxBenefitIssuedBy.Text) ? null : textBoxBenefitIssuedBy.Text.Trim();

                await _abiturientRepository.UpdateAsync(_abiturient);

                MessageBox.Show("Данные абитуриента успешно обновлены!", "Успех",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при обновлении данных: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
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

        private void EditAbiturientForm_Load(object sender, EventArgs e)
        {
            dateTimePickerBirthDate.MaxDate = DateTime.Now.AddYears(-16);
            dateTimePickerGraduationDate.MaxDate = DateTime.Now;
        }

        private async void buttonAddGrade_Click_1(object sender, EventArgs e)
        {
            using (var addGradeForm = new AddGradeForm(_subjectRepository))
            {
                if (addGradeForm.ShowDialog() == DialogResult.OK)
                {
                    var selectedSubject = addGradeForm.SelectedSubject;
                    var grade = addGradeForm.Grade;

                    // Проверяем, есть ли уже такой предмет у абитуриента
                    if (_subjectsWithGrades.Any(s => s.SubjectId == selectedSubject.Id))
                    {
                        MessageBox.Show("Этот предмет уже добавлен!", "Предупреждение",
                                      MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    try
                    {
                        // Создаем новую связь без указания Id (он сгенерируется в БД)
                        var abiturientSubject = new AbiturientSubject
                        {
                            AbiturientId = _abiturient.Id,
                            SubjectId = selectedSubject.Id,
                            Grade = grade
                        };

                        // Добавляем в БД
                        await _abiturientSubjectRepository.AddAsync(abiturientSubject);

                        // Подгружаем полные данные о предмете
                        abiturientSubject.Subject = await _subjectRepository.GetByIdAsync(selectedSubject.Id);

                        // Добавляем в локальный список
                        _subjectsWithGrades.Add(abiturientSubject);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка при добавлении предмета: {ex.Message}", "Ошибка",
                                      MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}