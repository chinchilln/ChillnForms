using System;
using System.Collections.Generic;
using System.Text;

namespace ChillnForms.Common
{
    public interface ISyncable
    {
        bool IsDeleted { get; set; }  
        DateTime LastModified { get; set; }
    }
}
