using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StripsDL.Models
{
    public class StripEF
    {
        public StripEF()
        {       
        }

        public StripEF(int id, string titel, int reeksNr, ICollection<AuteurEF> auteurs, UitgeverijEF uitgeverij, ReeksEF reeks)
        {
            Id = id;
            Titel = titel;
            ReeksNr = reeksNr;
            Auteurs = auteurs;
            Uitgeverij = uitgeverij;
            Reeks = reeks;
        }

        [Key]
        public int Id { get; set; }
        public string Titel { get; set; }
        public int ReeksNr { get; set; }

        //navigational props
        public ICollection<AuteurEF>  Auteurs{ get; set; }
        public UitgeverijEF Uitgeverij { get; set; }
        public ReeksEF Reeks { get; set; }
    }

}

