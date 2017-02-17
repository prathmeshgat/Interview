using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview
{
    class node
    {
        public int data;
        public string name;

        public node(int _d, string _name)
        {
            data = _d;
            name = _name;
        }
    }

    class ListMethodsDemo
    {
        List<node> demoList = new List<node>();
        List<int> demo1List = new List<int>();
        List<string> demo2List = new List<string>();

        public void DEMO_OBJ()
        {
            //add
            demoList.Add(new Interview.node(10, "one"));
            demoList.Add(new Interview.node(12, "two"));
            demoList.Add(new Interview.node(14, "three"));
            demoList.Add(new Interview.node(15, "four"));
            demoList.Add(new Interview.node(17, "five"));
            demoList.Add(new Interview.node(20, "six"));

            //retrive
            node temp1 = demoList.Find(x => x.data == 21);
            if (temp1 == null)
                Console.WriteLine("not found");


            //contains it checks by reference
            if (demoList.Contains(demoList[0]))
                Console.WriteLine("found");
            else
                Console.WriteLine("not found");

            //Min
            Console.WriteLine("MINIMUM ELEMENT::"+ demoList.Min(x => x.data).ToString());

            //Max
            Console.WriteLine("MAXIMUM ELEMENT::"+ demoList.Max(x => x.data).ToString());

            //COUNT
            Console.WriteLine("NO ELEMENT::"+demoList.Count);

            //delete
            demoList.RemoveAt(0);
            Console.WriteLine("Removed first element");
            display_objLis(demoList);

            //reverse
            demoList.Reverse();
            Console.WriteLine("Reversed");
            display_objLis(demoList);

            //sort ascending
            Console.WriteLine("Sorted");
            demoList = demoList.OrderBy(x => x.data).ToList();
            display_objLis(demoList);

            //sort descending
            Console.WriteLine("Sorted");
            demoList = demoList.OrderByDescending(x => x.data).ToList();
            display_objLis(demoList);
        }

        public void DEMO_INTLIST()
        {
            //add
            demo1List.Add(10);
            demo1List.Add(12);
            demo1List.Add(17);
            demo1List.Add(20);
            demo1List.Add(14);
            demo1List.Add(15);


            //retrive
            Console.WriteLine(demo1List.Find(x => x == 10));


            //contains
            if (demo1List.Contains(10))
                Console.WriteLine("found");
            else
                Console.WriteLine("not found");

            //Min
            Console.WriteLine("MINIMUM ELEMENT::" + demo1List.Min().ToString());

            //Max
            Console.WriteLine("MAXIMUM ELEMENT::" + demo1List.Max());

            //COUNT
            Console.WriteLine("NO ELEMENT::" + demo1List.Count);

            //delete
            demo1List.RemoveAt(0);
            Console.WriteLine("Removed first element");
            display_intLis(demo1List);

            //reverse
            demo1List.Reverse();
            Console.WriteLine("Reversed");
            display_intLis(demo1List);

            //sort asc
            Console.WriteLine("Sorted");
            demo1List = demo1List.OrderBy(x=>x).ToList();
            display_intLis(demo1List);

            //sort desc
            Console.WriteLine("Sorted");
            demo1List = demo1List.OrderByDescending(x => x).ToList();
            display_intLis(demo1List);
        }

        public void DEMO_STRINGLIST()
        {
            demo2List.Add("one");
            demo2List.Add("two");
            demo2List.Add("three");
            demo2List.Add("four");

            //find
            Console.WriteLine(demo2List.Find(x=> x=="two"));

            //Find Element Index
            Console.WriteLine("Element is at position position::" + demo2List.FindIndex(x => x == "two"));

            //contains
            if (demo2List.Contains("five"))
                Console.WriteLine("Element present");
            else
                Console.WriteLine("Element Not present");

            //Min
            Console.WriteLine("Minimum element in list::"+demo2List.Min());

            //Max
            Console.WriteLine("Maximim Element in list::"+ demo2List.Max());

            //First Element
            Console.WriteLine("First Element in List::"+demo2List.First());

            //Last Element
            Console.WriteLine("Last Element in List::"+demo2List.Last());

            //Count
            Console.WriteLine("No Of Elements in List::"+demo2List.Count);

            //delete element at index
            demo2List.RemoveAt(3);
            display_stringLis(demo2List);

            //Reverse the List
            demo2List.Reverse();
            display_stringLis(demo2List);

            //sort Asc
            demo2List = demo2List.OrderBy(x=> x).ToList();
            display_stringLis(demo2List);

            //sort Desc
            demo2List = demo2List.OrderByDescending(x=> x).ToList();
            display_stringLis(demo2List);
        }

        public void display_objLis(List<node> lis)
        {
            foreach (var item in lis)
                Console.WriteLine(item.data);
        }

        public void display_intLis(List<int> lis)
        {
            foreach (var item in lis)
                Console.WriteLine(item);
        }

        public void display_stringLis(List<string> lis)
        {
            foreach (var item in lis)
                Console.WriteLine(item);
        }
    }

}
