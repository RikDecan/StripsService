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
                AuteurBL auteur = new AuteurBL();

                auteur.Id = db.Id;
                auteur.Naam = db.Naam;
                auteur.EmailAdres = db.EmailAdres;
                auteur.Strips = db.Strips.Select(MapStrips.MapToDomain).ToList();

                return auteur;
            }
            catch (Exception ex)
            {
                throw new Exception("MapAuteur - MapToDomain");
            }
        }
        public static AuteurEF MapToDB(AuteurBL g)
        {
            try
            {
                //return new AuteurEF(g.Id, g.Naam, g.EmailAdres);

                AuteurEF auteur = new AuteurEF();
                auteur.Id = g.Id;
                auteur.Naam = g.Naam;
                auteur.EmailAdres = g.EmailAdres;
                auteur.Strips = g.Strips.Select(MapStrips.MapToDB).ToList() ?? new List<StripEF>();


                return auteur;

            }
            catch (Exception ex)
            {
                throw new Exception("MapAuteur - MapToDB");
            }
        }
    }
}
