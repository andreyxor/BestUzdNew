using BestUzdNew.Domain.Contracts;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BestUzdNew.Domain.Entities
{
    public partial class UserRole : Entity
    {
        public UserRole()
        {
            User = new HashSet<User>();
        }

        public string NameAlias { get; set; }

        public virtual ICollection<User> User { get; set; }
    }
}
