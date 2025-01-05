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
                return new ReeksBL(db.Id, db.Naam);
            }
            catch (Exception ex)
            {
                throw new Exception("MapProgram - MapToDomain");
            }
        }
        public static ReeksEF MapToDB(ReeksBL g)
        {
            try
            {
                return new ReeksEF(g.Id, g.Naam);
            }
            catch (Exception ex)
            {
                throw new Exception("MapProgram - MapToDB");
            }
        }
    }
}
