using System;
using System.Collections.Generic;
using System.Text;

namespace ChillnForms.Models
{
    public class TemplateModel
    {
        Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public TemplateModel() { }
    }
}
