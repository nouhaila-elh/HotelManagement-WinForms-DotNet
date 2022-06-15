namespace GestionHotel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.reservations")]
    public partial class reservations1
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public reservations1()
        {
            prestations1 = new HashSet<prestations1>();
        }

        public int? chambreid { get; set; }

        public int? clientid { get; set; }

        public DateTime date_res { get; set; }

        public DateTime date_debut { get; set; }

        public DateTime date_fin { get; set; }

        public DateTime date_pay_arrhes { get; set; }

        public int id { get; set; }

        public double? prix_res { get; set; }

        public double? arrhes { get; set; }

        public virtual chambres1 chambres1 { get; set; }

        public virtual clients1 clients1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<prestations1> prestations1 { get; set; }
    }
}
