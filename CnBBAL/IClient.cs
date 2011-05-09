using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CnBBAL
{
    public interface IClient
    {
        int ClientID { get; set; }
        String ClientName { get; set; }
    }
}
