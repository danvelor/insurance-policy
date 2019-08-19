using insurance_policy.Api.Infrastructure.interfaces;
using insurance_policy.Api.Infrastructure.Tables;
using insurance_policy.Api.ServiceCore.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace insurance_policy.Api.ServiceCore.Services
{    
    public class PolicyService: IPolicyService
    {
        private readonly IPolicyRepository PolicyRepository;
        public PolicyService(IPolicyRepository policyRepository)
        {
            this.PolicyRepository = policyRepository;
        }

        public List<Assigment> GetAssigment()
        {
            return PolicyRepository.GetAssigment();
        }

        public List<AssigmentDetail> GetAssigmentDetail(int id)
        {
            return PolicyRepository.GetAssigmentDetail(id);
        }

        public Auth GetAuth(string User, string Password)
        {
            return PolicyRepository.GetAuth(User, Password);
        }

    }

}
