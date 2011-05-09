using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace CnBDAL.Entities
{
    internal class Lookups : ILookups
    {
        public DataSet GetClients(int EmployeeID)
        {
            string SqlCommand = "dbo.pr_Brain_Lkp_Client";

            Database db = DatabaseFactory.CreateDatabase("DB02.Adonis");
            DbCommand dbCommand = db.GetStoredProcCommand(SqlCommand);

            db.AddInParameter(dbCommand, "@EmployeeID", DbType.Int32, EmployeeID);
            db.AddInParameter(dbCommand, "@HideFromListID", DbType.Int32, 0);
            db.AddInParameter(dbCommand, "@CompanySiteID", DbType.Int32, 0);

            return db.ExecuteDataSet(dbCommand);
        }

        public DataSet GetRequestTypes()
        {
            string SqlCommand = "dbo.tbl_CnB_GetRequestTypes";

            Database db = DatabaseFactory.CreateDatabase("Sandbox1.DevelopmentDB");
            DbCommand dbCommand = db.GetStoredProcCommand(SqlCommand);

            return db.ExecuteDataSet(dbCommand);
        }

        public DataSet GetWorkTypes()
        {
            string SqlCommand = "dbo.tbl_CnB_GetWorkTypes";

            Database db = DatabaseFactory.CreateDatabase("Sandbox1.DevelopmentDB");
            DbCommand dbCommand = db.GetStoredProcCommand(SqlCommand);

            return db.ExecuteDataSet(dbCommand);
        }
    }
}
