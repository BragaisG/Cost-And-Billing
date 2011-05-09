using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CnBBAL
{
    public interface IWorkTypeCollection : ICollection<IWorkType>
    {
        IWorkTypeCollection GetWorkTypes();
    }
}
