using System;
using System.Collections.Generic;
using System.Text;

namespace insurance_policy.Api.Infrastructure.Tables
{
    public class AssigmentDetail
    {
        public Int64 Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public int Percent { get; set; }
        public string StartDate { get; set; }
        public int Duration { get; set; }
        public decimal Cost { get; set; }
        public string Risk { get; set; }
     
    }
}
