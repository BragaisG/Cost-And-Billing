using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.Common;

namespace CnBBAL.Entities
{
    internal class ClientCollection : List<IClient>, IClientCollection
    {
        #region Methods

        public IClientCollection GetClients()
        {
            IClientCollection clientCollection = Factory.ClientCollectionFactory.Instantiate();

            DataSet ds = CnBDAL.LookupFactory.Instantiate().GetClients();

            if (ds.Tables.Count > 0)
                if (ds.Tables[0].Rows.Count > 0)
                {
                    IClient _Client;
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        _Client = Factory.ClientFactory.Instantiate();
                        _Client.ClientID = Convert.ToInt32(dr["ClientID"].ToString());
                        _Client.ClientName = dr["ClientName"].ToString().Trim();

                        clientCollection.Add(_Client);
                    }
                }

            return clientCollection;
        }

        #endregion
    }
}
