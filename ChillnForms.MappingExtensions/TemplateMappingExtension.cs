using ChillnForms.Core.Entities;
using ChillnForms.Models;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace ChillnForms.MappingExtensions
{
    public static class TemplateMappingExtension
    {
        public static TemplateModel ToModel(this Template entity)
        {
            var model = new TemplateModel
            {
                BackendName = entity.BackendName,
                Name = entity.Name,
                Description = entity.Description,
                IsDeleted = entity.IsDeleted,
                LastModified = entity.LastModified,
                DateCreated = entity.DateCreated,
                CreatedBy = entity.CreatedBy,
                LastModifiedBy = entity.LastModifiedBy,
                Pages = entity.Pages?.ToModelList()
            };
        }
    }
}
