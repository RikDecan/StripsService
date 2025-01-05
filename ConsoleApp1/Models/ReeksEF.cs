using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public class ReeksEF
    {

        public ReeksEF()
        {           
        }

        [Key]
        public int Id { get; set; }
        //[Required]
        public string Naam { get; set; }


        //navigational props
        public List<StripEF> Strips { get; set; }

    }
}
