using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using insurance_policy.api.Dtos;
using insurance_policy.api.Mappers;
using insurance_policy.Api.ServiceCore.interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.Swagger.Annotations;

namespace insurance_policy.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        public IPolicyService PolicyService { get; set; }

        public LoginController (IPolicyService policyService)
        {
            this.PolicyService = policyService;
        }

        /// <summary>
        /// Metodo para validación de ingreso.
        /// </summary>
        /// <param name="user">Usuario</param>
        /// <param name="pass">Contraseña</param>
        /// <returns>Retorna una respuesta acceso o negación</returns>  
        [HttpGet("{user}/{password}")]
        [SwaggerResponse(200, Type = typeof(PolicyAuth))]
        public ActionResult<PolicyAuth> Get(string user, string password, string origin)
        {

            PolicyAuth policyAuth;
            policyAuth = AuthtoPolicyAuth.ToPolicyAuth(PolicyService.GetAuth(user, password));

            return policyAuth;
        }
           
        
    }
}
