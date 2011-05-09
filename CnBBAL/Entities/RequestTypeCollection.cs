using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.Common;

namespace CnBBAL.Entities
{
    internal class RequestTypeCollection : List<IRequestType>, IRequestTypeCollection
    {
        public IRequestTypeCollection GetRequestTypes()
        {
            IRequestTypeCollection _RequestTypes = Factory.RequestTypeCollectionFactory.Instantiate();
            DataSet ds = CnBDAL.LookupFactory.Instantiate().GetRequestTypes();

            if (ds.Tables.Count > 0)
                if (ds.Tables[0].Rows.Count > 0)
                {
                    IRequestType _RequestType;
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        _RequestType = Factory.RequestTypeFactory.Instantiate();
                        _RequestType.RequestTypeID = int.Parse(dr["RequestTypeID"].ToString());
                        _RequestType.RequestTypeName = dr["RequestType"].ToString();

                        _RequestTypes.Add(_RequestType);
                    }
                }
            return _RequestTypes;
        }
    }
}
