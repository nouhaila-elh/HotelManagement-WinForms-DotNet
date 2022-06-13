namespace GestionHotel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.hotels")]
    public partial class hotels1
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public hotels1()
        {
            chambres1 = new HashSet<chambres1>();
            hotelcategories = new HashSet<hotelcategory>();
        }

        [Required]
        [StringLength(600)]
        public string nom { get; set; }

        [Required]
        [StringLength(300)]
        public string address { get; set; }

        public int tel { get; set; }

        public int clss { get; set; }

        public int id { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<chambres1> chambres1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<hotelcategory> hotelcategories { get; set; }
    }
}
