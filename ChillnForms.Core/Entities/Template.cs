using System;
using System.Collections.Generic;
using System.Text;

namespace ChillnForms.Core.Entities
{
    public class Template
    {
        Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public List<Field> Fields { get; set; } = new List<Field>();

        public Template() { }
    }
}
