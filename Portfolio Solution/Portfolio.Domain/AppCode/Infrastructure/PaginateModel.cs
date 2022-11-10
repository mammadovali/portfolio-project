using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Domain.AppCode.Infrastructure
{
    public abstract class PaginateModel
    {
        int pageIndex;
        int pageSize;

        public int PageIndex
        {
            get
            {
                return this.pageIndex < 1 ? 1 : this.pageIndex;
            }
            set
            {
                if (value >= 1)
                {
                    this.pageIndex = value;
                }

            }
        }

        public int PageSize
        {
            get
            {
                return this.pageSize < 3 ? 3 : this.pageSize;
            }
            set
            {
                if (value >= 3)
                {
                    this.pageSize = value;
                }
            }
        }
    }
}
