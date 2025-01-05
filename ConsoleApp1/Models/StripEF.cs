using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public class StripEF
    {

        public StripEF()
        {       
        }


        [Key]
        public int Id { get; set; }
        public string Titel { get; set; }
        public int ReeksNr { get; set; }


        //navigational props
        public List<AutheurEF>  Autheurs{ get; set; }
        public UitgeverijEF Uitgeverij { get; set; }
        public ReeksEF Reeks { get; set; }

    }

}

