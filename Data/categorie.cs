using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionHotel.Data
{
    public class categorie
    {
        public int id { get; set; }
        public string description { get; set; }
        public List<chambre> chambres { get; set; }


    }
}