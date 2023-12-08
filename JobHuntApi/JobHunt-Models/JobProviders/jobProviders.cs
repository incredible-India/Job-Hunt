using JobHunt_Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobHunt_Models.JobProviders
{
    public  class jobProviders
    {
        public string ProviderName { get; set; }
        public string JobName { get; set; }
        public string JobDescription { get; set; }
        public string experience { get; set; }
        public string otherExpertise { get; set; }
        public long Price { get; set; }
        public address address { get; set; }
        public string[] media { get; set; }
        public int ratings { get; set; }
        public string comments { get; set; }
        public string mobileNumber { get; set; }
    }
}
