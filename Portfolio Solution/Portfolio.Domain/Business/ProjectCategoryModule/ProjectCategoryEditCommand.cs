﻿using MediatR;
using Microsoft.EntityFrameworkCore;
using Portfolio.Domain.Models.DataContext;
using Portfolio.Domain.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BigOn.Domain.Business.ProjectCategoryModule
{
    public class ProjectCategoryEditCommand : IRequest<ProjectCategory>
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public class ProjectCategoryEditCommandHandler : IRequestHandler<ProjectCategoryEditCommand, ProjectCategory>
        {
            private readonly PortfolioDbContext db;

            public ProjectCategoryEditCommandHandler(PortfolioDbContext db)
            {
                this.db = db;
            }

            public async Task<ProjectCategory> Handle(ProjectCategoryEditCommand request, CancellationToken cancellationToken)
            {
                var data = await db.ProjectCategories
                    .FirstOrDefaultAsync(m => m.Id == request.Id && m.DeletedDate == null, cancellationToken);

                if (data == null)
                {
                    return null;
                }

                data.Name = request.Name;
                await db.SaveChangesAsync(cancellationToken);

                return data;
            }


        }
    }

}
