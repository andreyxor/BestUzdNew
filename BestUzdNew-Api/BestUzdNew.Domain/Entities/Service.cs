using BestUzdNew.Domain.Contracts;
using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BestUzdNew.Domain.Entities
{
    public partial class Service : Entity
    {
        public Service()
        {
            Order = new HashSet<Order>();
            ServiceDiscount = new HashSet<ServiceDiscount>();
            ServiceGroupsToServices = new HashSet<ServiceGroupToService>();
            ServiceSetDiscountsToServices = new HashSet<ServiceSetDiscountToService>();
        }

        public string NameAlias { get; set; }
        public string DescriptionAlias { get; set; }
        public double Price { get; set; }

        public virtual ICollection<ServiceGroupToService> ServiceGroupsToServices { get; set; }
        public virtual ICollection<Order> Order { get; set; }
        public virtual ICollection<ServiceDiscount> ServiceDiscount { get; set; }
        public virtual ICollection<ServiceSetDiscountToService> ServiceSetDiscountsToServices { get; set; }
    }
}
