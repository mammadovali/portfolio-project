using Portfolio.Domain.AppCode.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Domain.Models.Entities
{
    public class AcademicBackground : BaseEntity
    {
        public string Duration { get; set; }

        public string Qualification { get; set; }

        public string Degree { get; set; }

        public string InstituteOrUniversityName { get; set; }

        public string Details { get; set; }
    }
}
