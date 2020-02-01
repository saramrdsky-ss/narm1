using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UniversityNotifications.Models
{
    public class ManagerLoginRequest
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }

    public class ManagerLoginResponse
    {
        public int Id { get; set; }
        public int TypeId { get; set; }
    }
}