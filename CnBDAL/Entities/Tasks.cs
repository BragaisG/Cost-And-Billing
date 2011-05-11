using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace CnBDAL.Entities
{
    internal class Tasks : ITasks
    {
        public DataSet GetTasks(int Month)
        {
            string SqlCommand = "dbo.tbl_CnB_GetTasks";
            Database db = DatabaseFactory.CreateDatabase("Sandbox1.DevelopmentDB");
            DbCommand dbCommand = db.GetStoredProcCommand(SqlCommand);

            db.AddInParameter(dbCommand, "@Month", DbType.Int32, Month);
            return db.ExecuteDataSet(dbCommand);
        }
    }
}
