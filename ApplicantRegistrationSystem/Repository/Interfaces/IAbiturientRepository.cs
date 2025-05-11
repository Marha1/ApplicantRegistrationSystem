using ApplicantRegistrationSystem.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicantRegistrationSystem.Repository.Interfaces
{
    public interface IAbiturientRepository : IBaseRepository<Abiturient>
    {
        Task<List<Abiturient>> GetBySpecialityAsync(int specialityId);
        Task<List<Abiturient>> GetWithHonorsAsync();
        Task DeleteByNymber(string number);
        Task<Abiturient> GetByRegistrationNumberAsync(string? registrationNumber);
        Task<List<Abiturient>> GetBySpecialityWithDetailsAsync(int specialityId);
    }
}
