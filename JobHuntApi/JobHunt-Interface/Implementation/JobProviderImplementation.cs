using JobHunt_Interface.Interface;
using JobHunt_Models.Database;
using JobHunt_Models.JobProviders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobHunt_Interface.Implementation
{
    public class JobProviderImplementation : IJobProvider
    {
        private readonly jobHuntContext _jobHuntContext;

        public JobProviderImplementation(jobHuntContext jobHuntContext)
        {
            _jobHuntContext = jobHuntContext;
        }
        public Task AddJobProvider(jobProviders jobProviders)
        {
            //check whether the user exist or not
            var isUser = _jobHuntContext.Users.Where(m => m.PhoneNo == jobProviders.mobileNumber);
            if(isUser.Any())
            {
                _jobHuntContext.JobProviders.Add(jobProviders);
                _jobHuntContext.SaveChanges();
                return Task.CompletedTask;
            }
            else
            {
                throw new Exception("User dosen't exist.. make sure you have entered the registered mobile number");
            }
        }

        public List<jobProviders> GetJobProvider(string no)
        {
            var a = _jobHuntContext.JobProviders.Where(x => x.mobileNumber == no);
            if (a.Any())
            {
                return a.ToList();
            }
            else
            {
                return null;
            }
        }
    }
}
