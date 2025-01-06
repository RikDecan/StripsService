using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StripsBL.Interfaces;
using StripsBL.Models;
using StripsDL.Mappers;
using StripsDL.Models;




namespace StripsDL.Repositories
{
    public class StripRepository : IStripRepository
    {

        private readonly StripContext _context;

        public StripRepository(StripContext context)
        {
            _context = context;
        }

        public StripBL GetStripById(int id)
        {
            try
            {
                var strip = _context.Strips
                    .Include(s => s.Auteurs)
                    .Include(s => s.Reeks)
                    .Include(s => s.Uitgeverij)
                    .FirstOrDefault(e => e.Id == id);

                if (strip == null)
                {
                    throw new Exception("strip not found");
                }

                return MapStrips.MapToDomainZonderReeks(strip);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public List<StripBL> GetAllStrips()
        {
            return _context.Strips.Include(strip => strip.Auteurs).Include(strip => strip.Reeks).Include(strip => strip.Uitgeverij).Select(strip => MapStrips.MapToDomain(strip)).ToList();
        }

        public bool RemoveStrip(int id)
        {
           var stripEF = _context.Strips.FirstOrDefault( m => m.Id == id);

            if(stripEF != null)
            {
                _context.Strips.Remove(stripEF);
                _context.SaveChanges();
                return true;
            }
            else 
            { 
                throw new Exception("This strip doesn't exist");
            }
        }


    }
}
