﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicantRegistrationSystem.DAL.Models
{
    public class Speciality: BaseModel
    {
        public string Name { get; set; }

        public ICollection<Abiturient> Abiturients { get; set; } = new List<Abiturient>();
    }

}
