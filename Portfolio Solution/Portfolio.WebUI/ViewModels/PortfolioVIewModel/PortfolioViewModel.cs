using Portfolio.Domain.Models.Entities;
using System.Collections.Generic;

namespace Portfolio.WebUI.ViewModels.PortfolioVIewModel
{
    public class PortfolioViewModel
    {
        public ICollection<ProjectCategory> ProjectCategories { get; set; }

        public ICollection<Project> Projects { get; set; }
    }
}
