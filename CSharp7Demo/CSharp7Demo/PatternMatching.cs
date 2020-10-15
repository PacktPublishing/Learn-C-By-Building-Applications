using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp7Demo
{
    abstract class Person
    {
        public Person(bool isAngry) => IsAngry = isAngry;

        public bool IsAngry { get; }
    }

    class NormalPerson : Person
    {
        public NormalPerson(bool isAngry)
            : base(isAngry)
        {
        }
    }

    class SuperPerson : Person
    {
        public SuperPerson(bool isAngry)
            : base(isAngry)
        {
        }
    }

    class PatternMatching
    {
        public void Run()
        {
            Person normalPerson = new NormalPerson(false);
            Person superPerson = new SuperPerson(false);

            BreakTheWall(normalPerson);
            BreakTheWall(superPerson);

            WhatCanYouBreak(normalPerson);
            WhatCanYouBreak(superPerson);
            WhatCanYouBreak(null);
        }

        private void BreakTheWall(Person person)
        {
            if (person is SuperPerson superPerson || person is NormalPerson normalPerson && normalPerson.IsAngry)
            {
                Console.WriteLine("Wall broke!");
            }
            else
            {
                Console.WriteLine("Wall didn't break!");
            }
        }

        private void WhatCanYouBreak(Person person)
        {
            switch (person)
            {
                default:
                    Console.WriteLine("Nothing broke.");
                    break;
                case SuperPerson superPerson when superPerson.IsAngry:
                    Console.WriteLine("Can break stone wall, titanum wall.");
                    break;
                case SuperPerson superPerson:
                    Console.WriteLine("Can break stone wall.");
                    break;
                case NormalPerson normalPerson when normalPerson.IsAngry:
                    Console.WriteLine("Can break stone wall.");
                    break;
                case NormalPerson normalPerson:
                    Console.WriteLine("Cannot break stone wall.");
                    break;
                case null:
                    Console.WriteLine("The wall will stay as it is since nobody will be hitting it.");
                    break;
            }
        }
    }
}
