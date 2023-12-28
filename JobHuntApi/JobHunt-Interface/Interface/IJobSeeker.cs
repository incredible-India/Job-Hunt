using JobHunt_Models.JobSeekers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobHunt_Interface.Interface
{
    public interface IJobSeeker
    {
        public Task AddJobSeeker(JobSeeker jobseeker);
        public List<JobSeeker> getSeekerByNo(string no);
    }
}
