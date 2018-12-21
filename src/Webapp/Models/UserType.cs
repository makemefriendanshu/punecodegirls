using System;
using System.Collections.Generic;

namespace Webapp.Models
{
    public partial class UserType
    {
        public UserType()
        {
            User = new HashSet<User>();
        }

        public int UserTypeId { get; set; }
        public string UserTypeName { get; set; }

        public ICollection<User> User { get; set; }
    }
}
