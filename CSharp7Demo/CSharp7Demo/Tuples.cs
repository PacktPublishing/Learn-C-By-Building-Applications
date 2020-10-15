using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp7Demo
{
    class Tuples
    {
        public void Run()
        {
            Tuple<string, string, int> oldTuple = getOldTuple();
            Console.WriteLine($"{oldTuple.Item1} {oldTuple.Item2} {oldTuple.Item3}");

            // Unnamed Tuple
            var newUnnamedTuple = getNewUnnamedTuple();
            Console.WriteLine($"{newUnnamedTuple.Item1} {newUnnamedTuple.Item2} {newUnnamedTuple.Item3}");

            var (FirstnameV1, LastnameV1, AgeV1) = getNewUnnamedTuple();
            Console.WriteLine($"{FirstnameV1} {LastnameV1} {AgeV1}");

            (var FirstnameV2, var LastnameV2, var AgeV2) = getNewUnnamedTuple();
            Console.WriteLine($"{FirstnameV2} {LastnameV2} {AgeV2}");

            (string FirstnameV3, string LastnameV3, int AgeV3) = getNewUnnamedTuple();
            Console.WriteLine($"{FirstnameV3} {LastnameV3} {AgeV3}");

            // Named Tuples
            var (FirstnameV4, LastnameV4, AgeV4) = getNewNamedTuple();
            Console.WriteLine($"{FirstnameV4} {LastnameV4} {AgeV4}");

            (string FirstnameV5, string LastnameV5, int AgeV5) = getNewNamedTuple();
            Console.WriteLine($"{FirstnameV5} {LastnameV5} {AgeV5}");

            var newNamedTuple = getNewNamedTuple();
            Console.WriteLine($"{newNamedTuple.Firstname} {newNamedTuple.Lastname} {newNamedTuple.Age}");
        }

        private (string Firstname, string Lastname, int Age) getNewNamedTuple()
        {
            return ("Mark", "Wilson", 30);
        }

        private (string, string, int) getNewUnnamedTuple()
        {
            return ("Mark", "Wilson", 30);
        }

        private Tuple<string, string, int> getOldTuple()
        {
            return Tuple.Create("Mark", "Wilson", 30);
        }
    }
}
