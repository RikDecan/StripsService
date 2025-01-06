using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StripsDL.Models
{
    public class UitgeverijEF
    {
        public UitgeverijEF()
        {            
        }

        public UitgeverijEF(int id, string naam, string? adres)
        {
            Id = id;
            Naam = naam;
            Adres = adres;
        }

        [Key]
        public int Id { get; set; }
        public string Naam { get; set; }
        public string?  Adres { get; set; }

        //navigational props
        public ICollection <StripEF> Strips { get; set; }
    }
}
