using JobHunt_Models.JobProviders;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobHunt_Interface.Interface
{
    public interface IJobProvider
    {
        public Task AddJobProvider(jobProviders jobProviders);
        public List<jobProviders> GetJobProvider(string no);
    }
}
