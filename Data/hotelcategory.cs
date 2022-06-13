namespace GestionHotel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.hotelcategories")]
    public partial class hotelcategory
    {
        public int? categorieid { get; set; }

        public int hotelid { get; set; }

        public int id { get; set; }

        public virtual categories1 categories1 { get; set; }

        public virtual hotels1 hotels1 { get; set; }
    }
}
