//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication2
{
    using System;
    using System.Collections.Generic;
    
    public partial class Automobile
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Automobile()
        {
            this.Automobile_has_Violation = new HashSet<Automobile_has_Violation>();
            this.Driver = new HashSet<Driver>();
        }
    
        public int Series_of_the_technical_passport { get; set; }
        public int Number_of_the_technical_passport { get; set; }
        public string Drivers_FIO { get; set; }
        public string State_number { get; set; }
        public string Drivers_address { get; set; }
        public string Brand { get; set; }
        public string Engine_number { get; set; }
        public string Body_number { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Automobile_has_Violation> Automobile_has_Violation { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Driver> Driver { get; set; }
    }
}
