using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StripsBL.Models
{
    public class AuteurBL
    {
        public AuteurBL(int id, string naam, string emailAdres)
        {
            Id = id;
            Naam = naam;
            EmailAdres = emailAdres;
        }

        public int Id { get; set; }
        public string Naam { get; set; }
        public string EmailAdres { get; set; }
        public List<StripBL> Strips { get; set; }
    }
}
