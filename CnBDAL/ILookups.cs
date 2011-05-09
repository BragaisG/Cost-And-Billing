using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;

namespace CnBDAL
{
    public interface ILookups
    {
        DataSet GetClients(int EmployeeID);
        DataSet GetRequestTypes();
        DataSet GetWorkTypes();
    }
}
