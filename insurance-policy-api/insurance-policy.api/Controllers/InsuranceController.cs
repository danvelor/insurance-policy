using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using insurance_policy.api.Dtos;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.Swagger.Annotations;

namespace insurance_policy.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InsuranceController : ControllerBase
    {
        /// <summary>
        /// Metodo para obtener el resumen de las polizas de los clientes.
        /// </summary>
        /// <returns>Retorna lista con la informacion de las polizas agrupado en numero por cliente</returns>        
        [HttpGet()]
        [SwaggerResponse(200, Type = typeof(List<PolicyClient>))]
        public ActionResult<List<PolicyClient>> Get()
        {
            try
            {
                List<PolicyClient> lspolicyClients = new List<PolicyClient>();




                return lspolicyClients;

            }
            catch (Exception)
            {

                throw;
            }
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
