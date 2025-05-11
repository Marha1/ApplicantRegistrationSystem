using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using ApplicantRegistrationSystem.DAL.Models;

namespace ApplicantRegistrationSystem.Services
{
    public class AbiturientPrinter
    {
        private readonly Abiturient _abiturient;
        private readonly List<AbiturientSubject> _abiturientSubjects;

        public AbiturientPrinter(Abiturient abiturient, List<AbiturientSubject> abiturientSubjects)
        {
            _abiturient = abiturient;
            _abiturientSubjects = abiturientSubjects;
        }

        public void Print()
        {
            var printDocument = new PrintDocument();
            printDocument.PrintPage += PrintPageHandler;

            var printDialog = new PrintDialog
            {
                Document = printDocument,
                UseEXDialog = true
            };

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        private void PrintPageHandler(object sender, PrintPageEventArgs e)
        {
            var graphics = e.Graphics;
            var fontTitle = new Font("Segoe UI", 16, FontStyle.Bold);
            var fontHeader = new Font("Segoe UI", 12, FontStyle.Bold);
            var fontRegular = new Font("Segoe UI", 10);

            var yPos = 50;
            var leftMargin = 50;

            // Заголовок
            graphics.DrawString($"Данные абитуриента: {_abiturient.LastName} {_abiturient.FirstName}",
                fontTitle, Brushes.Black, leftMargin, yPos);
            yPos += 40;

            // Линия под заголовком
            graphics.DrawLine(Pens.Black, leftMargin, yPos, e.PageBounds.Width - leftMargin, yPos);
            yPos += 30;

            // Основные данные
            DrawField(graphics, "Рег. номер", _abiturient.RegistrationNumber, ref yPos, leftMargin, fontHeader, fontRegular);
            DrawField(graphics, "ФИО", $"{_abiturient.LastName} {_abiturient.FirstName} {_abiturient.Patronymic}",
                ref yPos, leftMargin, fontHeader, fontRegular);
            DrawField(graphics, "Дата рождения", _abiturient.BirthDate.ToShortDateString(),
                ref yPos, leftMargin, fontHeader, fontRegular);
            DrawField(graphics, "Учебное заведение", $"{_abiturient.EducationalInstitutionName} №{_abiturient.EducationalInstitutionNumber}, {_abiturient.EducationalInstitutionCity}",
                ref yPos, leftMargin, fontHeader, fontRegular);
            DrawField(graphics, "Дата окончания", _abiturient.GraduationDate.ToShortDateString(),
                ref yPos, leftMargin, fontHeader, fontRegular);
            DrawField(graphics, "Награды", GetAwardsString(), ref yPos, leftMargin, fontHeader, fontRegular);
            DrawField(graphics, "Адрес", $"{_abiturient.City}, {_abiturient.Street}, д.{_abiturient.HouseNumber}",
                ref yPos, leftMargin, fontHeader, fontRegular);
            DrawField(graphics, "Телефон", _abiturient.Phone, ref yPos, leftMargin, fontHeader, fontRegular);
            DrawField(graphics, "Специальность", _abiturient.Speciality.Name, ref yPos, leftMargin, fontHeader, fontRegular);
            DrawField(graphics, "Льгота", _abiturient.BenefitType.ToString(), ref yPos, leftMargin, fontHeader, fontRegular);

            // Предметы и оценки
            yPos += 20;
            graphics.DrawString("Оценки по предметам:", fontHeader, Brushes.Black, leftMargin, yPos);
            yPos += 30;

            if (_abiturientSubjects != null && _abiturientSubjects.Any())
            {
                foreach (var subject in _abiturientSubjects.OrderBy(s => s.Subject?.Name))
                {
                    DrawField(graphics, subject.Subject?.Name ?? "Неизвестный предмет",
                        subject.Grade.ToString(), ref yPos, leftMargin + 20, fontRegular, fontRegular);
                }
            }
            else
            {
                graphics.DrawString("Нет данных об оценках", fontRegular, Brushes.Black, leftMargin + 20, yPos);
                yPos += 20;
            }

            // Подпись
            yPos += 30;
            graphics.DrawString($"Дата печати: {DateTime.Now.ToShortDateString()}",
                fontRegular, Brushes.Black, leftMargin, yPos);
        }

        private string GetAwardsString()
        {
            var awards = new List<string>();
            if (_abiturient.HasRedDiploma) awards.Add("Красный диплом");
            if (_abiturient.HasMedal) awards.Add("Медаль");
            return awards.Any() ? string.Join(", ", awards) : "Нет";
        }

        private void DrawField(Graphics graphics, string label, string value, ref int yPos, int leftMargin, Font fontLabel, Font fontValue)
        {
            graphics.DrawString(label + ":", fontLabel, Brushes.Black, leftMargin, yPos);
            graphics.DrawString(value, fontValue, Brushes.Black, leftMargin + 150, yPos);
            yPos += 25;
        }
    }
}