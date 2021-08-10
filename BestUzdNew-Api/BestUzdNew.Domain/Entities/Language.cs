using BestUzdNew.Domain.Contracts;
using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BestUzdNew.Domain.Entities
{
    public partial class Language : Entity
    {
        public Language()
        {
            Translation = new HashSet<Translation>();
        }

        public string Name { get; set; }
        public string ShortName { get; set; }
        public string ImageSrc { get; set; }

        public virtual ICollection<Translation> Translation { get; set; }
    }
}
