using System;
using System.Collections.Generic;

namespace Core.models
{
    public partial class User
    {
        public User()
        {
            Cabhoras = new HashSet<Cabhoras>();
            UserProject = new HashSet<UserProject>();
        }

        public int Id { get; set; }
        public string Nick { get; set; }
        public string Pwd { get; set; }
        public string Mail { get; set; }
        public DateTime? LastLogin { get; set; }
        public DateTime? FirstLogin { get; set; }

        public virtual ICollection<Cabhoras> Cabhoras { get; set; }
        public virtual ICollection<UserProject> UserProject { get; set; }
    }
}
