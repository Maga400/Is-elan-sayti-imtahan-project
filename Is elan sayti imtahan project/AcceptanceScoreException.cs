using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Is_elan_sayti_imtahan_project
{
    public class AcceptanceScoreException : ApplicationException
    {
        public override string Message => "Sizin baliniz 700-den yuxari ola bilmez!!!";
    }
}
