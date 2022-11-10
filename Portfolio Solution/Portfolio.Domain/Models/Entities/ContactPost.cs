using Portfolio.Domain.AppCode.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Domain.Models.Entities
{
    public class ContactPost : BaseEntity
    {
        [Required(ErrorMessage = "{0} Boş buraxıla bilməz")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Boş buraxıla bilməz")]
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "Boş buraxıla bilməz")]

        public string Subject { get; set; }
        [Required(ErrorMessage = "Boş buraxıla bilməz")]

        public string Content { get; set; }

        public string EmailSubject { get; set; }
        public string Answer { get; set; }
        public DateTime? AnswerDate { get; set; }


    }
}
