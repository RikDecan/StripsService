using System.Text;
using System.Threading.Tasks;
using StripsBL.Models;
using StripsDL.Models;

namespace StripsDL.Mappers
{
    internal class MapReeks
    {
        public static ReeksBL MapToDomain(ReeksEF db)
        {
            try
            {
                ReeksBL reeks = new ReeksBL();

                reeks.Id = db.Id;
                reeks.Naam = db.Naam;
                reeks.Strips = db.Strips.Select(MapStrips.MapToDomain).ToList();


                return reeks;
            }
            catch (Exception ex)
            {
                throw new Exception("MapReeks - MapToDomain");
            }
        }
        public static ReeksEF MapToDB(ReeksBL g)
        {
            try
            {
                ReeksEF reeks = new ReeksEF();

                reeks.Id = g.Id;
                reeks.Naam = g.Naam;
                reeks.Strips = g.Strips.Select(MapStrips.MapToDB).ToList() ?? new List<StripEF>();

                return reeks;
            }
            catch (Exception ex)
            {
                throw new Exception("MapReeks - MapToDB");
            }
        }
    }
}
