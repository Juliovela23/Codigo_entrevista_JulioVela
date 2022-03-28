using Conteo_camaras.Context;
using Conteo_camaras.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Conteo_camaras.Controllers
{
  
    [Route("api/[controller]")]
    [ApiController]
    public class Conteo_SeguridadController : ControllerBase
    {
        private  AppDbContext context;

        public Conteo_SeguridadController(AppDbContext context)
        {
            this.context = context;
        }
        // GET: api/<Conteo_SeguridadController>
        
        //public IEnumerable<Conteo_Seguridad> Get()
        //{
        //    return context.Conteo_Seguridad.ToList();
        //}


        [HttpGet]
        public double Get(DateTime f1, DateTime f2)
        {
            return context.Conteo_Seguridad.Where(e => e.Fecha_hora >= f1 && e.Fecha_hora <= f2).Average(e => e.Cantidad_vehiculos);
            

        }

        // POST api/<Conteo_SeguridadController>
        [HttpPost]
        public ActionResult Post([FromBody] Conteo_Seguridad conteo)
        {
            try
            {
                context.Conteo_Seguridad.Add(conteo);
                context.SaveChanges();
                return Ok();
            }
            catch (Exception ex)
            {

                return BadRequest();
            }
        }

        // PUT api/<Conteo_SeguridadController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<Conteo_SeguridadController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
