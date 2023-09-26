using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Is_elan_sayti_imtahan_project
{
    public class FalseException : ApplicationException
    {
        public override string Message => "Siz ya Yanlis user name yada yanlis password daxil etdiniz";
    }
}
