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

            // Инициализация репозиториев
            _abiturientRepository = new AbiturientRepository();
            _specialityRepository = new SpecialityRepository();
            _subjectRepository = new SubjectRepository();
            _abiturientSubjectRepository = new AbiturientSubjectRepository();
            LoadDataAsync();
        }

        private async void LoadDataAsync()
        {
            // Загрузка абитуриентов
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
            dataGridViewAbiturients.Columns["RegistrationNumber"].HeaderText = "Регистрационный номер";
            dataGridViewAbiturients.Columns["LastName"].HeaderText = "Фамилия";
            dataGridViewAbiturients.Columns["FirstName"].HeaderText = "Имя";
            dataGridViewAbiturients.Columns["Patronymic"].HeaderText = "Отчество";
            dataGridViewAbiturients.Columns["BirthDate"].HeaderText = "Дата рождения";
            dataGridViewAbiturients.Columns["EducationalInstitutionName"].HeaderText = "Учреждение образования";
            dataGridViewAbiturients.Columns["EducationalInstitutionNumber"].HeaderText = "Номер учреждения";
            dataGridViewAbiturients.Columns["EducationalInstitutionCity"].HeaderText = "Город учреждения";
            dataGridViewAbiturients.Columns["GraduationDate"].HeaderText = "Дата окончания";
            dataGridViewAbiturients.Columns["HasRedDiploma"].HeaderText = "Красный диплом";
            dataGridViewAbiturients.Columns["HasMedal"].HeaderText = "Медаль";
            dataGridViewAbiturients.Columns["City"].HeaderText = "Город";
            dataGridViewAbiturients.Columns["Street"].HeaderText = "Улица";
            dataGridViewAbiturients.Columns["HouseNumber"].HeaderText = "Дом";
            dataGridViewAbiturients.Columns["Phone"].HeaderText = "Телефон";

            var specialities = await _specialityRepository.GetAllAsync();
            var specialityViewModel = specialities.Select(s => new { Название = s.Name }).ToList();
            dataGridViewSpecialities.DataSource = specialityViewModel;

            // Загрузка предметов
            var subjects = await _subjectRepository.GetAllAsync();
            dataGridViewSubjects.DataSource = subjects;
        }
        private async void dataGridViewAbiturients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var registrationNumber = dataGridViewAbiturients.Rows[e.RowIndex].Cells["RegistrationNumber"].Value.ToString();

            // Обработка кнопки Удалить
            if (e.ColumnIndex == dataGridViewAbiturients.Columns["deleteButton"].Index)
            {
                var result = MessageBox.Show($"Удалить абитуриента {registrationNumber}?",
                                          "Подтверждение удаления",
                                          MessageBoxButtons.YesNo,
                                          MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    await _abiturientRepository.DeleteByNymber(registrationNumber);
                    LoadDataAsync();
                }
            }
            // Обработка кнопки Изменить
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
            // Обработка кнопки Просмотр
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

            // Получаем ссылки на колонки один раз
            var viewColumn = viewButtonColumn; // Используем поле класса
            var deleteColumn = deleteButtons;  // Используем поле класса

            if (viewColumn != null && e.ColumnIndex == viewColumn.Index)
            {
                // Получаем название специальности
                var specialityName = dataGridViewSpecialities.Rows[e.RowIndex].Cells["Название"].Value?.ToString();

                if (string.IsNullOrEmpty(specialityName))
                {
                    MessageBox.Show("Не удалось получить название специальности.");
                    return;
                }

                try
                {
                    // Получаем ID специальности по названию через репозиторий
                    var specialityId = await _specialityRepository.GetIdByName(specialityName);

                    if (specialityId <= 0)
                    {
                        MessageBox.Show("Не удалось получить ID специальности.");
                        return;
                    }

                    // Открываем форму просмотра
                    var viewForm = new AbiturientsViewForm(specialityId, specialityName, _abiturientRepository);
                    viewForm.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при открытии формы просмотра: {ex.Message}",
                                  "Ошибка",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Error);
                }
            }
            else if (deleteColumn != null && e.ColumnIndex == deleteColumn.Index)
            {
                // Ваш существующий код удаления
                var name = dataGridViewSpecialities.Rows[e.RowIndex].Cells["Название"].Value?.ToString();
                if (string.IsNullOrEmpty(name))
                {
                    MessageBox.Show("Не удалось получить название специальности.");
                    return;
                }

                var result = MessageBox.Show($"Вы уверены, что хотите удалить специальность {name}?",
                    "Подтверждение удаления",
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
                        MessageBox.Show($"Ошибка при удалении: {ex.Message}",
                                      "Ошибка",
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
