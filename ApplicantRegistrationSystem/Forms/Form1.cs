using ApplicantRegistrationSystem.Forms;
using ApplicantRegistrationSystem.Repository.Implementation;
using ApplicantRegistrationSystem.Repository.Interfaces;

namespace ApplicantRegistrationSystem
{
    public partial class Form1 : Form
    {
        private readonly IAbiturientRepository _abiturientRepository;
        private readonly ISpecialityRepository _specialityRepository;
        private readonly ISubjectRepository _subjectRepository;
        private readonly IAbiturientSubjectRepository _abiturientSubjectRepository;

        public Form1()
        {
            InitializeComponent();

            // ������������� ������������
            _abiturientRepository = new AbiturientRepository();
            _specialityRepository = new SpecialityRepository();
            _subjectRepository = new SubjectRepository();
            _abiturientSubjectRepository = new AbiturientSubjectRepository();
            LoadDataAsync();
        }

        private async void LoadDataAsync()
        {
            // �������� ������������
            var abiturients = await _abiturientRepository.GetAllAsync();
            dataGridViewAbiturients.DataSource = abiturients.Select(a => new
            {
                a.RegistrationNumber,
                a.LastName,
                a.FirstName,
                a.Patronymic,
                a.BirthDate,
                a.EducationalInstitutionName,
                a.EducationalInstitutionNumber,
                a.EducationalInstitutionCity,
                a.GraduationDate,
                a.HasRedDiploma,
                a.HasMedal,
                a.City,
                a.Street,
                a.HouseNumber,
                a.Phone
            }).ToList();
            dataGridViewAbiturients.Columns["RegistrationNumber"].HeaderText = "��������������� �����";
            dataGridViewAbiturients.Columns["LastName"].HeaderText = "�������";
            dataGridViewAbiturients.Columns["FirstName"].HeaderText = "���";
            dataGridViewAbiturients.Columns["Patronymic"].HeaderText = "��������";
            dataGridViewAbiturients.Columns["BirthDate"].HeaderText = "���� ��������";
            dataGridViewAbiturients.Columns["EducationalInstitutionName"].HeaderText = "���������� �����������";
            dataGridViewAbiturients.Columns["EducationalInstitutionNumber"].HeaderText = "����� ����������";
            dataGridViewAbiturients.Columns["EducationalInstitutionCity"].HeaderText = "����� ����������";
            dataGridViewAbiturients.Columns["GraduationDate"].HeaderText = "���� ���������";
            dataGridViewAbiturients.Columns["HasRedDiploma"].HeaderText = "������� ������";
            dataGridViewAbiturients.Columns["HasMedal"].HeaderText = "������";
            dataGridViewAbiturients.Columns["City"].HeaderText = "�����";
            dataGridViewAbiturients.Columns["Street"].HeaderText = "�����";
            dataGridViewAbiturients.Columns["HouseNumber"].HeaderText = "���";
            dataGridViewAbiturients.Columns["Phone"].HeaderText = "�������";

            var specialities = await _specialityRepository.GetAllAsync();
            var specialityViewModel = specialities.Select(s => new { �������� = s.Name }).ToList();
            dataGridViewSpecialities.DataSource = specialityViewModel;

            // �������� ���������
            var subjects = await _subjectRepository.GetAllAsync();
            dataGridViewSubjects.DataSource = subjects;
        }
        private async void dataGridViewAbiturients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var registrationNumber = dataGridViewAbiturients.Rows[e.RowIndex].Cells["RegistrationNumber"].Value.ToString();

            // ��������� ������ �������
            if (e.ColumnIndex == dataGridViewAbiturients.Columns["deleteButton"].Index)
            {
                var result = MessageBox.Show($"������� ����������� {registrationNumber}?",
                                          "������������� ��������",
                                          MessageBoxButtons.YesNo,
                                          MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    await _abiturientRepository.DeleteByNymber(registrationNumber);
                    LoadDataAsync();
                }
            }
            // ��������� ������ ��������
            else if (e.ColumnIndex == dataGridViewAbiturients.Columns["editButton"].Index)
            {
                var abiturient = await _abiturientRepository.GetByRegistrationNumberAsync(registrationNumber);
                if (abiturient != null)
                {
                    var editForm = new EditAbiturientForm(abiturient);
                    editForm.ShowDialog();
                    LoadDataAsync();
                }
            }
            // ��������� ������ ��������
            else if (e.ColumnIndex == dataGridViewAbiturients.Columns["viewButton"].Index)
            {
                var abiturient = await _abiturientRepository.GetByRegistrationNumberAsync(registrationNumber);
                if (abiturient != null)
                {
                    var sub = await _abiturientSubjectRepository.GetByAbiturientIdAsync(abiturient.Id);
                    var viewForm = new ViewAbiturientForm(abiturient,sub);
                    viewForm.ShowDialog();
                }
            }
        }
        private async void dataGridViewSpecialities_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // �������� ������ �� ������� ���� ���
            var viewColumn = viewButtonColumn; // ���������� ���� ������
            var deleteColumn = deleteButtons;  // ���������� ���� ������

            if (viewColumn != null && e.ColumnIndex == viewColumn.Index)
            {
                // �������� �������� �������������
                var specialityName = dataGridViewSpecialities.Rows[e.RowIndex].Cells["��������"].Value?.ToString();

                if (string.IsNullOrEmpty(specialityName))
                {
                    MessageBox.Show("�� ������� �������� �������� �������������.");
                    return;
                }

                try
                {
                    // �������� ID ������������� �� �������� ����� �����������
                    var specialityId = await _specialityRepository.GetIdByName(specialityName);

                    if (specialityId <= 0)
                    {
                        MessageBox.Show("�� ������� �������� ID �������������.");
                        return;
                    }

                    // ��������� ����� ���������
                    var viewForm = new AbiturientsViewForm(specialityId, specialityName, _abiturientRepository);
                    viewForm.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"������ ��� �������� ����� ���������: {ex.Message}",
                                  "������",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Error);
                }
            }
            else if (deleteColumn != null && e.ColumnIndex == deleteColumn.Index)
            {
                // ��� ������������ ��� ��������
                var name = dataGridViewSpecialities.Rows[e.RowIndex].Cells["��������"].Value?.ToString();
                if (string.IsNullOrEmpty(name))
                {
                    MessageBox.Show("�� ������� �������� �������� �������������.");
                    return;
                }

                var result = MessageBox.Show($"�� �������, ��� ������ ������� ������������� {name}?",
                    "������������� ��������",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        await _specialityRepository.DeleteByName(name);
                        LoadDataAsync();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"������ ��� ��������: {ex.Message}",
                                      "������",
                                      MessageBoxButtons.OK,
                                      MessageBoxIcon.Error);
                    }
                }
            }
        }



        private void buttonAddAbiturient_Click(object sender, EventArgs e)
        {
            var addAbiturientForm = new AddAbiturientForm();
            addAbiturientForm.ShowDialog();
            LoadDataAsync(); 
        }

        private void buttonAddSpeciality_Click(object sender, EventArgs e)
        {
            var addSpecialityForm = new AddSpecialityForm();
            addSpecialityForm.ShowDialog();
            LoadDataAsync(); 
        }

        private void buttonAddSubject_Click(object sender, EventArgs e)
        {
            var addSubjectForm = new AddSubjectForm();
            addSubjectForm.ShowDialog();
            LoadDataAsync();
        }

        private void dataGridViewAbiturients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewSubjects_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
