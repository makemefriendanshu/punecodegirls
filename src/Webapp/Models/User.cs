using System;
using System.Collections.Generic;

namespace Webapp.Models
{
    public partial class User
    {
        public int UserId { get; set; }
        public int UserType { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public decimal Phone { get; set; }
        public string Place { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }

        public UserType UserTypeNavigation { get; set; }
    }
}
