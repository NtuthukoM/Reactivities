using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reactivities.Application.Core
{
    public class PagingParams
    {
        private const int maximumPageSize = 50;
        public int PageNumber { get; set; } = 1;

        private int pageSize = 10;
        public int PageSize 
        { 
            get => pageSize;
            set => pageSize = (value > maximumPageSize) ? maximumPageSize : value; 
        }
    }
}
