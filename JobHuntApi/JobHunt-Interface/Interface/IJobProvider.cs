using JobHunt_Models.JobProviders;
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
    }
}
