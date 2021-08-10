using BestUzdNew.Domain.Contracts;
using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BestUzdNew.Domain.Entities
{
    public partial class User : Entity
    {
        public User()
        {
            ServiceDiscount = new HashSet<ServiceDiscount>();
            ServiceGroupDiscount = new HashSet<ServiceGroupDiscount>();
            ServiceSetDiscount = new HashSet<ServiceSetDiscount>();
        }

        public string Login { get; set; }
        public string PasswordHash { get; set; }
        public int UserInformationId { get; set; }
        public int UserRoleId { get; set; }

        public virtual UserInformation UserInformation { get; set; }
        public virtual UserRole UserRole { get; set; }
        public virtual ICollection<ServiceDiscount> ServiceDiscount { get; set; }
        public virtual ICollection<ServiceGroupDiscount> ServiceGroupDiscount { get; set; }
        public virtual ICollection<ServiceSetDiscount> ServiceSetDiscount { get; set; }
    }
}
