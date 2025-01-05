using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StripsBL.Models;


namespace StripsBL.Interfaces
{
    public interface IStripRepository
    {
        public StripBL GetStripById(int id);      


    }
}
