using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionHotel.Data
{
    public class hotel
    {
        public int id { get; set; }
        public string nom { get; set; }
        public string address { get; set; }
        public int tel { get; set; }
        public int clss { get; set; }
        public List<chambre> chambres { get; set; }

    }
}