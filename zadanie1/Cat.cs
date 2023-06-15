using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie1
{
    class Cat
    {
        private string name;
        private double ves;

        public Cat (string CatName)
        {
            name = CatName;
        }

        public void Meow ()
        {
            Console.WriteLine($"{name}: МЯЯЯЯУ!!!!");
        }

        public void Kot ()
        {
            Console.WriteLine($"Вес {name}: {ves}");
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                bool OnlyLetters = true;
                foreach (var ch in value)
                {
                    if (!char.IsLetter(ch))
                    {
                        OnlyLetters = false;
                    }
                }
                if (OnlyLetters)
                {
                    name = value;
                }
                else
                {
                    Console.WriteLine($"{value} - неправильное имя!!!");
                }
            }
        }

        public double Ves
        {
            get
            {
                return ves;

            }
            set
            {
                if (value != 0 && value > 0)
                {
                    ves = value;
                }
                else if (value < 0)
                {
                    Console.WriteLine("Вес кота не может быть отрицательным");
                }
                else if (value == 0)
                {
                    Console.WriteLine("Вес кота не может быть равным нулю");
                }
            }
        }
    }

    }


