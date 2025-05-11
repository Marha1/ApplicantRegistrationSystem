using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicantRegistrationSystem.DAL.Models
{
    using ApplicantRegistrationSystem.Primitiv;
    using System.ComponentModel;

    public class Abiturient : BaseModel
    {
        [DisplayName("Регистрационный номер")]
        public string RegistrationNumber { get; set; }

        [DisplayName("Фамилия")]
        public string LastName { get; set; }

        [DisplayName("Имя")]
        public string FirstName { get; set; }

        [DisplayName("Отчество")]
        public string Patronymic { get; set; }

        [DisplayName("Дата рождения")]
        public DateTime BirthDate { get; set; }

        [DisplayName("Учреждение образования")]
        public string EducationalInstitutionName { get; set; }

        [DisplayName("Номер учреждения")]
        public string EducationalInstitutionNumber { get; set; }

        [DisplayName("Город учреждения")]
        public string EducationalInstitutionCity { get; set; }

        [DisplayName("Дата окончания")]
        public DateTime GraduationDate { get; set; }

        [DisplayName("Красный диплом")]
        public bool HasRedDiploma { get; set; }

        [DisplayName("Медаль")]
        public bool HasMedal { get; set; }

        [DisplayName("Город")]
        public string City { get; set; }

        [DisplayName("Улица")]
        public string Street { get; set; }

        [DisplayName("Дом")]
        public string HouseNumber { get; set; }

        [DisplayName("Телефон")]
        public string Phone { get; set; }

         [DisplayName("Тип льготы")]
        public BenefitType BenefitType { get; set; } = BenefitType.None;

        [DisplayName("Документ о льготе")]
        public string BenefitDocumentNumber { get; set; }

        [DisplayName("Дата выдачи документа")]
        public DateTime? BenefitDocumentDate { get; set; }

        [DisplayName("Кем выдан")]
        public string BenefitIssuedBy { get; set; }

        public int SpecialityId { get; set; }
        public Speciality Speciality { get; set; }
        public ICollection<AbiturientSubject> AbiturientSubjects { get; set; }

    }

}
