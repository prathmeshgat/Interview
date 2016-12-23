using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview
{
    public class DynamicArray
    {
        private List<int> mylist;
        private int[] array = new int[] { 5,6,0,4,2,5,1,0,0,0};
        private List<string> pathList;

        public DynamicArray()
        {
            mylist = new List<int>();
        }

        public void demo()
        {
            for (int i = 0; i < 10; i++)
            {
                mylist.Add(i);
            }
            for (int i=0;i < mylist.Count;i++)
            {
                Console.WriteLine(mylist[i]);
            }

            Console.Read();
        }

        public string recursion(int startIndex, string path)
        {
            if (startIndex<array.Length && array[startIndex] == 0)
                return "Fail";

            if (startIndex > (array.Length - 1))
            {

                string[] splitArray = path.Split(',');
                splitArray[splitArray.Length - 1] = null;
                foreach (var item in splitArray)
                    path += item + ", ";

                pathList.Add("0, "+ path);
                return "Success";
            }
            if (startIndex == (array.Length - 1))
            {
                pathList.Add("0, " + path);
                return "Success";
            }


            for (int j = startIndex + 1; j <= startIndex + array[startIndex]; j++)
            {
                recursion(j, path + ", "+j);
            }
            return path;
        }

        public void test()
        {
            pathList = new List<string>();
            Console.WriteLine(recursion(0, ""));
            

            string finalPath= string.Empty;
            foreach (var item in pathList)
            {
                if (string.IsNullOrEmpty(finalPath))
                {
                    finalPath = item;
                }
                else
                {
                    if (finalPath.Length > item.Length)
                        finalPath = item;
                }
            }

            Console.WriteLine(finalPath);
            Console.ReadLine();
        }

           
    }
}
