using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTask
{
    internal class Snake : Animal
    {
        public Snake(string name, int age) : base(name, age)
        {

        }

        private bool _ispoisonous { get; set; }
        public bool IsPoisonous
        {
            get
            {
                return _ispoisonous;
            }

            set
            {

                if (value == true)
                {
                    Console.WriteLine("the poisonous snake is not required");
                }
                else
                {
                    value = false;
                }
            }


        }

    }
}
