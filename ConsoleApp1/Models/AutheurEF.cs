using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public class AutheurEF
    {
        public AutheurEF()
        {
        }

        [Key]
        public int Id { get; set; }
        //[Required]
        public string Naam { get; set; }
        //[Required]
        public string EmailAdres { get; set; }

        //navigational props

        List <StripEF> Strips { get; set; }

    }
}
