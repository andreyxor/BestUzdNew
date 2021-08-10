using BestUzdNew.Domain.Contracts;
using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BestUzdNew.Domain.Entities
{
    public partial class DiscountType : Entity
    {
        public DiscountType()
        {
            ServiceDiscount = new HashSet<ServiceDiscount>();
            ServiceGroupDiscount = new HashSet<ServiceGroupDiscount>();
            ServiceSetDiscount = new HashSet<ServiceSetDiscount>();
        }

        public string NameAlias { get; set; }
        public string DescriptionAlias { get; set; }

        public virtual ICollection<ServiceDiscount> ServiceDiscount { get; set; }
        public virtual ICollection<ServiceGroupDiscount> ServiceGroupDiscount { get; set; }
        public virtual ICollection<ServiceSetDiscount> ServiceSetDiscount { get; set; }
    }
}
