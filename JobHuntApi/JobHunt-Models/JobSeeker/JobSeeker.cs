using JobHunt_Models.Common;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobHunt_Models.JobSeeker
{
    public class JobSeeker
    {
        public string SeekerName { get; set; }
        public string Expertise { get; set;}
        public string experience { get; set; }
        public string expectedRange { get; set; }
        public string WorkingHours { get; set; }
        public bool isAvailable {  get; set; }
        public string profileImage { get; set; }
        public int rating { get; set; }
        public string comments { get; set; }
        public string mobileNumber { get; set; }
        public address address { get; set; }
    }
}
