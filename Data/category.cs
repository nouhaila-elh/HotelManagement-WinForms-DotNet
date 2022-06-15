namespace GestionHotel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("archive.categories")]
    public partial class category
    {
        [Required]
        [StringLength(600)]
        public string description { get; set; }

        public int id { get; set; }
    }
}
