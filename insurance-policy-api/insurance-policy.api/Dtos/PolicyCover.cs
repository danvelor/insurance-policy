using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace insurance_policy.api.Dtos
{
    public class PolicyCover
    {
        public string PolicyType { get; set; }
        public int PolicyPercent{ get; set; }
    }
}
