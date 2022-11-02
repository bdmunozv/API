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
        public async Task<IActionResult> Put(Int64 id, [FromBody] Profesores profesores)
        {
            try
            {
                if(id != profesores.id_profesor){

                    return NotFound();
                }

                _context.Update(profesores);
                await _context.SaveChangesAsync();
                return Ok(new { message = "Registro actualizado" });
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        // DELETE api/<ProfesoresController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Int64 id)
        {
            try
            {
                var lisProfesor = await _context.Profesores.FindAsync(id);
                if (id != lisProfesor.id_profesor)
                {
                    return NotFound();
                }

                _context.Profesores.Remove(lisProfesor);
                await _context.SaveChangesAsync();
                return Ok(new { message = "Registro eliminado" });
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
    }
}
