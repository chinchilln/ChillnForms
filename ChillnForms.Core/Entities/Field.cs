using ChillnForms.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChillnForms.Core.Entities
{
    public class Field : ISyncable
    {
        public Guid Id { get; set; }
        public string BackendName { get; set; }
        public string Name { get; set; } 
        public string Type { get; set; } 
        public bool IsDeleted { get; set; }
        public DateTime LastModified { get; set; }
        public int ColumnIndex { get; set; }
        public int ColumnSpan { get; set; }
        public int RowIndex { get; set; }
        public int RowSpan { get; set; }
        public DateTime DateCreated { get; set; }
        public Guid? CreatedBy { get; set; }
        public Guid? LastModifiedBy { get; set; }

        public Guid PageId { get; set; }
        public virtual Page Page { get; set; }
        
    }
}
