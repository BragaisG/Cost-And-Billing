using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CnBBAL
{
    public interface IRequestType
    {
        int RequestTypeID { get; set; }
        string RequestTypeName { get; set; }
    }
}
