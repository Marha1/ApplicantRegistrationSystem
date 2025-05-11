using ApplicantRegistrationSystem.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicantRegistrationSystem.Repository.Interfaces
{
    public interface ISpecialityRepository : IBaseRepository<Speciality>
    {
        public Task DeleteByName(string name);
        Task<int> GetIdByName(string name); 
    }
}
