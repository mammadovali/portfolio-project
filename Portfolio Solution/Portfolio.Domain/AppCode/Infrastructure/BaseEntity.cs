﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Domain.AppCode.Infrastructure
{

    public class BaseEntity
    {
        public int Id { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.UtcNow.AddHours(4);

        public DateTime? DeletedDate { get; set; }

    }
}
