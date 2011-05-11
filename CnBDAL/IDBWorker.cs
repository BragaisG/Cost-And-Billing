using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CnBDAL
{
    public interface IDBWorker
    {
        bool Save(int ClientID, string ProgramName, string ApplicationName, int TandimNumber,
            int RequestTypeID, int WorkTypeID, double HoursEstimate, double HoursActual,
            string Description, string Notes, int EmployeeID, ref string ErrorMessage);

        bool Update(int TaskID, int ClientID, string ProgramName, string ApplicationName,
            int TandimNumber, int RequestTypeID, int WorkTypeID, double HoursEstimate,
            double HoursActual, string Description, string Notes, ref string ErrorMessage);

        bool Delete(int TaskID, ref string ErrorMessage);
    }
}
