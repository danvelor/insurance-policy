using insurance_policy.api.Dtos;
using insurance_policy.Api.Infrastructure.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace insurance_policy.api.Mappers
{
    public static class AssigmenttoPolicyClient
    {
        public static List<PolicyClient> ToPolicyClient(List<Assigment> lsassigment)
        {
            List<PolicyClient> lspolicyClients = new List<PolicyClient>();
            PolicyClient policyClients = new PolicyClient();
            foreach (var item in lsassigment)
            {
                policyClients = new PolicyClient();

                policyClients.ClientId = item.Id;
                policyClients.ClientName = item.Name;
                policyClients.ClientPhone = item.Phone;
                policyClients.PolicyNumber = item.Number;

                lspolicyClients.Add(policyClients);
            }

            return lspolicyClients;
        }
    }
}
