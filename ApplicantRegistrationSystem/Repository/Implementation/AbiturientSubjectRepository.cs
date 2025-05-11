using ApplicantRegistrationSystem.DAL.Models;
using ApplicantRegistrationSystem.DataBase;
using ApplicantRegistrationSystem.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicantRegistrationSystem.Repository.Implementation
{
    public class AbiturientSubjectRepository : BaseRepository<AbiturientSubject>, IAbiturientSubjectRepository
    {
        private readonly AbiturientContextFactory _contextFactory;

        public AbiturientSubjectRepository()
        {
            _contextFactory = new AbiturientContextFactory();
        }

        public async Task<List<AbiturientSubject>> GetByAbiturientIdAsync(int abiturientId)
        {
            using var context = _contextFactory.CreateDbContext();
            return await context.AbiturientSubject
                .Include(a => a.Subject) // Подгружаем связанные данные о предмете
                .Where(a => a.AbiturientId == abiturientId)
                .ToListAsync();
        }
    }
}   

