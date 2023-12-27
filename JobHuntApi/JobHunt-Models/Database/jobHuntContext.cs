using JobHunt_Models.JobProviders;
using JobHunt_Models.JobSeekers;
using JobHunt_Models.User;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobHunt_Models.Database
{
    public  class jobHuntContext:DbContext
    {
        public jobHuntContext(DbContextOptions<jobHuntContext> options):base(options)
        {
            
        }

        public DbSet<NewUser> Users { get; set; }
        public DbSet<JobSeeker> JobSeekers { get; set; }
        public DbSet<jobProviders> JobProviders { get; set; }
    }
}
