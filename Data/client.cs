namespace GestionHotel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("archive.clients")]
    public partial class client
    {
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
    }
}
