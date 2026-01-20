using ChillnForms.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChillnForms.Models
{
    public class PageModel : ISyncable
    {
        public Guid Id { get; set; }
        public string BackendName { get; set; }
        public string Name { get; set; }
        public DateTime DateCreated { get; set; }
        public Guid? CreatedBy { get; set; }
        public Guid? LastModifiedBy { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime LastModified { get; set; }

        public Guid TemplateId { get; set; }
        public List<FieldModel> Fields { get; set; }
    }
}
