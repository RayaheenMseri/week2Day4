using System.ComponentModel.DataAnnotations;

namespace MYJobListing.Models
{

   public enum JobType
    {
        FullTime,
        PartTime,
        Remote,
        Contract
    }

    public class JobListing
    {
        public int id { get; set; }

        [Required]
        public string title { get; set; }

        [Required]
        public string companyName { get; set; }

        public string location { get; set; }
        [Required]
        public JobType JobType { get; set; }

        public DateTime PostedDate { get; set; }
    }
}