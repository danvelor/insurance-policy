using insurance_policy.Api.Infrastructure.Tables;
using System;
using System.Collections.Generic;
using System.Text;

namespace insurance_policy.Api.Infrastructure.interfaces
{
    public  interface IPolicyRepository : IEntityBaseRepository<Assigment>
    {
        List<Assigment> GetAssigment();
        List<AssigmentDetail> GetAssigmentDetail(int id);
        Auth GetAuth(string User, string Password);
    }
}
