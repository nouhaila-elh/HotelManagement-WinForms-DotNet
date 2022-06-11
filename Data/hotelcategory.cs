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

        public virtual category category { get; set; }

        public virtual hotel hotel { get; set; }
    }
}
