using System;
using System.Collections.Generic;
using System.Text;

namespace ChillnForms.Models
{
    public class PagedResultModel<T>
    {
        public List<T> Items { get; set; }
        public int TotalCount { get; set; }
        public int PageSize { get; set; }
        public int CurrentPage { get; set; }

    }
}
