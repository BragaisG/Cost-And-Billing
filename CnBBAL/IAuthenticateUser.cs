using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using CnBBAL.AuthenticationService;

namespace CnBBAL
{
    public interface IAuthenticateUser
    {
        /// <summary>
        /// Virifies User Authentication
        /// </summary>
        /// <param name="UserName"></param>
        /// <param name="Password"></param>
        /// <returns></returns>
        bool VerifyUser(string UserName, string Password);
        CnBBAL.AuthenticationService.EmployeeDetails GetEmployeeDetails(int CimNumber);
    }
}
