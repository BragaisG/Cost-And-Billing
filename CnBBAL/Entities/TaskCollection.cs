using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.Common;

namespace CnBBAL.Entities
{
    internal class TaskCollection : List<ITask>, ITaskCollection
    {
        public ITaskCollection GetTasks(int Month)
        {
            ITaskCollection _taskCollection = Factory.TaskCollectionFactory.Instantiate();
            DataSet ds = CnBDAL.TasksFactory.Instantiate().GetTasks(Month);

            if (ds.Tables.Count > 0)
                if (ds.Tables[0].Rows.Count > 0)
                {
                    ITask _Task;
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        _Task = Factory.TaskFactory.Instantiate();
                        _Task.TaskID = Convert.ToInt32(dr["TaskID"].ToString());
                        _Task.ClientID = Convert.ToInt32(dr["ClientID"].ToString());
                        _Task.ClientName = dr["ClientName"].ToString();
                        _Task.ProgramName = dr["ProgramName"].ToString();
                        _Task.ApplicationName = dr["ApplicationName"].ToString();
                        _Task.TandimNumber = Convert.ToInt32(dr["TandimNumber"].ToString());
                        _Task.RequestTypeID = Convert.ToInt32(dr["RequestTypeID"].ToString());
                        _Task.RequestType = dr["RequestType"].ToString();
                        _Task.WorkTypeID = Convert.ToInt32(dr["WorkTypeID"].ToString());
                        _Task.WorkType = dr["WorkType"].ToString();
                        _Task.HoursEstimate = Convert.ToDouble(dr["HoursEstimate"].ToString());
                        _Task.HoursActual = Convert.ToDouble(dr["HoursActual"].ToString());
                        _Task.Description = dr["Description"].ToString();
                        _Task.Notes = dr["Notes"].ToString();
                        _Task.EmployeeID = Convert.ToInt32(dr["EnteredBy"].ToString());
                        _Task.Employee = dr["Employee"].ToString();
                        _Task.DateTimeEntered = Convert.ToDateTime(dr["DateTimeEntered"].ToString());

                        _taskCollection.Add(_Task);
                    }
                }
            return _taskCollection;
        }
    }
}
