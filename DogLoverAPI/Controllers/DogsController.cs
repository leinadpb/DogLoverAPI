using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DogLoverAPI.Models;
using DogLoverAPI.Services;
using Newtonsoft.Json;
using Newtonsoft;
namespace DogLoverAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DogsController : ControllerBase
    {
        private readonly DogService _dogService;

        public DogsController(DogService dogSrv)
        {
            _dogService = dogSrv;
        }

        [HttpGet("")]
        public async Task<IActionResult> Get()
        {
            var result = await _dogService.GetAll();
            if(result == null)
            {
                return NotFound();
            }
            List<Dog> dogs = result.ToList();

            return Ok(dogs);
        }

        [HttpGet("{id}", Name = "GetById")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _dogService.Get(id);
            if (result == null)
                return NotFound();
            
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Dog dog)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            Dog result = await _dogService.Add(dog);

            if (result == null)
                return StatusCode(StatusCodes.Status500InternalServerError);

            var objUri = Url.Link("GetById", new { id = result.DogId });

            return Created(objUri, result);
        }

    }
}