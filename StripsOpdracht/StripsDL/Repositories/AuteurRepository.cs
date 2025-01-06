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
using static System.Runtime.InteropServices.JavaScript.JSType;




namespace StripsDL.Repositories
{
    public class AuteurRepository : IAuteurRepository
    {
        private readonly StripContext _context;

        public AuteurRepository(StripContext context)
        {
            _context = context;
        }



        public AuteurBL GetAuteurById(int id)
        {
            var auteur = _context.Auteurs.FirstOrDefault(a => a.Id == id);

            if (auteur == null)
            {
                throw new Exception("auteur not found");
            }

            return MapAuteur.MapToDomain(auteur);
        }

        public AuteurBL UpdateAuteur(AuteurBL auteur)
        {
            //verder uitwerken

            return auteur;
        }


    }
}