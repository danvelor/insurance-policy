using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace insurance_policy.api.Dtos
{
    public class PolicyClient
    {
        public string ClientName { get; set; }
        public Int64 ClientId { get; set; }
        public string ClientPhone { get; set; }
        public int PolicyNumber { get; set; }
    }
}
