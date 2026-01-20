using System;
using System.Collections.Generic;
using System.Text;

namespace ChillnForms.Models
{
    public class PageQueryModel
    {
        public string SortBy { get; set; }
        public bool IsDescending { get; set; }
        public string SearchQuery { get; set; }
        public int PageSize { get; set; }
        public int CurrentPage { get; set; }
    }
}
