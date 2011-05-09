using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CnBBAL.Entities
{
    internal class Client : IClient
    {
        public int ClientID { get; set; }
        public String ClientName { get; set; }
    }
}
