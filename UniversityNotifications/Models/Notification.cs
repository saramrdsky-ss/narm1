using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UniversityNotifications.Models
{
    public class Notification
    {
        public string TextShow { get; set; }
        public int? UniversityScreenShow { get; set; }
        public int? CollegeScreenShow { get; set; }
        public int? LocationScreenShow { get; set; }
        public int FrequenceShow { get; set; }
        public DateTime ScheduleShow { get; set; }
        public short UrgentShow { get; set; }
        public int TypeId { get; set; }



    }
}