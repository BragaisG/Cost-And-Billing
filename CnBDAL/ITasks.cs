﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.Common;

namespace CnBDAL
{
    public interface ITasks
    {
        DataSet GetTasks(int Month);
    }
}
