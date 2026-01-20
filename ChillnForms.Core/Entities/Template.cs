using ChillnForms.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChillnForms.Core.Entities
{
    public class Template : ISyncable
    {
        public Guid Id { get; set; }
        public string BackendName { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public bool IsDeleted { get; set; } = false;
        public DateTime LastModified { get; set; }
        public DateTime DateCreated { get; set; }
        public Guid? CreatedBy { get; set; }
        public Guid? LastModifiedBy { get; set; }

        public virtual List<Page> Pages { get; set; }
    }
}
