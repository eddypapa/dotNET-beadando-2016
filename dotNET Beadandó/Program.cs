using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNET_Beadandó
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int>();

            dictionary.Add("apple", 1);
            dictionary.Add("windows", 2);
            dictionary.Add("random", 3);
            dictionary.Add("szavak", 4);
            dictionary.Add("egymas", 5);
            dictionary.Add("utan", 6);
            dictionary.Add("beadando", 7);
            dictionary.Add("kitartas", 8);
            dictionary.Add("fiu", 9);
            dictionary.Add("lany", 10);
            dictionary.Add("viz", 11);
            dictionary.Add("szorp", 12);
            dictionary.Add("iphone", 13);
            dictionary.Add("macbook", 14);
            dictionary.Add("boldog", 15);

            //kiiratas
            Console.WriteLine("A Dictionary tartalma:");
            foreach (var pair in dictionary)
            {
                Console.WriteLine("{0},{1}", pair.Key, pair.Value);
            }
            Console.WriteLine(" ");

            //windows key-re keres es ha talal akkor igazat ad
            Console.WriteLine("Hanyadik helyen van a windows?");
            if (dictionary.ContainsKey("windows")) {
                int value = dictionary["windows"];
                Console.WriteLine(value);
                Console.WriteLine(" ");
            }

            //a 10-es ertekre keres ra es ha van akkor igazat ad
            Console.WriteLine("Van-e 10-es erteku elem?");
            if (dictionary.ContainsValue(10)) {
                Console.WriteLine(true);
                Console.WriteLine(" ");
            }
            else {
                Console.WriteLine(false);
                Console.WriteLine(" ");
            }

            //atmasolom az egeszet egy mentesbe
            Dictionary<string, int> backup = new Dictionary<string, int>(dictionary);

            //torlom a windows es a random elemet
            dictionary.Remove("windows");
            dictionary.Remove("random");

            //egyenlo-e a ket dictionary
            bool egyenlo = false;
            if (dictionary.Count == backup.Count) {
                egyenlo = true;
                foreach (var pair in dictionary) {
                    int value;
                    if (backup.TryGetValue(pair.Key, out value)) {
                        if (value != pair.Value) {
                            egyenlo = false;
                            break;
                        }
                    }
                    else {
                        egyenlo = false;
                        break;
                    }
                }
            }
            Console.WriteLine("Egyenlo-e az eredeti es a mentett dictionaryk?");
            Console.WriteLine(egyenlo);
            Console.WriteLine(" ");

            foreach (var pair in dictionary)
            {
                Console.WriteLine("{0},{1}", pair.Key, pair.Value);
            }
            Console.WriteLine(" ");

            


            Console.ReadKey();
            
        }
    }
}
