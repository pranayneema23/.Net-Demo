using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableVsListVsArray
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
             IEnumerable provides only minimal "iterable" functionality. 
             You can traverse the sequence, but that's about it. 
             This has disadvantages -- for example, it is very inefficient to count elements using IEnumerable, 
             or to get the nth element -- but it has advantages too -- for example, an IEnumerable could be an endless sequence,
             like the sequence of primes.

            Array is a fixed-size collection with random access (i.e. you can index into it).

            List is a variable-size collection (i.e. you can add and remove elements) with random access.

            IList is an interface which abstracts list functionality (count, add, remove, indexer access) 
            away from the various concrete classes such as List, BindingList, ObservableCollection, etc.
             */
            var names = new List<string> { "Pranay", "Akshay", "Mohit", "sam", "alexia", "simon", "sumanth", "tony", "sam", "amr", "mark", "drew" };
            var moreThanFiveLetterIEnumerable = names.Where(n => n.Length > 5);
            var moreThanFiveLetterList = names.Where(n => n.Length > 5).ToList();
            names[0] = "Ram";
            //IEnumerables delay execution of the query until the code is looped over or a value type is extracted.
            //“IEnumerable describes behaviour, while List is an implementation of that behaviour.When you use IEnumerable, 
            //you give the compiler a chance to defer work until later, possibly optimising along the way.
            //If you use ToList() you force the compiler to reify the results right away.”
            Console.WriteLine("IEnumerable example");
            foreach (var name in moreThanFiveLetterIEnumerable)
                Console.WriteLine(name);

            Console.WriteLine("List example");
            foreach (var name in moreThanFiveLetterList)
                Console.WriteLine(name);

            /*
             * An array stores a fixed-size sequential collection of elements of the same type. 
             * It is used to store a collection of data, 
             * but the array can be considered as a collection of variables of the same type stored at contiguous memory locations. 
             * All arrays consist of contiguous memory locations, 
             * with the lowest address corresponds to the first element and the highest address to the last element.
             */

            int[] steps = new int[6] { 1, 2, 3, 4, 5, 6 };
            foreach (var val in steps)
                Console.WriteLine(val);

            Console.Read();
        }
    }
}
