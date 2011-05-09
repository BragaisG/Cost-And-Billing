using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using CnBBAL.AuthenticationService;

namespace CnBBAL.Entities
{
    internal class AuthenticateUser : IAuthenticateUser
    {
        public bool VerifyUser(string UserName, string Password)
        {
            int _cim = int.Parse(UserName);

            // Use User Verification Service
            AuthServiceClient authService = new AuthServiceClient();

            return authService.Authenticate(_cim, Password);
        }

        public CnBBAL.AuthenticationService.EmployeeDetails GetEmployeeDetails(int CimNumber)
        {
            AuthServiceClient authService = new AuthServiceClient();
            return authService.GetEmployee(CimNumber);
        }
    }
}
