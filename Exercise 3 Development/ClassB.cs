using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3_Development
{
    class ClassB : Program , Interface1 {

        public void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }

        public void Orders(List<string> ListString)
        {
            Console.Write("-Desc Order: ");
            ListString.Sort();
            foreach(string value in ListString)
            {
                Console.WriteLine(value);
            }

            Console.WriteLine("-Asc Order:");
            ListString.Reverse();
            foreach(string value1 in ListString)
            {
                Console.WriteLine(value1);
            }
        }

        public void RemoveNull(List<string> ListString)
        {
            Console.WriteLine("-List without spaces");
            string[] test = ListString.ToArray();
            test = test.Where(x => !string.IsNullOrEmpty(x)).ToArray();


            foreach (string value2 in test)
            {
                Console.WriteLine(value2);
            }
        }

        public void MissingNumbers(List<int> myList)
        {
            int[] a = myList.ToArray();
            myList = myList.Distinct().ToList();
            Console.WriteLine("The distinct elements: ");
            foreach (int value3 in myList)
            {
                Console.WriteLine(value3);
            }
            Console.WriteLine("Repeated numbers:");
            var duplicates = a.GroupBy(g => g).Where(w => w.Count() > 1).Select(s => s.Key);
            foreach (var d in duplicates)
            {
                Console.WriteLine(d);
            }

            Console.WriteLine("Missing numbers:");
            var missingNumbers = Enumerable.Range(0, 10).Except(myList);
            foreach (int res in missingNumbers)
            {
                Console.WriteLine(res);
            }
        }

    }
}
