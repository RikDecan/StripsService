using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                var strip = _context.Strips.FirstOrDefault(e => e.Id == id);

                if (strip == null)
                {
                    throw new Exception("Equipment not found");
                }

                return MapStrips.MapToDomain(strip);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

    }
}
