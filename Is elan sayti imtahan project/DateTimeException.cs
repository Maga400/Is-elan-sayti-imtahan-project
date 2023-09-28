using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Is_elan_sayti_imtahan_project
{
    public class DateTimeException:Exception
    {
        public override string Message => "Siz duzgun date time daxil etmediniz!!!";
    }
}
