//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace THC
{
    using System;
    using System.Collections.Generic;
    
    public partial class TableTreaty
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TableTreaty()
        {
            this.TableClient = new HashSet<TableClient>();
            this.TableServiceTreaty = new HashSet<TableServiceTreaty>();
        }
    
        public string TreatyNumber { get; set; }
        public System.DateTime TreatyDateСonclusion { get; set; }
        public int TreatyType { get; set; }
        public string TreatyReasonForTermination { get; set; }
        public Nullable<System.DateTime> TreatyTerminationDate { get; set; }
        public int TreatyPersonalAccount { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TableClient> TableClient { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TableServiceTreaty> TableServiceTreaty { get; set; }
        public virtual TableTypeTreaty TableTypeTreaty { get; set; }
    }
}
