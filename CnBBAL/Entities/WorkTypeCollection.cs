using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.Common;

namespace CnBBAL.Entities
{
    internal class WorkTypeCollection : List<IWorkType>, IWorkTypeCollection
    {
        public IWorkTypeCollection GetWorkTypes()
        {
            IWorkTypeCollection _WorkTypes = Factory.WorkTypeCollectionFactory.Instantiate();
            DataSet ds = CnBDAL.LookupFactory.Instantiate().GetWorkTypes();

            if (ds.Tables.Count > 0)
                if (ds.Tables[0].Rows.Count > 0)
                {
                    IWorkType _WorkType;
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        _WorkType = Factory.WorkTypeFactory.Instantiate();
                        _WorkType.WorkTypeID = int.Parse(dr["WorkTypeID"].ToString());
                        _WorkType.WorkTypeName = dr["WorkType"].ToString();

                        _WorkTypes.Add(_WorkType);
                    }
                }
            return _WorkTypes;
        }
    }
}
