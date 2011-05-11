using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CnBBAL
{
    public interface ITaskCollection : IList<ITask>
    {
        ITaskCollection GetTasks(int Month);
    }
}
