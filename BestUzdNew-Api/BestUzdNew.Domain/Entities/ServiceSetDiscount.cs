using BestUzdNew.Domain.Contracts;
using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BestUzdNew.Domain.Entities
{
    public partial class ServiceSetDiscount : Entity
    {
        public ServiceSetDiscount()
        {
            ServiceSetDiscountsToServices = new HashSet<ServiceSetDiscountToService>();
        }
        public int DiscountTypeId { get; set; }
        public double Value { get; set; }
        public int? UserId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public virtual DiscountType DiscountType { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<ServiceSetDiscountToService> ServiceSetDiscountsToServices { get; set; }
    }
}
