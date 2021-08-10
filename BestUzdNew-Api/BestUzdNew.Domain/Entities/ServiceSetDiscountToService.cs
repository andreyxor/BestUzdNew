using BestUzdNew.Domain.Contracts;
using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BestUzdNew.Domain.Entities
{
    public partial class ServiceSetDiscountToService : Entity
    {
        public int ServiceSetDiscountId { get; set; }
        public int ServiceId { get; set; }

        public virtual Service Service { get; set; }
        public virtual ServiceSetDiscount ServiceSetDiscount { get; set; }
    }
}
