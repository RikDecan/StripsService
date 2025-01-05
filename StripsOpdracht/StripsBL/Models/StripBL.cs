using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StripsBL.Models
{
    public class StripBL
    {
        public StripBL(int id, string titel, int reeksNr)
        {
            Id = id;
            Titel = titel;
            ReeksNr = reeksNr;
        }

        public int Id { get; set; }
        public string Titel { get; set; }
        public int ReeksNr { get; set; }
        public int ReeksNummer { get; set; }
        public UitgeverijBL Uitgeverij { get; set; }
        public List<AuteurBL> Auteurs { get; set; }
    }
}
