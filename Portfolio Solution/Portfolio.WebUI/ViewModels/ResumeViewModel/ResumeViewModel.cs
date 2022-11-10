using Portfolio.Domain.Models.Entities;
using System.Collections.Generic;

namespace Portfolio.WebUI.ViewModels.ResumeViewModel
{
    public class ResumeViewModel
    {
        public ResumeBio ResumeBio { get; set; }

        public ICollection<Experience> Experiences { get; set; }

        public ICollection<AcademicBackground> AcademicBackgrounds { get; set; }
    }
}
