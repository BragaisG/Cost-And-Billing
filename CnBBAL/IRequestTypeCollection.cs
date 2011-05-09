using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CnBBAL
{
    public interface IRequestTypeCollection : ICollection<IRequestType>
    {
        IRequestTypeCollection GetRequestTypes();
    }
}
