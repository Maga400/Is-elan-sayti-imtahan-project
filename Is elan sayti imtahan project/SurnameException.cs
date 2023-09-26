using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Is_elan_sayti_imtahan_project
{
    public class SurnameException :ApplicationException
    {
        public override string Message => "Sizin soyadiniz minumum 5 herf olmalidir!!!";
    }
}
