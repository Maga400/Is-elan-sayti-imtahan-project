using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Is_elan_sayti_imtahan_project
{
    public class Vakansiya
    {
        public int Id { get; set; }
        public string text { get; set; }
        public int salary { get; set; }
        public int salary2 { get; set; }

        public Vakansiya(int id,string text, int salary, int salary2)
        {
            Id = id;
            this.text = text;
            this.salary = salary;
            this.salary2 = salary2;
        }
        public override string ToString()
        {
            return $"{text} bacaran isci teleb olunur.Maasi {salary} {salary2} arasinda olacaq.Vakansiyanin id-si {Id}";
        }
    }
}
