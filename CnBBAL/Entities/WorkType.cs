using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CnBBAL.Entities
{
    internal class WorkType : IWorkType
    {
        public int WorkTypeID { get; set; }
        public string WorkTypeName { get; set; }
    }
}
