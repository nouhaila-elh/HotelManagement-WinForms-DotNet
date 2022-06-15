namespace GestionHotel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("archive.chambres")]
    public partial class chambre
    {
        public int? hotelid { get; set; }

        public int? categorieid { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int tel { get; set; }

        [Key]
        [Column(Order = 1)]
        public int id { get; set; }

        public bool? isreserves { get; set; }
    }
}
