using System.Collections.Generic;

namespace list
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //List<String> myList = new List<String>();

            //List<String> List2 = new List<String> {"maria", "alex"};

            List<String> List = new List<String>();

            List.Add("maria");
            List.Add("Ana");
            List.Add("Alex");
            List.Add("Bob");
            List.Insert(2, "Marco");


            foreach (String s in List)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("list cout: " + List.Count);


            string s1 = List.Find(x => x[0] == 'A');
            Console.WriteLine("Firt 'A': " + s1);

            string s2 = List.FindLast(x => x[0] == 'A');
            Console.WriteLine("Last 'A': " + s2);

            int pos1 = List.FindIndex(x => x[0] == 'A');
            Console.WriteLine("primeira posição: " + pos1);

            int pos2 = List.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("ultima posição: " + pos2);

            List<String> list2 = List.FindAll(x => x.Length == 5);
            Console.WriteLine("___________________");
            foreach(String s in list2)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("-----------------------");

            List.Remove("Alex");
            foreach (string name in List)
            {
                Console.WriteLine(name);
            }

            List.RemoveAll(x => x[0] == 'M');
            Console.WriteLine("-----------------");
            foreach (string s in List)
            {
                Console.WriteLine(s);
            }

            List.RemoveAt(2);
            foreach (string s in List)
            {
                Console.WriteLine(s);
            }
        
        }
    }
}