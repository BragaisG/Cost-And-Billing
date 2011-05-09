using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace CnBDAL.Entities
{
    internal class DBWorker : IDBWorker
    {
        public bool Save(int ClientID, string ProgramName, string ApplicationName, int TandimNumber,
            int RequestTypeID, int WorkTypeID, double HoursEstimate, double HoursActual,
            string Description, string Notes, ref string ErrorMessage)
        {
            try
            {
                string SqlCommand = "dbo.tbl_CnB_SaveTask";
                Database db = DatabaseFactory.CreateDatabase("Sandbox1.DevelopmentDB");
                DbCommand dbCommand = db.GetStoredProcCommand(SqlCommand);

                db.AddInParameter(dbCommand, "@ClientID", DbType.Int32, ClientID);
                db.AddInParameter(dbCommand, "@ProgramName", DbType.String, ProgramName);
                db.AddInParameter(dbCommand, "@ApplicationName", DbType.String, ApplicationName);
                db.AddInParameter(dbCommand, "@ReferenceTandim", DbType.Int32, TandimNumber);
                db.AddInParameter(dbCommand, "@RequestTypeID", DbType.Int32, RequestTypeID);
                db.AddInParameter(dbCommand, "@WorkTypeID", DbType.Int32, WorkTypeID);
                db.AddInParameter(dbCommand, "@HoursEstimate", DbType.Double, HoursEstimate);
                db.AddInParameter(dbCommand, "@HoursActual", DbType.Double, HoursActual);
                db.AddInParameter(dbCommand, "@Description", DbType.String, Description);
                db.AddInParameter(dbCommand, "@Notes", DbType.String, Notes);

                int j = db.ExecuteNonQuery(dbCommand);
                return true;
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
                return false;
            }
        }

        public bool Update(int TaskID, int ClientID, string ProgramName, string ApplicationName,
            int TandimNumber, int RequestTypeID, int WorkTypeID, double HoursEstimate,
            double HoursActual, string Description, string Notes, ref string ErrorMessage)
        {

            try
            {
                string SqlCommand = "dbo.tbl_CnB_UpdateTask";
                Database db = DatabaseFactory.CreateDatabase("Sandbox1.DevelopmentDB");
                DbCommand dbCommand = db.GetStoredProcCommand(SqlCommand);

                db.AddInParameter(dbCommand, "@TaskID", DbType.Int32, TaskID);
                db.AddInParameter(dbCommand, "@ClientID", DbType.Int32, ClientID);
                db.AddInParameter(dbCommand, "@ProgramName", DbType.String, ProgramName);
                db.AddInParameter(dbCommand, "@ApplicationName", DbType.String, ApplicationName);
                db.AddInParameter(dbCommand, "@TandimNumber", DbType.Int32, TandimNumber);
                db.AddInParameter(dbCommand, "@RequestTypeID", DbType.Int32, RequestTypeID);
                db.AddInParameter(dbCommand, "@WorkTypeID", DbType.Int32, WorkTypeID);
                db.AddInParameter(dbCommand, "@HoursEstimate", DbType.Double, HoursEstimate);
                db.AddInParameter(dbCommand, "@HoursActual", DbType.Double, HoursActual);
                db.AddInParameter(dbCommand, "@Description", DbType.String, Description);
                db.AddInParameter(dbCommand, "@Notes", DbType.String, Notes);

                int j = db.ExecuteNonQuery(dbCommand);
                return true;
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
                return false;
            }

        }

        public bool Delete(int TaskID, ref string ErrorMessage)
        {
            try
            {
                string SqlCommand = "dbo.tbl_CnB_DeleteTask";
                Database db = DatabaseFactory.CreateDatabase("Sandbox1.DevelopmentDB");
                DbCommand dbCommand = db.GetStoredProcCommand(SqlCommand);

                db.AddInParameter(dbCommand, "@TaskID", DbType.Int32, TaskID);

                int j = db.ExecuteNonQuery(dbCommand);
                return true;
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
                return false;
            }
        }
    }
}
