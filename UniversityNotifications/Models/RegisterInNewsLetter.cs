using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UniversityNotifications.Models
{
    public class RegisterInNewsLetter
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public int UserType { get; set; }
        public short Intrests { get; set; }
        public short NotificationType { get; set; }
    }
}