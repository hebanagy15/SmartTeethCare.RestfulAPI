using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartTeethCare.Core.Entities;

namespace SmartTeethCare.Repository.Data.Configurations
{
    public class PrescriptionConfiguration : IEntityTypeConfiguration<Prescription>
    {
        public void Configure(EntityTypeBuilder<Prescription> builder)
        {
            
            builder.HasKey(p => p.Id);

            // Prescription ↔ Patient (Many-to-One)
            builder.HasOne(p => p.Patient)
                   .WithMany(pt => pt.Prescriptions)
                   .HasForeignKey(p => p.PatientId)
                   .OnDelete(DeleteBehavior.Restrict);

            // Prescription ↔ Doctor (Many-to-One)
            builder.HasOne(p => p.Doctor)
                   .WithMany(d => d.Prescriptions)
                   .HasForeignKey(p => p.DoctorId)
                   .OnDelete(DeleteBehavior.Restrict);

            // Prescription ↔ Medicine (Many-to-Many)PrescriptionMedicine
            builder.HasMany(p => p.PrescriptionMedicines)
                   .WithOne(pm => pm.Prescription)
                   .HasForeignKey(pm => pm.PrescriptionID);
        }
    }
}
