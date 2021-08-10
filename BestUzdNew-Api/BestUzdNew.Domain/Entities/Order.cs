using BestUzdNew.Domain.Contracts;
using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BestUzdNew.Domain.Entities
{
    public partial class Order : Entity
    {
        public string Name { get; set; }
        public string FamilyName { get; set; }
        public int ServiceId { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public virtual Service Service { get; set; }
    }
}
