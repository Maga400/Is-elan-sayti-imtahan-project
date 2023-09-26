using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Is_elan_sayti_imtahan_project
{
    public class PhoneException :ApplicationException
    {
        public override string Message => "Sizin phone number-iniz 10 simvoldan ibaret olmalidir!!!";
    }
}
