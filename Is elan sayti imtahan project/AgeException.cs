using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Is_elan_sayti_imtahan_project
{
    public class AgeException :ApplicationException
    {
        public override string Message => "Sizin islemek ucun yasiniz 18-de daxil olmaqla 18-den boyuk olmalidir!!!";
    }
}
