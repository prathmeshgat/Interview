using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview
{
    class DictionaryMethods
    {
        Dictionary<int, string> dictObj1 = new Dictionary<int, string>();

        public void demoDict1()
        {
            //Add Elements to dictionary
            dictObj1.Add(1,"prathmesh");
            dictObj1.Add(2,"rahul");
            dictObj1.Add(3,"aayan");

            //find key value pair at location
            KeyValuePair<int, string> pair = dictObj1.ElementAt(1);
            Console.WriteLine(pair.Key + "***" + pair.Value);

            //find key value pair at first position
            KeyValuePair<int, string> pair2 = dictObj1.First();
            Console.WriteLine(pair2.Key + "***" + pair2.Value);

            //find key value pair at first position
            KeyValuePair<int, string> pair3 = dictObj1.Last();
            Console.WriteLine(pair3.Key + "***" + pair3.Value);

            //Find if key is present in dictionary
            if (dictObj1.ContainsKey(3))
                Console.WriteLine("Key present");
            else
                Console.WriteLine("Key Not present");

            //Find if value present in dictionary
            if (dictObj1.ContainsValue("aayan"))
                Console.WriteLine("Value Present");
            else
                Console.WriteLine("Value Not Present");

            //loop through dictionary as key value pairs
            foreach(var item in dictObj1)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }

            //number of elements in dict
            Console.WriteLine("No of elements::"+dictObj1.Count);

            //Remove with key
            dictObj1.Remove(1);
            display_dictObj1(dictObj1);
            
            // order by keys in ascending order
            //dictObj1 = dictObj1.OrderBy(x=> x).ToDictionary((keyItem) => keyItem.Key, (valueItem) => valueItem.Value);
            //display_dictObj1(dictObj1);

            //order by keys in desc order
            //dictObj1 = dictObj1.OrderByDescending(x => x).ToDictionary((keyItem) => keyItem.Key, (valueItem) => valueItem.Value);
            //display_dictObj1(dictObj1);

            //return maximum value in key
            Console.WriteLine(dictObj1.Max(x => x.Key));

            //return minimum value in value
            Console.WriteLine(dictObj1.Min(x => x.Value));

            //convet dictionary to list
            List<KeyValuePair<int,string>> myList = dictObj1.ToList();

        }

        public void display_dictObj1(Dictionary<int,string> dict)
        {
            Parallel.ForEach(dict, item =>
            {
                Console.WriteLine(item.Key + " " + item.Value);
            });
             
        }
    }
}
