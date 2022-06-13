namespace GestionHotel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.clients")]
    public partial class clients1
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public clients1()
        {
            reservations1 = new HashSet<reservations1>();
        }

        [Required]
        [StringLength(255)]
        public string nom { get; set; }

        [Required]
        [StringLength(255)]
        public string prenom { get; set; }

        [Required]
        [StringLength(255)]
        public string address { get; set; }

        [Required]
        [StringLength(255)]
        public string ville { get; set; }

        public int code_postale { get; set; }

        [Required]
        [StringLength(255)]
        public string pays { get; set; }

        public int tel { get; set; }

        public int id { get; set; }

        [Required]
        [StringLength(255)]
        public string email { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<reservations1> reservations1 { get; set; }
    }
}
