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
                StripBL strip = new StripBL();
                strip.Id = db.Id;
                strip.Titel = db.Titel;
                strip.ReeksNr = db.ReeksNr;
                strip.Auteurs = db.Auteurs.Select(MapAuteur.MapToDomain).ToList() ?? new List<AuteurBL>();
                strip.Uitgeverij = db.Uitgeverij != null ? MapUitgeverij.MapToDomain(db.Uitgeverij) : new UitgeverijBL();
                strip.Reeks = db.Reeks != null ? MapReeks.MapToDomain(db.Reeks) : new ReeksBL();

                return strip;

            }
            catch (Exception ex)
            {
                throw new Exception("MapStrips - MapToDomain");
            }
        }
        public static StripEF MapToDB(StripBL g)
        {
            try
            {
                StripEF strip = new StripEF();
                strip.Id = g.Id;
                strip.Titel = g.Titel;
                strip.ReeksNr = g.ReeksNr;
                strip.Auteurs = g.Auteurs.Select(MapAuteur.MapToDB).ToList() ?? new List<AuteurEF>();
                strip.Uitgeverij = g.Uitgeverij != null ? MapUitgeverij.MapToDB(g.Uitgeverij) : new UitgeverijEF();
                strip.Reeks = g.Reeks != null ? MapReeks.MapToDB(g.Reeks) : new ReeksEF();


                return strip;

            }
            catch (Exception ex)
            {
                throw new Exception("MapStrips - MapToDB");
            }
        }
    }
}
