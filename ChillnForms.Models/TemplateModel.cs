using ChillnForms.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChillnForms.Models
{
    public class TemplateModel : ISyncable
    {
        Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string BackendName { get; set; } = string.Empty;
        public bool IsDeleted { get; set; } = false;
        public DateTime LastModified { get; set; }
        public DateTime DateCreated { get; set; }
        public Guid? CreatedBy { get; set; }
        public Guid? LastModifiedBy { get; set; }

        public List<PageModel> Pages { get; set; }
    }
}
