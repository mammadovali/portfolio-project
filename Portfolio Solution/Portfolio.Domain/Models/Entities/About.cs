using Portfolio.Domain.AppCode.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Domain.Models.Entities
{
    public class About : BaseEntity
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public string Location { get; set; }

        public int Experince { get; set; }

        public string Degree { get; set; }

        public string CareerLevel { get; set; }

        public string Phone { get; set; }

        public string Fax { get; set; }

        public string Email { get; set; }

        public string Website { get; set; }

        public string ShortDescription { get; set; }

        public string LongDescription { get; set; }

        public string FacebookLink { get; set; }

        public string GithubLink { get; set; }

        public string LinkedinLink { get; set; }

        public string InstagramLink { get; set; }

        public string YoutubeLink { get; set; }
    }
}
