using System;
using System.Collections.Generic;

namespace Core.models
{
    public partial class UserProject
    {
        public int? Iduser { get; set; }
        public int? Idproject { get; set; }

        public virtual Project IdprojectNavigation { get; set; }
        public virtual User IduserNavigation { get; set; }
    }
}
