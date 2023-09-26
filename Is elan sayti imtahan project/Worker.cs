using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Is_elan_sayti_imtahan_project
{
    public class Worker
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Sheher {get; set; }
        public string Phone { get; set; }
        public int Age { get; set; }
        public List<Cv> Cvs { get; set; }

        public Worker(Guid ıd, string name, string surname, string sheher, string phone, int age, List<Cv> cvs)
        {
            Id = ıd;

            if (name.Length < 3)
            {
                throw new NameException();
            }
            else
            {
                Name = name;
            }

            if (surname.Length < 5)
            {
                throw new SurnameException();
            }

            else
            {
                Surname = surname;
            }

            if (sheher.Length < 3)
            {
                throw new SheherException();
            }
            else
            {
                Sheher = sheher;
            }

            if (phone.Length != 10)
            {
                throw new PhoneException();
            }
            else
            {
                Phone = phone;
            }

            if (age < 18)
            {
                throw new AgeException();
            }
            else
            {
                Age = age;
            }

            Cvs = cvs;
            
        }
        public override string ToString()
        {
            Console.WriteLine("--------------------Worker CVS-----------------\n");
            for (int i = 0; i < Cvs.Count; i++)
            {
                Console.WriteLine($"-------Cv{i + 1}-------");
                Console.WriteLine(Cvs[i].ToString() + "\n");
            }

            Console.WriteLine("----------------Worker Information-----------------");
            return $"Id: {Id}\nName: {Name}\nSurname: {Surname}\nSheher: {Sheher}\nPhone number: {Phone}\nAge: {Age}\n";

        }

        

    public void showCvs()
        {
            for (int j = 0; j < Cvs.Count; j++)
            {
                Console.WriteLine("-----------Cvs------------");
                Console.WriteLine(Cvs[j].ToString() + "\n");
            }
        }

    }
}
