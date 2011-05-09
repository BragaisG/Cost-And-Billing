using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.Common;

namespace CnBBAL.Entities
{
    internal class Task : ITask
    {
        #region Properties

        public int TaskID { get; set; }
        public int ClientID { get; set; }
        public string ProgramName { get; set; }
        public string ApplicationName { get; set; }
        public int TandimNumber { get; set; }
        public int RequestTypeID { get; set; }
        public int WorkTypeID { get; set; }
        public double HoursEstimate { get; set; }
        public double HoursActual { get; set; }
        public string Description { get; set; }
        public string Notes { get; set; }

        private string _Error;
        public string Error
        {
            get { return _Error; }
        }

        #endregion

        #region Public Methods

        public bool Save()
        {
            return CnBDAL.DBWorkerFactory.Instantiate().Save(ClientID, ProgramName, ApplicationName, TandimNumber,
                RequestTypeID, WorkTypeID, HoursEstimate, HoursActual, Description, Notes, ref _Error);
        }

        public bool Update()
        {
            return CnBDAL.DBWorkerFactory.Instantiate().Update(TaskID, ClientID, ProgramName, ApplicationName,
                TandimNumber, RequestTypeID, WorkTypeID, HoursEstimate, HoursActual, Description, Notes, ref _Error);
        }

        public bool Delete()
        {
            return CnBDAL.DBWorkerFactory.Instantiate().Delete(TaskID, ref _Error);
        }

        #endregion

    }
}
