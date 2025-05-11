using ApplicantRegistrationSystem.DAL.Models;
using ApplicantRegistrationSystem.Repository.Interfaces;
using System;
using System.Windows.Forms;

namespace ApplicantRegistrationSystem.Forms
{
    public partial class AddGradeForm : Form
    {
        private readonly ISubjectRepository _subjectRepository;

        public Subject SelectedSubject { get; private set; }
        public int Grade { get; private set; }

        public AddGradeForm(ISubjectRepository subjectRepository)
        {
            InitializeComponent();
            _subjectRepository = subjectRepository;
            LoadSubjectsAsync();
        }

        private async void LoadSubjectsAsync()
        {
            try
            {
                var subjects = await _subjectRepository.GetAllAsync();
                comboBoxSubjects.DataSource = subjects;
                comboBoxSubjects.DisplayMember = "Name";
                comboBoxSubjects.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке предметов: {ex.Message}", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (comboBoxSubjects.SelectedItem == null)
            {
                MessageBox.Show("Выберите предмет!", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(textBoxGrade.Text, out int grade) || grade < 1 || grade > 10)
            {
                MessageBox.Show("Введите корректную оценку (1-10)!", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxGrade.Focus();
                return;
            }

            SelectedSubject = (Subject)comboBoxSubjects.SelectedItem;
            Grade = grade;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}