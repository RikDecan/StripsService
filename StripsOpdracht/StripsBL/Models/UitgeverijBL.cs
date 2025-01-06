using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace StripsBL.Models
{
    public class UitgeverijBL
    {
        public UitgeverijBL()
        {
            
        }

        public UitgeverijBL(int id, string naam, string adres)
        {
            Id = id;
            Naam = naam;
            Adres = adres;
        }

        public int Id { get; set; }
        public string Naam { get; set; }
        public string Adres { get; set; }
        public List<StripBL> Strips { get; set; }

    }
}
