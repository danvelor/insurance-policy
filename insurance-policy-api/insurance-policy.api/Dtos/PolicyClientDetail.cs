using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace insurance_policy.api.Dtos
{
    public class PolicyClientDetail
    {
        public Int64 PolicyId { get; set; }
        public string PolicyName { get; set; }
        public string PolicyDescription { get; set; }
        public string PolicyType { get; set; }
        public int PolicyPercent { get; set; }
        public string PolicyStartDate { get; set; }
        public int PolicyDuration { get; set; }
        public decimal PolicyCost { get; set; }
        public string PolicyRisk { get; set; }
    }
}
