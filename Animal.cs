using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTask
{
    internal class Animal
    {
        public string Name;

        private int _age { get; set; }
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("the age should not be less than 0");
                }
                else
                {
                    _age = value;
                }
            }
        }
        public string Breed;

        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void getInfo()
        {
            Console.WriteLine($"this animal's breed is {Breed}, name is {Name}, and age is {Age}");
        }
    }
}
