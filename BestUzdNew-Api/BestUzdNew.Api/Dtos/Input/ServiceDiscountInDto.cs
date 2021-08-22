using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BestUzdNew.Api.Dtos.Input
{
    public class ServiceDiscountInDto
    {
        public int? ServiceId { get; set; }
        public int DiscountTypeId { get; set; }
        public double Value { get; set; }
    }
}
