using Microsoft.AspNetCore.Mvc;
using REST_SQL_New.Data;
using REST_SQL_New.Data.Interfaces;
using REST_SQL_New.Models;
using System.Collections.Generic;

namespace REST_SQL_New.Controllers
{
    [Route("api/medals")]
    [ApiController]
    public class MedalsController : ControllerBase
    {
        private readonly IMedalRepo _repository;

        public MedalsController(IMedalRepo repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Medal>> GetAllMedals()
        {
            var medalItems = _repository.GetAllMedals();

            return Ok(medalItems);
        }
        //GET: api/medals/5
        [HttpGet("{id}")]
        public ActionResult<IEnumerable<Medal>> GetMedalById(int id)
        {
            var medalItem = _repository.GetMedalById(id);
            return Ok(medalItem);
        }
    }
}