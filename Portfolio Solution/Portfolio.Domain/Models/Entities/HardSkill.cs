using Portfolio.Domain.AppCode.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Domain.Models.Entities
{
    public class HardSkill : BaseEntity
    {
        public string Name { get; set; }

        public int Level { get; set; }

        public string Description { get; set; }

        public int CategoryId { get; set; }

        public virtual HardSkillCategory Category { get; set; }

    }
}
