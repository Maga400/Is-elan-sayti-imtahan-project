using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Is_elan_sayti_imtahan_project
{
    public class SheherException : ApplicationException
    {
        public override string Message => "Sizin seher adiniz minumum 3 herfli olmalidir!!!";
    }
}
