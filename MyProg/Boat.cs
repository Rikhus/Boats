//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyProg
{
    using System;
    using System.Collections.Generic;
    
    public partial class Boat
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Boat()
        {
            this.AccessoryOfBoat = new HashSet<AccessoryOfBoat>();
            this.Delivery = new HashSet<Delivery>();
        }
    
        public int boat_ID { get; set; }
        public string Model { get; set; }
        public string BoatType { get; set; }
        public byte NumberOfRowers { get; set; }
        public bool Mast { get; set; }
        public string Colour { get; set; }
        public string Wood { get; set; }
        public decimal BasePrice { get; set; }
        public int VAT { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AccessoryOfBoat> AccessoryOfBoat { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Delivery> Delivery { get; set; }
    }
}
