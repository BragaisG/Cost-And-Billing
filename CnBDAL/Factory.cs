using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CnBDAL
{
    public class LookupFactory
    {
        LookupFactory() { }
        public static ILookups Instantiate()
        {
            return new Entities.Lookups();
        }
    }

    public class DBWorkerFactory
    {
        DBWorkerFactory() { }
        public static IDBWorker Instantiate()
        {
            return new Entities.DBWorker();
        }
    }

    public class TasksFactory
    {
        TasksFactory() { }
        public static ITasks Instantiate()
        {
            return new Entities.Tasks();
        }
    }
}
