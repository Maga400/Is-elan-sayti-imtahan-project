using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Is_elan_sayti_imtahan_project
{
    public class Employee
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Sheher { get; set; }
        public string Phone { get; set; }
        public int Age { get; set; }
        public Vakansiya Vacancies { get; set; }
        public Employee(Guid ıd, string name, string surname, string sheher, string phone, int age, Vakansiya vacancies)
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

            Vacancies = vacancies;
            
        }

        public override string ToString()
        {
            Console.WriteLine("------------------Employeee information---------------");
            return $"Id: {Id}\nName: {Name}\nSurname: {Surname}\nSheher: {Sheher}\nPhone number: {Phone}\nAge: {Age}\nVacancies: {Vacancies}\n";
        }

    }
}
