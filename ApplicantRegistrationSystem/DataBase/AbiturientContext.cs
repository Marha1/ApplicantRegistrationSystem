using ApplicantRegistrationSystem.DAL.Models;
using ApplicantRegistrationSystem.DataBase.Config;
using Microsoft.EntityFrameworkCore;
namespace ApplicantRegistrationSystem.DataBase
{
    public class AbiturientContext : DbContext
    {
        public DbSet<Abiturient> Abiturients { get; set; }
        public DbSet<Speciality> Specialities { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<AbiturientSubject> AbiturientSubject { get; set; }


        public AbiturientContext(DbContextOptions<AbiturientContext> options) : base(options) { }

        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AbiturientConfiguration());
            modelBuilder.ApplyConfiguration(new SpecialityConfiguration());
            modelBuilder.ApplyConfiguration(new SubjectConfiguration());
        }
    }
}
