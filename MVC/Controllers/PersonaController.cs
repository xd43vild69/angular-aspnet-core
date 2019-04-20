using Microsoft.AspNetCore.Mvc;
using MVC.Models;
using System;
using System.Collections.Generic;
namespace MVC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonaController : ControllerBase
    {
        // GET: api/Persona
        [HttpGet]
        public IEnumerable<Persona> Get()
        {

            return new List<Persona>()
            {
                new Persona(){ id=1, nombre = "D13", fechaNacimiento=new DateTime(1980,12,12)},
                new Persona(){ id=1, nombre = "D13", fechaNacimiento=new DateTime(1980,12,12)}
            };
        }

        // GET: api/Persona/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Persona
        [HttpPost]
        public void Post(Persona persona)
         {
            String personas = string.Empty;
        }

        // PUT: api/Persona/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
