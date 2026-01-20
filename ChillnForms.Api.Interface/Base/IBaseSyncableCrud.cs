using ChillnForms.Common;
using ChillnForms.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChillnForms.Api.Interface
{
    public interface IBaseSyncableCrud<Tmodel> : IBaseCrud<Tmodel> where Tmodel : class, ISyncable
    {
        Tmodel GetByIdExcludingIsDeleted(Guid id);
        IEnumerable<Tmodel> ReadExcludingIsDeleted();
        PagedResultModel<Tmodel> ReadExcludingIsDeleted(PageQueryModel query);
        Tmodel UpdateExcludingIsDeleted(Tmodel item);
        void SoftDelete(Guid id);
    }
}
