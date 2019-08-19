using insurance_policy.api.Dtos;
using insurance_policy.Api.Infrastructure.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace insurance_policy.api.Mappers
{
    public static class AssigmentDetailtoPolicyClientDetail
    {
        public static List<PolicyClientDetail> ToPolicyClientDetail(List<AssigmentDetail> lsassigmentDetails)
        {
            List<PolicyClientDetail> lspolicyClientDetail = new List<PolicyClientDetail>();
            PolicyClientDetail policyClientDetail = new PolicyClientDetail();
            foreach (var item in lsassigmentDetails)
            {
                policyClientDetail = new PolicyClientDetail();

                policyClientDetail.PolicyId = item.Id;
                policyClientDetail.PolicyName = item.Name;
                policyClientDetail.PolicyDescription = item.Description;
                policyClientDetail.PolicyType = item.Type;
                policyClientDetail.PolicyPercent = item.Percent;
                policyClientDetail.PolicyStartDate = item.StartDate;
                policyClientDetail.PolicyDuration = item.Duration;
                policyClientDetail.PolicyCost = item.Cost;
                policyClientDetail.PolicyRisk = item.Risk;


                lspolicyClientDetail.Add(policyClientDetail);
            }

            return lspolicyClientDetail;
        }

    }
}
