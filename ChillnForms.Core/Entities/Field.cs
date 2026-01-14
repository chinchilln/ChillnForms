using ChillnForms.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChillnForms.Core.Entities
{
    public class Field : ISyncable
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public Guid TemplateId { get; set; }
        public bool IsDeleted { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime LastModified { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
