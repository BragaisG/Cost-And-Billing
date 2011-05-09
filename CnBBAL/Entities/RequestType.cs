using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CnBBAL.Entities
{
    internal class RequestType : IRequestType
    {
        #region IRequestType Members

        public int RequestTypeID { get; set; }
        public string RequestTypeName {get;set;}

        #endregion
    }
}
