using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicantRegistrationSystem.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApplicantRegistrationSystem.DataBase.Config
{
    public class AbiturientConfiguration : IEntityTypeConfiguration<Abiturient>
    {
        public void Configure(EntityTypeBuilder<Abiturient> builder)
        {
            builder.ToTable("Abiturients");

            // Первичный ключ
            builder.HasKey(a => a.Id);

            // Обязательные поля и их длина
            builder.Property(a => a.RegistrationNumber)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(a => a.LastName)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(a => a.FirstName)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(a => a.Patronymic)
                .HasMaxLength(100);

            builder.Property(a => a.BirthDate)
                .IsRequired();

            // Образовательные данные
            builder.Property(a => a.EducationalInstitutionName)
                .HasMaxLength(200);

            builder.Property(a => a.EducationalInstitutionNumber)
                .HasMaxLength(50);

            builder.Property(a => a.EducationalInstitutionCity)
                .HasMaxLength(100);

            builder.Property(a => a.GraduationDate);
            builder.Property(a => a.HasRedDiploma);
            builder.Property(a => a.HasMedal);

            // Адрес
            builder.Property(a => a.City)
                .HasMaxLength(100);

            builder.Property(a => a.Street)
                .HasMaxLength(100);

            builder.Property(a => a.HouseNumber)
                .HasMaxLength(20);

            builder.Property(a => a.Phone)
                .HasMaxLength(50);

            // Отношение с Speciality (один ко многим)
            builder.HasOne(a => a.Speciality)
                .WithMany(s => s.Abiturients)
                .HasForeignKey(a => a.SpecialityId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
