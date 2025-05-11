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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ApplicantRegistrationSystem.Repository.Implementation
{
    public class AbiturientRepository : BaseRepository<Abiturient>, IAbiturientRepository
    {
        private readonly AbiturientContextFactory _contextFactory;

        public AbiturientRepository()
        {
            _contextFactory = new AbiturientContextFactory();
        }
        public async Task<List<Abiturient>> GetBySpecialityAsync(int specialityId)
        {
            using var context = _contextFactory.CreateDbContext();
            return await context.Abiturients
            .Where(a => a.SpecialityId == specialityId)
                .ToListAsync();
        }

        public async Task<List<Abiturient>> GetWithHonorsAsync()
        {
            using var context = _contextFactory.CreateDbContext();
            return await context.Abiturients
                .Where(a => a.HasRedDiploma || a.HasMedal)
                .ToListAsync();
        }
       public async Task DeleteByNymber(string number)
        {
            using var context = _contextFactory.CreateDbContext();
            var abiturient = await context.Abiturients
                .FirstOrDefaultAsync(a => a.RegistrationNumber == number);
            context.Abiturients.Remove(abiturient);
            await context.SaveChangesAsync();
        }

        public async Task<Abiturient> GetByRegistrationNumberAsync(string? registrationNumber)
        {
            using var context = _contextFactory.CreateDbContext();
             return await  context.Abiturients.Include(x=>x.Speciality)
                .FirstOrDefaultAsync(a => a.RegistrationNumber == registrationNumber);
        }
        public async Task<List<Abiturient>> GetBySpecialityWithDetailsAsync(int specialityId)
        {
            using var context = _contextFactory.CreateDbContext();
            return await context.Abiturients
                .Where(a => a.SpecialityId == specialityId)
                .Include(a => a.AbiturientSubjects)
                    .ThenInclude(asub => asub.Subject)
                .OrderBy(a => a.LastName)
                .ToListAsync();
        }
    }
}
