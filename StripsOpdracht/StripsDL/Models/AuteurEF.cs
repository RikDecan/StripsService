using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StripsDL.Models
{
    public class AuteurEF
    {
        public AuteurEF()
        {
        }

        public AuteurEF(int id, string naam)
        {
            Id = id;
            Naam = naam;
        }

        public AuteurEF(int id, string naam, string emailAdres)
        {
            Id = id;
            Naam = naam;
            EmailAdres = emailAdres;
        }

        [Key]
        public int Id { get; set; }
        //[Required]
        public string Naam { get; set; }
        //[Required]
        public string EmailAdres { get; set; }

        //navigational props

        public ICollection <StripEF> Strips { get; set; }

    }
}
