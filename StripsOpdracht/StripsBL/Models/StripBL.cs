using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StripsBL.Models
{
    public class StripBL
    {
        public StripBL()
        {
        }

        public StripBL(int id, string titel, int reeksNr, ICollection<AuteurBL> auteurs, UitgeverijBL uitgeverij, ReeksBL reeks)
        {
            Id = id;
            Titel = titel;
            ReeksNr = reeksNr;
            Auteurs = auteurs;
            Uitgeverij = uitgeverij;
            Reeks = reeks;
        }

        public int Id { get; set; }
        public string Titel { get; set; }
        public int ReeksNr { get; set; }

        public ICollection<AuteurBL> Auteurs { get; set; }
        public UitgeverijBL Uitgeverij { get; set; }
        public ReeksBL Reeks { get; set; }

    }
}
