using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StripsBL.Models
{
    public class ReeksBL
    {
        public ReeksBL()
        {
        }

        public ReeksBL(int id, string naam)
        {
            Id = id;
            Naam = naam;
        }

        public int Id { get; set; }
        public string Naam { get; set; }
        public List<StripBL> Strips { get; set; } = new List<StripBL>();

    }
}
