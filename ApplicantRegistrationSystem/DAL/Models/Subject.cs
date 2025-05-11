using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicantRegistrationSystem.DAL.Models
{
    public class Subject : BaseModel
    {
        [DisplayName("Название")]

        public string Name { get; set; }

        public ICollection<AbiturientSubject> AbiturientSubjects { get; set; }
    }
}
