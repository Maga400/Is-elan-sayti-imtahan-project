using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Is_elan_sayti_imtahan_project
{
    public class NameException : ApplicationException
    {
        public override string Message => "Sizin adiniz minumum 3 herf olmalidir!!!";
    }
}
