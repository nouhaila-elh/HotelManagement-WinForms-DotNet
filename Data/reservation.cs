namespace GestionHotel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.reservations")]
    public partial class reservation
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public reservation()
        {
            prestations = new HashSet<prestation>();
        }

        public int? chambreid { get; set; }

        public int? clientid { get; set; }

        public DateTime date_res { get; set; }

        public DateTime date_debut { get; set; }

        public DateTime date_fin { get; set; }

        public DateTime date_pay_arrhes { get; set; }

        public int id { get; set; }

        public virtual chambre chambre { get; set; }

        public virtual client client { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<prestation> prestations { get; set; }
    }
}
