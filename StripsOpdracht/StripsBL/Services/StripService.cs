using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StripsBL.Interfaces;
using StripsBL.Models;

namespace StripsBL.Services
{
    public class StripService
    {

        private IStripRepository repo;

        public StripService(IStripRepository repo)
        {
            this.repo = repo;
        }

        public StripBL GetStripById(int id)
        {
                return repo.GetStripById(id);         
        }
        public List<StripBL> GetAllStrips()
        {
            return repo.GetAllStrips();
        }


    }
}
