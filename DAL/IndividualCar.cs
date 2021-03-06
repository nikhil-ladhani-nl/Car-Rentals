//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class IndividualCar
    {
        public IndividualCar()
        {
            this.Cars_Sold = new HashSet<Cars_Sold>();
            this.CarFeatures = new HashSet<CarFeature>();
        }
    
        public int CarID { get; set; }
        public string Colour { get; set; }
        public string Current_Mileage { get; set; }
        public string Date_Imported { get; set; }
        public int Manufacture_Year { get; set; }
        public string Transmission { get; set; }
        public string Status { get; set; }
        public string Body_Type { get; set; }
        public int Model_ID { get; set; }
    
        public virtual CarModel CarModel { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cars_Sold> Cars_Sold { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CarFeature> CarFeatures { get; set; }
    }
}
