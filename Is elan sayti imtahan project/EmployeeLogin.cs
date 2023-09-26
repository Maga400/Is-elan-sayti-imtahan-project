using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Is_elan_sayti_imtahan_project
{
    public class EmployeeLogin
    {
        public EmployeeLogin(string? userName, string? password)
        {
            UserName = userName;
            Password = password;
        }

        public string? UserName { get; set; }
        public string? Password { get; set; }
    }
}
