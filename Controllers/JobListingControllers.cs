using Microsoft.AspNetCore.Mvc;
using MYJobListing.Models;
using System.Linq;

using TechJobPortal.Models;

namespace TechJobPortal.Controllers
{
    public class JobListingController : Controller
    {
        private static List<JobListing> Jobs = new List<JobListing>
        {
            new JobListing { id = 1, title = "Software Engineer", companyName = "SDAIA", location = "RIYADH", JobType = JobType.FullTime, PostedDate = DateTime.Now },
            new JobListing { id = 2, title = "Data Analyst", companyName = "ARAMCO", location = "KHABAR", JobType = JobType.PartTime, PostedDate = DateTime.Now },
            new JobListing { id = 3, title = "Project Manager", companyName = "BPS", location = "RIYADH", JobType = JobType.Remote, PostedDate = DateTime.Now },
            new JobListing { id = 2, title = "Developer", companyName = "SABIC", location = "JEDDAH", JobType = JobType.PartTime, PostedDate = DateTime.Now },
            new JobListing { id = 3, title = "BUSINESS Manager", companyName = "BPS", location = "RIYADH", JobType = JobType.Contract, PostedDate = DateTime.Now },
        };

        // Index action to display job listings
        public IActionResult Index()
        {
            return View(Jobs);
        }

        // Details action to display job details
        public IActionResult Details(int id)
        {
            var job = Jobs.Find(j => j.id == id);
            if (job == null)
            {
                return NotFound();
            }
            return View(job);
        }

        // public IActionResult Index(JobType? selectedJobType)
        // {
    
        //     var jobTypes = Enum.GetValues(typeof(JobType)).Cast<JobType>().ToList();
        //     ViewBag.JobTypes = jobTypes;

        //     if (selectedJobType.HasValue)
        //     {
        //         Jobs = Jobs.Where(j => j.JobType == selectedJobType.Value).ToList();
        //     }

        //     return View(Jobs);  
        // }


    }
}
