using Microsoft.AspNetCore.Mvc;
using System.Security.Policy;
using System.Diagnostics.Metrics;
using System.Linq.Expressions;
using System.Reflection;

using StripsBL.Interfaces;
using StripsBL.Models;
using StripsBL.Services;
using StripsDL.Models;
using StripsREST.DTO;

//using GymDL.Models;
//using GymDL.Mappers;

//using GymRest.DTO;


namespace StripsREST.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StripController : ControllerBase
    {


        private StripService repo;

        public StripController(StripService repo)
        {
            this.repo = repo;
        }

        [Route("GetStripById/{id}")]
        [HttpGet]
        public StripBL GetStripById(int id)
        {
            return repo.GetStripById(id);
        }

        [Route("GetAllStrips")]
        [HttpGet]
        public List <StripBL> GetAllStrips()
        {
            return repo.GetAllStrips();
        }

        [Route("RemoveStrip/{id}")]
        [HttpDelete]
        public bool RemoveStrip(int id)
        {
            return repo.RemoveStrip(id);
        }

        public StripBL Update(int id, [FromBody] StripDTO stripDTO)
        {
            //UitgeverijBL uitgeverij = Uit.GetUitgeverij(stripDTO.UitgeverijID);
            //Reeks reeks = _reeksService.GetReeks(stripDTO.ReeksID);
            //List<Auteur> auteurs = new List<Auteur>();


            //Strip strip = new Strip(
            //    id,
            //    stripDTO.Titel,
            //    stripDTO.Nummer,
            //    reeks,
            //    auteurs,
            //    uitgeverij
            //    );

            //return repo.Update(strip);

            return null; 
        }

    }
}
