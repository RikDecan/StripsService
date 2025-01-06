using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StripsBL.Interfaces;
using StripsBL.Models;


namespace StripsBL.Services
{
    public class AuteurService
    {
        private IAuteurRepository repo;

        public AuteurService(IAuteurRepository repo)
        {
            this.repo = repo;
        }

        public AuteurBL GetAuteurById(int id)
        {
            return repo.GetAuteurById(id);
        }

        public AuteurBL UpdateAuteur(AuteurBL auteur)
        {
            return repo.UpdateAuteur(auteur);
        }
    }
}
