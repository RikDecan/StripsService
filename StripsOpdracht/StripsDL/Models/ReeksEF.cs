using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StripsDL.Models
{
    public class ReeksEF
    {
        public ReeksEF()
        {           
        }
        public ReeksEF(int id, string naam)
        {
            Id = id;
            Naam = naam;
        }

        [Key]
        public int Id { get; set; }
        //[Required]
        public string Naam { get; set; }


        //navigational props
        public ICollection<StripEF> Strips { get; set; }

    }
}
