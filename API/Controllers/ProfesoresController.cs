using API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfesoresController : ControllerBase
    {
        private readonly AplicationDBContext _context;

        public ProfesoresController(AplicationDBContext context)
        {
            _context = context;
        }
        // GET: api/<ProfesoresController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var lisProfesor = await _context.Profesores.ToListAsync();

                return Ok(lisProfesor);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
                
            }
        }

        // GET api/<ProfesoresController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Int64 id)
        {
            try
            {
                var lisProfesor = await _context.Profesores.FindAsync(id);
                if (id != lisProfesor.id_profesor)
                {
                    return NotFound();
                }

                return Ok(lisProfesor);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        // POST api/<ProfesoresController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Profesores profesores)
        {
            try
            {
                _context.Add(profesores);
                await _context.SaveChangesAsync();
                return Ok(profesores);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        // PUT api/<ProfesoresController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ProfesoresController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
