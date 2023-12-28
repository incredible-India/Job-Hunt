using JobHunt_Interface.Interface;
using JobHunt_Models.Database;
using JobHunt_Models.JobSeekers;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobHunt_Interface.Implementation
{
    public class JobSeekerImplementation : IJobSeeker

    {
        private readonly jobHuntContext _jobHuntContext;
        public JobSeekerImplementation(jobHuntContext job)
        {
            _jobHuntContext = job;
        }
        public Task AddJobSeeker(JobSeeker jobseeker)
        {
            //first step check the mobile number and verify weather user exist or not
            var isUser = _jobHuntContext.Users.Where(m => m.PhoneNo == jobseeker.mobileNumber); 
            if(isUser.Any())
            {
               // jobseeker.SeekerName =isUser.ToList()[0].FirstName +" "+ isUser.ToList()[0].LastName;
                _jobHuntContext.JobSeekers.Add(jobseeker);
                _jobHuntContext.SaveChanges();
                return Task.CompletedTask;
                
            }
            else
            {
                throw new Exception("User dosen't exist.. make sure you have entered the registered mobile number");
            }


          
        }

        public List<JobSeeker> getSeekerByNo(string no)
        {
            var seeklist = _jobHuntContext.JobSeekers.Where(x => x.mobileNumber == no);
            if (seeklist.Any())
            {
                return seeklist.ToList();
            }
            else
            {
                return null;
            }
        }
    }
}
