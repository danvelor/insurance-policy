using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using insurance_policy.api.Dtos;
using insurance_policy.api.Mappers;
using insurance_policy.Api.Infrastructure.interfaces;
using insurance_policy.Api.ServiceCore.interfaces;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.Swagger.Annotations;

namespace insurance_policy.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InsuranceController : ControllerBase
    {
        public IPolicyService PolicyService { get; set; }
        public IPolicyRepository PolicyRepository { get; set; }

        public InsuranceController(IPolicyService policyService, IPolicyRepository policyRepository)
        {
            this.PolicyService = policyService;
            PolicyRepository = policyRepository;
        }

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

                lspolicyClients = AssigmenttoPolicyClient.ToPolicyClient(PolicyService.GetAssigment());


                return lspolicyClients;

            }
            catch (Exception ex)
            {

                throw;
            }
        }

        /// <summary>
        /// Metodo para obtener el detalle de las polizas por cliente.
        /// </summary>
        /// <returns>Retorna lista con la información de las polizas de un cliente</returns>        
        [HttpGet("{id}")]
        [SwaggerResponse(200, Type = typeof(List<PolicyClientDetail>))]
        public ActionResult<List<PolicyClientDetail>> Get(int id)
        {
            List<PolicyClientDetail> lspolicyClientDetail = new List<PolicyClientDetail>();

            lspolicyClientDetail = AssigmentDetailtoPolicyClientDetail.ToPolicyClientDetail(PolicyService.GetAssigmentDetail(id));


            return lspolicyClientDetail;
        }

    }
}
