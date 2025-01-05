 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StripsBL.Models;
using StripsDL.Models;


namespace StripsDL.Mappers
{
    internal class MapAuteur
    {
        public static AuteurBL MapToDomain(AuteurEF db)
        {
            try
            {
                return new AuteurBL(db.Id, db.Naam, db.EmailAdres);
            }
            catch (Exception ex)
            {
                throw new Exception("MapProgram - MapToDomain");
            }
        }
        public static AuteurEF MapToDB(AuteurBL g)
        {
            try
            {
                return new AuteurEF(g.Id, g.Naam, g.EmailAdres);
            }
            catch (Exception ex)
            {
                throw new Exception("MapProgram - MapToDB");
            }
        }
    }
}
