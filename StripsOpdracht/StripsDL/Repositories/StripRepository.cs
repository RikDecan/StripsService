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

                return MapStrips.MapToDomain(strip);
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

    }
}
