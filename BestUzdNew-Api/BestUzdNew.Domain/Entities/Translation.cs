using BestUzdNew.Domain.Contracts;
using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BestUzdNew.Domain.Entities
{
    public partial class Translation : Entity
    {
        public string Alias { get; set; }
        public string Translation1 { get; set; }
        public int LanguageId { get; set; }

        public virtual Language Language { get; set; }
    }
}
