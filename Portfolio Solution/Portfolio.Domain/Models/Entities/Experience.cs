using Microsoft.AspNetCore.Http;
using Portfolio.Domain.AppCode.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Domain.Models.Entities
{
    public class Experience : BaseEntity 
    {
        public string Duration { get; set; }

        public string JobTitle { get; set; }

        public string CompanyName { get; set; }

        public string Location { get; set; }

        public string Details { get; set; }
    }
}
