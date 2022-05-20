using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using REST_SQL_New.Data;
using REST_SQL_New.Models;
using System.Collections.Generic;

namespace REST_SQL_New.Controllers
{
    [Route("api/athletes")]
    [ApiController]
    public class AthletesController : ControllerBase
    {
        private readonly IAthleteRepo _repository;

        public AthletesController(IAthleteRepo repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Athlete>> GetAllAthletes()
        {
            var athleteItems = _repository.GetAllAthletes();

            return Ok(athleteItems);
        }
        //GET: api/athletes/5
        [HttpGet("{id}")]
        public ActionResult<IEnumerable<Athlete>> GetAthleteById(int id)
        {
            var athleteItem = _repository.GetAthleteById(id);
            return Ok(athleteItem);
        }
    }
}
