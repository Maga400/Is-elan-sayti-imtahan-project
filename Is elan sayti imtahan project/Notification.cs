using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Is_elan_sayti_imtahan_project
{
    public class Notification
    {
        public string Name { get; set; }
        public string Message {get;set;}
        public int Salary {get;set;}
        public Notification(string name,string message, int salary)
        {
            Name = name;
            Message = message;
            Salary = salary;
        }

        public override string ToString()
        {
            return $"{Name}{Message}{Salary}";
        }
    }
}
