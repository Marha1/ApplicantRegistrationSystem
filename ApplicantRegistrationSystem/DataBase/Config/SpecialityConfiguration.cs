using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicantRegistrationSystem.DataBase.Config
{
    using ApplicantRegistrationSystem.DAL.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class SpecialityConfiguration : IEntityTypeConfiguration<Speciality>
    {
        public void Configure(EntityTypeBuilder<Speciality> builder)
        {
            builder.ToTable("Specialities");

            builder.HasKey(s => s.Id);

            builder.Property(s => s.Name)
                .IsRequired()
                .HasMaxLength(100);

            

            // Отношение со списком абитуриентов (один ко многим)
            builder.HasMany(s => s.Abiturients)
                .WithOne(a => a.Speciality)
                .HasForeignKey(a => a.SpecialityId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }

}
