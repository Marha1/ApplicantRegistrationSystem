using ApplicantRegistrationSystem.DAL.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicantRegistrationSystem.DataBase.Config
{
    public class AbiturientSubjectConfiguration : IEntityTypeConfiguration<AbiturientSubject>
    {
        public void Configure(EntityTypeBuilder<AbiturientSubject> builder)
        {
            builder.ToTable("AbiturientSubjects");
            builder.HasKey(a => a.Id);

            builder.Property(a => a.Grade)
                .IsRequired();

            // Связь с абитуриентом
            builder.HasOne(a => a.Abiturient)
                .WithMany(a => a.AbiturientSubjects)
                .HasForeignKey(a => a.AbiturientId)
                .OnDelete(DeleteBehavior.Cascade);

            // Связь с предметом
            builder.HasOne(a => a.Subject)
                .WithMany(s => s.AbiturientSubjects)
                .HasForeignKey(a => a.SubjectId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
