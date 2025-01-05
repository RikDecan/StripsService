using System.Text;
using System.Threading.Tasks;
using StripsBL.Models;
using StripsDL.Models;

namespace StripsDL.Mappers
{
    internal class MapStrips
    {
        public static StripBL MapToDomain(StripEF db)
        {
            try
            {
                return new StripBL(db.Id, db.Titel, db.ReeksNr);
            }
            catch (Exception ex)
            {
                throw new Exception("MapProgram - MapToDomain");
            }
        }
        public static StripEF MapToDB(StripBL g)
        {
            try
            {
                return new StripEF(g.Id, g.Titel, g.ReeksNr);
            }
            catch (Exception ex)
            {
                throw new Exception("MapProgram - MapToDB");
            }
        }
    }
}
