using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3_Development
{
    class Program 
    {

        static void Main(string[] args)
        {
            
            //Method that compares if the lenght of 2 strings are the same
            string word1, word2;
            Console.WriteLine("Enter the first word: ");
            word1 = Console.ReadLine();
            Console.WriteLine("Enter the second word: ");
            word2 = Console.ReadLine();
            Program obj1 = new Program();
            obj1.CompareLenght(word1, word2);

            //Method that compares if the size of 2 lists are the same
            bool response;
            List<string> list1 = new List<string>();
            List<string> list2 = new List<string>();
            
            
            do
            {
                Console.WriteLine("Enter the word to add into the first list: ");
                list1.Add(Console.ReadLine());
               
                Console.WriteLine("Do you want to add more words? true or false? ");
                response = Convert.ToBoolean(Console.ReadLine());
            } while (response == true);


            do
            {
                Console.WriteLine("Enter the word to add into the second list: ");
                list2.Add(Console.ReadLine());

                Console.WriteLine("Do you want to add more words? true or false? ");
                response = Convert.ToBoolean(Console.ReadLine());
            } while (response == true);

            Program obj2 = new Program();
            obj2.CompareList(list1, list2);


            //Use functionality from (A) in a new method from (B).
            Console.WriteLine("Enter the first word: ");
            word1 = Console.ReadLine();
            Console.WriteLine("Enter the second word: ");
            word2 = Console.ReadLine();
            ClassB obj3 = new ClassB();
            obj3.CompareLenght(word1, word2);

            
            //Return type: Void - Body: NA - Parameters NA - Functionality: Print "Hello Interface"
            ClassB obj4 = new ClassB();
            obj4.PrintMessage("Hello Interface");
           

            //Create a list of strings with the following values:
            List<string> listofStrings = new List<string>() { "Text", "Computer", "Automation", "Visual Studio", "Auto Parts", " " };
            //Create a method that orders by desc and asc order based on a parameter.
            ClassB obj5 = new ClassB();
            obj5.Orders(listofStrings);
            

            //Create a method that removes null values
            ClassB obj6 = new ClassB();
            obj6.RemoveNull(listofStrings);
            
            //Create a list of integers with the following values:
            List<int> listofNumbers = new List<int>() { 2, 2, 3, 4, 4, 5, 6, 7, 8, 10 };
            //Create a method that removes duplicate numbers
            ClassB obj7 = new ClassB();
            obj7.MissingNumbers(listofNumbers);

            Console.ReadLine();
        }

        public void CompareLenght(string Word1, string Word2)
        {
            int len1 = Word1.Length;
            int len2 = Word2.Length;
            if (len1==len2)
            {
                Console.WriteLine("Two words have the same size "+ len1);
            }
            else
            {
                Console.WriteLine("The words does not have the same size ");
            }
        }

        public void CompareList(List <string> List1, List <string> List2)
        {
            if (List1.Count==List2.Count)
            {
                Console.WriteLine("Two lists have the same size " + List1.Count);
            }
            else
            {
                Console.WriteLine(" The two lists does not have the same size ");
            }
        }
      
            

        

    }
}
