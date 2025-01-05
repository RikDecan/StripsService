using Microsoft.AspNetCore.Mvc;
using System.Security.Policy;
using System.Diagnostics.Metrics;
using System.Linq.Expressions;
using System.Reflection;

using StripsBL.Interfaces;
using StripsBL.Models;
using StripsBL.Services;

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
    }
}
