using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StripDL.Models
{
    public class AuteurEF
    {
        public AuteurEF()
        {
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
