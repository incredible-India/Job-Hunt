using JobHunt_Models.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobHunt_Models.JobSeekers
{
    public class JobSeeker
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Name is required..")]
        public string SeekerName { get; set; }
        public string Expertise { get; set;}
        [Required(ErrorMessage ="Experience is required, if you don't have prior experience enter 0")]
        public string experience { get; set; }
        [Required(ErrorMessage ="Please enter the price range..")]
        public string expectedRange { get; set; }
        [Required(ErrorMessage ="Working hours is required..")]
        public string WorkingHours { get; set; }
        [Required(ErrorMessage ="This field is required...")]
        public bool isAvailable {  get; set; }
        public string profileImage { get; set; }
        public int rating { get; set; }
        public string comments { get; set; }
        [Required (ErrorMessage ="Mobile Number is required, make sure it is the registered mobile number")]
        [MaxLength(12,ErrorMessage ="Invalid mobile number")]
        [MinLength(10,ErrorMessage ="")]
        public string mobileNumber { get; set; }
        [Required(ErrorMessage ="Address is required...")]
        public address address { get; set; }
    }
}
