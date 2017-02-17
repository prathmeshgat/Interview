using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview
{
    class Searching
    {
        public void binarySearch()
        {
            int[] nums = new int[]{1,2,6,10,12,13,14,15,20,24,25,27,29,30,45,47,49,70,73,74,76 };
            int min = 0;
            int max = nums.Length - 1;

            Console.WriteLine(binarysearchRecursion(nums,min,max,70));

        }

        public int binarysearchRecursion(int[] nums,int min,int max,int value)
        {
            Console.WriteLine("INSIDE");
            int position = (min + max) / 2;

            if (min< 0 || min>(nums.Length - 1) || max<0 || max> (nums.Length - 1))
                return -1;

            if (nums[position] == value)
                return position;

            if (nums[position] < value)
                return binarysearchRecursion(nums,position+1,max,value);

            if(nums[position]>value)
                return binarysearchRecursion(nums, min, position-1, value);
           
            return -1;
        }
    }
}
