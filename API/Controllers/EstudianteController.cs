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
    public class EstudianteController : ControllerBase
    {
        private readonly AplicationDBContext _context;

        public EstudianteController(AplicationDBContext context)
        {
            _context = context;
        }
        // GET: api/<EstudiantesController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var lisEstudiante = await _context.Estudiante.ToListAsync();

                return Ok(lisEstudiante);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);

            }
        }

        // GET api/<EstudiantesController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Int64 id)
        {
            try
            {
                var lisEstudiante = await _context.Estudiante.FindAsync(id);
                if (id != lisEstudiante.id_estudiante)
                {
                    return NotFound();
                }

                return Ok(lisEstudiante);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        // POST api/<EstudiantesController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Estudiante estudiante)
        {
            try
            {
                _context.Add(estudiante);
                await _context.SaveChangesAsync();
                return Ok(estudiante);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        // PUT api/<EstudiantesController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(Int64 id, [FromBody] Estudiante estudiante)
        {
            try
            {
                if (id != estudiante.id_estudiante)
                {

                    return NotFound();
                }

                _context.Update(estudiante);
                await _context.SaveChangesAsync();
                return Ok(new { message = "Registro actualizado" });
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        // DELETE api/<EstudiantesController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Int64 id)
        {
            try
            {
                var lisEstudiante = await _context.Estudiante.FindAsync(id);
                if (id != lisEstudiante.id_estudiante)
                {
                    return NotFound();
                }

                _context.Estudiante.Remove(lisEstudiante);
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
