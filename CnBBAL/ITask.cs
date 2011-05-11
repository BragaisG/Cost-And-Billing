using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CnBBAL
{
    public interface ITask
    {
        int TaskID { get; set; }
        int ClientID { get; set; }
        string ClientName { get; set; }
        string ProgramName { get; set; }
        String ApplicationName { get; set; }
        int TandimNumber { get; set; }
        int RequestTypeID { get; set; }
        string RequestType { get; set; }
        int WorkTypeID { get; set; }
        string WorkType { get; set; }
        double HoursEstimate { get; set; }
        double HoursActual { get; set; }
        string Description { get; set; }
        string Notes { get; set; }
        int EmployeeID { get; set; }
        string Employee { get; set; }
        DateTime DateTimeEntered { get; set; }

        string Error { get; }

        bool Save();
        bool Update();
        bool Delete();
    }
}
