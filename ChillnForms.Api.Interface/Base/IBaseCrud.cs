using System;
using System.Collections.Generic;
using System.Text;
using ChillnForms.Common;
using ChillnForms.Models;

namespace ChillnForms.Api.Interface
{
    public interface IBaseCrud<TModel> where TModel : class, IAuditable
    {
        TModel Create(TModel item);
        TModel GetById(Guid id);
        IEnumerable<TModel> Read();
        PagedResultModel<TModel> Read(PageQueryModel query);
        TModel Update(TModel item);
        void Delete(Guid id);
    }
}
