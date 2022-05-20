using Microsoft.AspNetCore.Mvc;
using REST_SQL_New.Data;
using REST_SQL_New.Data.Interfaces;
using REST_SQL_New.Models;
using System.Collections.Generic;

namespace REST_SQL_New.Controllers
{
    [Route("api/medaltotals")]
    [ApiController]
    public class MedalTotalsController : ControllerBase
    {
        private readonly IMedalTotalRepo _repository;

        public MedalTotalsController(IMedalTotalRepo repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<MedalTotal>> GetAllMedalTotals()
        {
            var medalTotalItems = _repository.GetAllMedalTotals();

            return Ok(medalTotalItems);
        }
        //GET: api/medaltotals/5
        [HttpGet("{id}")]
        public ActionResult<IEnumerable<MedalTotal>> GetMedalTotalById(int id)
        {
            var medalTotalItem = _repository.GetMedalTotalById(id);
            return Ok(medalTotalItem);
        }
    }
}