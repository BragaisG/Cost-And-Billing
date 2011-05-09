using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CnBBAL
{
    public interface IClientCollection : ICollection<IClient>
    {
        IClientCollection GetClients(int EmployeeID);
    }
}
