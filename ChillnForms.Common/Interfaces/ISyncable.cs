using System;
using System.Collections.Generic;
using System.Text;

namespace ChillnForms.Common
{
    public interface ISyncable : IAuditable
    {
        bool IsDeleted { get; set; }
        new DateTime LastModified { get; set; }
    }
}
