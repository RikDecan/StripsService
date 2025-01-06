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
                //return new UitgeverijBL(db.Id, db.Naam, db.Adres);

                UitgeverijBL uitgeverij = new UitgeverijBL();

                uitgeverij.Id = db.Id;
                uitgeverij.Naam = db.Naam;
                uitgeverij.Adres = db.Adres;

                return uitgeverij;
            }
            catch (Exception ex)
            {
                throw new Exception("MapUitgeverij - MapToDomain");
            }
        }
        public static UitgeverijEF MapToDB(UitgeverijBL g)
        {
            try
            {
                //return new UitgeverijEF(g.Id, g.Naam, g.Adres);
                UitgeverijEF uitgeverij = new UitgeverijEF();


                uitgeverij.Id=g.Id;
                uitgeverij.Naam=g.Naam;
                uitgeverij.Adres=g.Adres;

                return uitgeverij;
            }
            catch (Exception ex)
            {
                throw new Exception("MapUitgeverij - MapToDB");
            }
        }
    }
}
