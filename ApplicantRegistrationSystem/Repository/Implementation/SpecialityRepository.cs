using ApplicantRegistrationSystem.DAL.Models;
using ApplicantRegistrationSystem.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicantRegistrationSystem.DataBase;
using Microsoft.EntityFrameworkCore;

namespace ApplicantRegistrationSystem.Repository.Implementation
{
    public class SpecialityRepository : BaseRepository<Speciality>, ISpecialityRepository
    {
        private readonly AbiturientContextFactory _contextFactory;

        public SpecialityRepository()
        {
            _contextFactory = new AbiturientContextFactory();

        }


        public async Task DeleteByName(string name)
        {
            try
            {
                using var context = _contextFactory.CreateDbContext();
                var spec = await context.Specialities.FirstOrDefaultAsync(a => a.Name == name);
                context.Specialities.Remove(spec);
                await context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }
        public async Task<int> GetIdByName(string name)
        {
            using var context = _contextFactory.CreateDbContext();
            var speciality = await context.Specialities
                .Where(s => s.Name == name)
                .Select(s => new { s.Id })
                .FirstOrDefaultAsync();

            return speciality?.Id ?? 0;
        }
    }
}
