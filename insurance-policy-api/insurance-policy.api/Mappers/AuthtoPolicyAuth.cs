using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using insurance_policy.api.Dtos;
using insurance_policy.Api.Infrastructure.Tables;

namespace insurance_policy.api.Mappers
{
    public static class AuthtoPolicyAuth
    {
        public static PolicyAuth ToPolicyAuth(Auth auth)
        {
            PolicyAuth policyAuth = new PolicyAuth();
            policyAuth.status = auth.Status;
            return policyAuth;
        }
    }
}
