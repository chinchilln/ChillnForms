using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChillnForms.Models
{
    public class FieldModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public FieldType Type { get; set; }
        public Guid TemplateId { get; set; }
    }
}
