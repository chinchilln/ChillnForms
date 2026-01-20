using ChillnForms.Api.Interface;
using ChillnForms.Common;
using ChillnForms.Core;
using ChillnForms.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChillnForms.Api.Service
{
    public abstract class BaseCrudService<TModel, TEntity> : IBaseCrud<TModel> where TModel : class, IAuditable where TEntity : class, IAuditable
    {
        ChillnFormsContext _context;
        protected BaseCrudService(ChillnFormsContext context) 
        {
            _context = context;
        }
        
        protected TEntity ModelToEntity(TModel model) => throw new NotImplementedException();
        protected TModel EntityToModel(TEntity entity) => throw new NotImplementedException();
        protected IEnumerable<TModel> EntitiesToModels(IEnumerable<TEntity> entities) => throw new NotImplementedException();
        protected IEnumerable<TEntity> ModelsToEntities(IEnumerable<TModel> models) => throw new NotImplementedException();

        public virtual TModel Create(TModel item)
        {
             var entity = _context.Set<TEntity>().Add(ModelToEntity(item));
            return entity != null ? EntityToModel(entity.Entity) : throw new Exception();
        }

        public virtual void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public virtual TModel GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public virtual IEnumerable<TModel> Read()
        {
            throw new NotImplementedException();
        }

        public virtual PagedResultModel<TModel> Read(PageQueryModel query)
        {
            throw new NotImplementedException();
        }

        public virtual TModel Update(TModel item)
        {
            throw new NotImplementedException();
        }
    }
}
