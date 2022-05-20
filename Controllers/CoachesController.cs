using Microsoft.AspNetCore.Mvc;
using REST_SQL_New.Data;
using REST_SQL_New.Models;
using System.Collections.Generic;

namespace REST_SQL_New.Controllers
{
    [Route("api/coaches")]
    [ApiController]
    public class CoachesController : ControllerBase
    {
        private readonly ICoachRepo _repository;

        public CoachesController(ICoachRepo repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Coach>> GetAllCoaches()
        {
            var coachItems = _repository.GetAllCoaches();

            return Ok(coachItems);
        }
        //GET: api/coaches/5
        [HttpGet("{id}")]
        public ActionResult<IEnumerable<Coach>> GetCoachById(int id)
        {
            var coachItem = _repository.GetCoachById(id);
            return Ok(coachItem);
        }
    }
}
