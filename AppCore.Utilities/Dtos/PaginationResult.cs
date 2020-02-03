using System;
using System.Collections.Generic;
using System.Text;

namespace AppCore.Utilities.Dtos
{
    public class PaginationResult<T>:PagedResultBase where T : class
    {
        public IList<T> Results { get; set; }

        public PaginationResult()
        {
            Results = new List<T>();
        }
    }
}
