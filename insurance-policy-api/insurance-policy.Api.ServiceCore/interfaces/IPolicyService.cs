using insurance_policy.Api.Infrastructure.Tables;
using System;
using System.Collections.Generic;
using System.Text;

namespace insurance_policy.Api.ServiceCore.interfaces
{
    public interface IPolicyService
    {
        List<Assigment> GetAssigment();

        List<AssigmentDetail> GetAssigmentDetail(int id);
    }
}
