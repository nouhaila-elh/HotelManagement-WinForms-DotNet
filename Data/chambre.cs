using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionHotel.Data
{
    public class chambre
    {
        public int id { get; set; }
        public int tel { get; set; }


        // [ForeignKey("hotel")]
        public int hotelid { get; set; }
        //public hotel hotel { get; set; }


        //[ForeignKey("categorie")]
        public int categorieid { get; set; }
        //public categorie categorie { get; set; }

    }
}