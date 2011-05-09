using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CnBBAL.Factory
{

    #region Exposed Factory Objects

    public class ClientCollectionFactory
    {
        ClientCollectionFactory() { }
        public static IClientCollection Instantiate()
        {
            return new Entities.ClientCollection();
        }
    }

    public class UserAuthenticationFactory
    {
        UserAuthenticationFactory() { }
        public static IAuthenticateUser Instantiate()
        {
            return new Entities.AuthenticateUser();
        }
    }

    public class RequestTypeCollectionFactory
    {
        RequestTypeCollectionFactory() { }
        public static IRequestTypeCollection Instantiate()
        {
            return new Entities.RequestTypeCollection();
        }
    }

    public class WorkTypeCollectionFactory
    {
        WorkTypeCollectionFactory() { }
        public static IWorkTypeCollection Instantiate()
        {
            return new Entities.WorkTypeCollection();
        }
    }

    public class TaskFactory
    {
        TaskFactory() { }
        public static ITask Instantiate()
        {
            return new Entities.Task();
        }
    }

    #endregion

    #region internal Factory Objects

    internal class ClientFactory
    {
        ClientFactory() { }
        public static IClient Instantiate()
        {
            return new Entities.Client();
        }
    }

    internal class RequestTypeFactory
    {
        RequestTypeFactory() { }
        public static IRequestType Instantiate()
        {
            return new Entities.RequestType();
        }
    }

    internal class WorkTypeFactory
    {
        WorkTypeFactory() { }
        public static IWorkType Instantiate()
        {
            return new Entities.WorkType();
        }
    }

    #endregion
}
