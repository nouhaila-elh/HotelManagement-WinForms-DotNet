namespace GestionHotel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.reservationarchives")]
    public partial class reservationarchive
    {
        public int? chambreid { get; set; }

        public int? clientid { get; set; }

        public DateTime date_res { get; set; }

        public DateTime date_debut { get; set; }

        public DateTime date_fin { get; set; }

        public DateTime date_pay_arrhes { get; set; }

        public int id { get; set; }

        public virtual chambre chambre { get; set; }

        public virtual client client { get; set; }
    }
}
