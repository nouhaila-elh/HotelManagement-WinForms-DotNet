namespace GestionHotel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("archive.hotels")]
    public partial class hotel
    {
        [Required]
        [StringLength(600)]
        public string nom { get; set; }

        [Required]
        [StringLength(300)]
        public string address { get; set; }

        public int tel { get; set; }

        public int clss { get; set; }

        public int id { get; set; }
    }
}
