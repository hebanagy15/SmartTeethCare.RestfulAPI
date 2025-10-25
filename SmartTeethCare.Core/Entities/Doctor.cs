using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartTeethCare.Core.Entities
{
    public class Doctor
    {
        public int Id { get; set; }
        public int Salary { get; set; }
        public int WorkingHours { get; set; }
        public DateTime HiringDate { get; set; }

        // Relation with ApplicationUser
        public string UserId { get; set; }
        public User User { get; set; }
        public ICollection<Prescription> Prescriptions { get; set; }
    }
}
