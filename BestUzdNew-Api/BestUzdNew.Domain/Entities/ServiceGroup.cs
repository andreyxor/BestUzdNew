using BestUzdNew.Domain.Contracts;
using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BestUzdNew.Domain.Entities
{
    public partial class ServiceGroup : Entity
    {
        public ServiceGroup()
        {
            ServiceGroupDiscount = new HashSet<ServiceGroupDiscount>();
            ServiceGroupsToServices = new HashSet<ServiceGroupToService>();

        }

        public string NameAlias { get; set; }
        public string DescriptionAlias { get; set; }

        public virtual ICollection<ServiceGroupDiscount> ServiceGroupDiscount { get; set; }
        public virtual ICollection<ServiceGroupToService> ServiceGroupsToServices { get; set; }

    }
}
