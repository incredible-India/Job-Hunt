using JobHunt_Interface.Interface;
using JobHunt_Models.JobSeekers;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace JonHunt_API.Controllers
{
    [Route("jobhunt/jobseeker")]
    [ApiController]

   
    public class JobSeekerController : ControllerBase
    {
        private readonly IJobSeeker _jobSeeker;
        public JobSeekerController(IJobSeeker jobSeeker)
        {
            _jobSeeker = jobSeeker;
        }
        #region POST
        ///<summary>
        ///New Job seeker requirements
        /// </summary>
        [HttpPost("newJobSeeker")]
        public async Task<IActionResult> NewJobSeeker([Required][FromBody] JobSeeker js)
        {
            var a =  _jobSeeker.AddJobSeeker(js);
            return Ok(a);
        }

        #endregion

        #region GET
        [HttpGet("getSeekerByMobileNo/{no}")]
        public IActionResult getSeekerByNo([FromRoute]string no)
        {
            var seek = _jobSeeker.getSeekerByNo(no);
            if(seek == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(seek);
            }

        }

        #endregion
    }
}
