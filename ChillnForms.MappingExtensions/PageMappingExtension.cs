using ChillnForms.Core.Entities;
using ChillnForms.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChillnForms.MappingExtensions
{
    public static class PageMappingExtension
    {
        public static PageModel ToModel(this Page entity)
        {
            var model = new PageModel
            {
                Id = entity.Id,
                Name = entity.Name,
                BackendName = entity.BackendName,
                IsDeleted = entity.IsDeleted,
                LastModified = entity.LastModified,
                DateCreated = entity.DateCreated,
                CreatedBy = entity.CreatedBy,
                LastModifiedBy = entity.LastModifiedBy,
                Fields = entity.Fields?.ToModelList()
            };
            return model;
        }
    }
}
