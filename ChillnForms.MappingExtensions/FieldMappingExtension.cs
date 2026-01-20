using ChillnForms.Core.Entities;
using ChillnForms.Models;
using ChillnForms.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChillnForms.MappingExtensions
{
    public static class FieldMappingExtension
    {
        public static FieldModel ToModel(this Field entity)
        {
            var model = new FieldModel
            {
                BackendName = entity.BackendName,
                Name = entity.Name,
                IsDeleted = entity.IsDeleted,
                LastModified = entity.LastModified,
                DateCreated = entity.DateCreated,
                CreatedBy = entity.CreatedBy,
                LastModifiedBy = entity.LastModifiedBy,
                ColumnIndex = entity.ColumnIndex,
                ColumnSpan = entity.ColumnSpan,
                Id = entity.Id,
                RowIndex = entity.RowIndex,
                Type = Enum.TryParse<FieldTypes>(entity.Type, out FieldTypes fieldType) ? fieldType : throw new ArgumentException($"Invalid field type: {entity.Type}"),
                RowSpan = entity.RowSpan,
            };
 
            return model;
        }

        public static Field ToEntity(this FieldModel model)
        {
            var entity = new Field
            {
                BackendName = model.BackendName,
                Name = model.Name,
                IsDeleted = model.IsDeleted,
                LastModified = model.LastModified,
                DateCreated = model.DateCreated,
                CreatedBy = model.CreatedBy,
                LastModifiedBy = model.LastModifiedBy,
                ColumnIndex = model.ColumnIndex,
                ColumnSpan = model.ColumnSpan,
                Id = model.Id,
                RowIndex = model.RowIndex,
                Type = model.Type.ToString(),
                PageId = model.PageId,
                RowSpan = model.RowSpan
            };
            return entity;
        }

        public static List<FieldModel> ToModelList(this IEnumerable<Field> entities)
        {
            var models = new List<FieldModel>();
            foreach (var entity in entities)
            {
                models.Add(entity.ToModel());
            }
            return models;
        }

        public static List<Field> ToEntityList(this IEnumerable<FieldModel> models)
        {
            var entities = new List<Field>();
            foreach (var model in models)
            {
                entities.Add(model.ToEntity());
            }
            return entities;
        }
    }
}
