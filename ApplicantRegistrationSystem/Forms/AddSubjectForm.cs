using ApplicantRegistrationSystem.DAL.Models;
using ApplicantRegistrationSystem.Repository.Interfaces;
using ApplicantRegistrationSystem.Repository.Implementation;
using System;
using System.Windows.Forms;

namespace ApplicantRegistrationSystem.Forms
{
    public partial class AddSubjectForm : Form
    {
        private readonly ISubjectRepository _subjectRepository;

        public AddSubjectForm()
        {
            InitializeComponent();
            _subjectRepository = new SubjectRepository();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtSubjectName.Text))
                {
                    MessageBox.Show("Пожалуйста, введите название предмета", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var newSubject = new Subject
                {
                    Name = txtSubjectName.Text.Trim()
                };

               await _subjectRepository.AddAsync(newSubject);

                MessageBox.Show("Предмет успешно добавлен", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при добавлении предмета: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}