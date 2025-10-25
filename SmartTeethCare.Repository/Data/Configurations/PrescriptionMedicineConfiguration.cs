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
    internal class PrescriptionMedicineConfiguration : IEntityTypeConfiguration<PrescriptionMedicine>
    {
        public void Configure(EntityTypeBuilder<PrescriptionMedicine> builder)
        {
            // Composite Key
            builder.HasKey(pm => new { pm.PrescriptionID, pm.MedicineID });

            builder.HasOne(pm => pm.Prescription)
                   .WithMany(p => p.PrescriptionMedicines)
                   .HasForeignKey(pm => pm.PrescriptionID);

           
            builder.HasOne(pm => pm.Medicine)
                   .WithMany()
                   .HasForeignKey(pm => pm.MedicineID);
        }
    }
    }
