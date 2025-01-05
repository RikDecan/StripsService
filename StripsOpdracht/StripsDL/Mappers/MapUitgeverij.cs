using StripsBL.Models;
using StripsDL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StripsDL.Mappers
{
    internal class MapUitgeverij
    {
        public static UitgeverijBL MapToDomain(UitgeverijEF db)
        {
            try
            {
                return new UitgeverijBL(db.Id, db.Naam, db.Adres);
            }
            catch (Exception ex)
            {
                throw new Exception("MapProgram - MapToDomain");
            }
        }
        public static UitgeverijEF MapToDB(UitgeverijBL g)
        {
            try
            {
                return new UitgeverijEF(g.Id, g.Naam, g.Adres);
            }
            catch (Exception ex)
            {
                throw new Exception("MapProgram - MapToDB");
            }
        }
    }
}
