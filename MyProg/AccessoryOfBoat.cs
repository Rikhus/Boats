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
    
    public partial class AccessoryOfBoat
    {
        public int Fit_ID { get; set; }
        public Nullable<int> Accessory_ID { get; set; }
        public Nullable<int> Boat_ID { get; set; }
    
        public virtual Accessory Accessory { get; set; }
        public virtual Boat Boat { get; set; }
    }
}
