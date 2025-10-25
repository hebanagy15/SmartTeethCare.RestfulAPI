using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartTeethCare.Core.Entities
{
    public class Prescription : BaseEntity
        {
        public DateTime Date { get; set; }

        // Foreign Keys
        public int PatientId { get; set; }
        public int DoctorId { get; set; }

        // Navigation Properties
        public Patient Patient { get; set; }
        public Doctor Doctor { get; set; }

       
        public ICollection<PrescriptionMedicine>? PrescriptionMedicines { get; set; }
    }
}
