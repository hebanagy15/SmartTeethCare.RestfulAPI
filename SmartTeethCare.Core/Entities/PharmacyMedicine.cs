using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartTeethCare.Core.Entities
{
    public class PharmacyMedicine
    {
        // Composite Key: PharmacyID + MedicineID
        public int PharmacyID { get; set; }  
        public int MedicineID { get; set; }   

        
        public int StockQuantity { get; set; }

        // Navigation properties
        public Pharmacy Pharmacy { get; set; }
        public Medicine Medicine { get; set; }
    }
}
س