using JobHunt_Interface.Interface;
using JobHunt_Models.JobProviders;
using JobHunt_Models.JobSeekers;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace JonHunt_API.Controllers
{
    [Route("jobhunt/jobprovider")]
    [ApiController]
    public class JobProviderController : ControllerBase
    {
        private readonly IJobProvider _jobProvider;
        public JobProviderController(IJobProvider jobProvider)
        {
            _jobProvider = jobProvider;
        }

        #region POST
        [HttpPost("newJobProvider")]
        public async Task<IActionResult> NewJobProvider([Required][FromBody] jobProviders jp)
        {
           var newjp = _jobProvider.AddJobProvider(jp);
            return Ok(newjp);
        }

        #endregion
    }
}