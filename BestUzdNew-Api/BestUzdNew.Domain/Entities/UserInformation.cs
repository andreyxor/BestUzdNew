using BestUzdNew.Domain.Contracts;
using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BestUzdNew.Domain.Entities
{
    public partial class UserInformation : Entity
    {
        public UserInformation()
        {
            User = new HashSet<User>();
        }

        public string Name { get; set; }
        public string FamilyName { get; set; }
        public string Email { get; set; }

        public virtual ICollection<User> User { get; set; }
    }
}
