using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicantRegistrationSystem.DAL.Models
{
    public class AbiturientSubject : BaseModel
    {
        [DisplayName("Оценка")]
        public int Grade { get; set; } 

        // Связь с абитуриентом
        public int AbiturientId { get; set; }
        public Abiturient Abiturient { get; set; }

        // Связь с предметом
        public int SubjectId { get; set; }
        public Subject Subject { get; set; }
        [DisplayName("Предмет")]
        public string SubjectName => Subject?.Name;
    }
}
