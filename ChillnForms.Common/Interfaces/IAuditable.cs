using System;
using System.Collections.Generic;
using System.Text;

namespace ChillnForms.Common
{
    public interface IAuditable : IId
    {
        DateTime DateCreated { get; set; }
        DateTime LastModified { get; set; }
        Guid? CreatedBy { get; set; }
        Guid? LastModifiedBy { get; set; }
    }
}
