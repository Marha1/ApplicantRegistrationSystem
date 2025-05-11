using ApplicantRegistrationSystem.DataBase;
using ApplicantRegistrationSystem.DAL.Models;
using Microsoft.EntityFrameworkCore;
using ApplicantRegistrationSystem.Repository.Interfaces;

namespace ApplicantRegistrationSystem.Repository.Implementation
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseModel
    {
        private readonly AbiturientContextFactory _contextFactory;

        public BaseRepository()
        {
            _contextFactory = new AbiturientContextFactory();
        }

        public async Task AddAsync(T entity)
        {
            using var context = _contextFactory.CreateDbContext();
            await context.Set<T>().AddAsync(entity);
            await context.SaveChangesAsync();
        }

        public async Task UpdateAsync(T entity)
        {
            using var context = _contextFactory.CreateDbContext();
            context.Set<T>().Update(entity);
            await context.SaveChangesAsync();
        }

        public async Task DeleteAsync(T entity)
        {
            using var context = _contextFactory.CreateDbContext();
            context.Set<T>().Remove(entity);
            await context.SaveChangesAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            using var context = _contextFactory.CreateDbContext();
            return await context.Set<T>().FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task<List<T>> GetAllAsync()
        {
            using var context = _contextFactory.CreateDbContext();
            return await context.Set<T>().ToListAsync();
        }
    }
}
