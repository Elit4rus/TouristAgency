//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TouristAgency.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class TravelPackageClient
    {
        public int ID { get; set; }
        public int TravelPackageID { get; set; }
        public int ClientID { get; set; }
    
        public virtual Client Client { get; set; }
        public virtual TravelPackage TravelPackage { get; set; }
    }
}
