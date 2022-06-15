namespace GestionHotel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.chambres")]
    public partial class chambres1
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public chambres1()
        {
            reservations1 = new HashSet<reservations1>();
        }

        public int? hotelid { get; set; }

        public int? categorieid { get; set; }

        public int tel { get; set; }

        public int id { get; set; }

        public bool? isreserves { get; set; }

        public virtual categories1 categories1 { get; set; }

        public virtual hotels1 hotels1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<reservations1> reservations1 { get; set; }
    }
}
