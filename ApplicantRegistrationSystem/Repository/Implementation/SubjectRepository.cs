using ApplicantRegistrationSystem.DAL.Models;
using ApplicantRegistrationSystem.Repository.Interfaces;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicantRegistrationSystem.DataBase;

namespace ApplicantRegistrationSystem.Repository.Implementation
{
    public class SubjectRepository : BaseRepository<Subject>, ISubjectRepository
    {
        private readonly AbiturientContextFactory _contextFactory;

        public SubjectRepository()
        {
            _contextFactory = new AbiturientContextFactory();
        }
       
    }
}
