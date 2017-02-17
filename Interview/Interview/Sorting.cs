using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview
{
    public class Sorting
    {
        public void bubbleSort()
        {
            //O(n2) time complexicity
            int[] nums = new int[] { 6, 5, 4, 3, 2, 1 };
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 1; j < nums.Length - i; j++)
                {
                    if (nums[j - 1] > nums[j])
                    {
                        int temp = nums[j];
                        nums[j] = nums[j - 1];
                        nums[j - 1] = temp;
                    }
                }
            }

            foreach (var item in nums)
                Console.WriteLine(item);
        }

        public void selectionSort()
        {
            int[] nums = new int[] { 2, 4, 3, 134, 4, 3, 3, 9 };
            for (int i = 0; i < nums.Length; i++)
            {
                int minKeyIndex = i;
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[j] < nums[minKeyIndex])
                        minKeyIndex = j;
                }

                if (minKeyIndex != i)
                {
                    int temp = nums[minKeyIndex];
                    nums[minKeyIndex] = nums[i];
                    nums[i] = temp;
                }
            }

            foreach (var item in nums)
                Console.WriteLine(item);
        }

        public void merge_sort()
        {
            int[] nums = new int[] { 2,1,4,7,67,23,5,6,3,74,345,23423,57,234,67,345,67,534,67,35,7788,43243,7688,888,6455,
            2543,7665,44,332,22,888,56,445,55};

            merge_sort_function(nums);

            foreach (var item in nums)
                Console.WriteLine(item);
        }

        private void merge_sort_function(int[] nums)
        {
            int low = 0;
            int high = nums.Length - 1;
            int middle = (low + high) / 2;

            if (low < high)
            {
                int[] arr1 = new int[middle + 1];
                int[] arr2 = new int[high - middle];

                for (int i = 0; i <= middle; i++)
                {
                    arr1[i] = nums[i];
                }

                int count = 0;
                for (int i = middle + 1; i <= high; i++)
                {
                    arr2[count++] = nums[i];
                }

                merge_sort_helper1(arr1);
                merge_sort_helper1(arr2);

                merge(nums, arr1, arr2);
            }
        }
        private void merge(int[] nums, int[] arr1, int[] arr2)
        {
            int pointer1 = 0;
            int pointer2 = 0;
            int counter = 0;

            while (pointer1 < arr1.Length && pointer2 < arr2.Length)
            {
                if (arr1[pointer1] < arr2[pointer2])
                {
                    nums[counter] = arr1[pointer1];
                    pointer1++;
                }
                else
                {
                    nums[counter] = arr2[pointer2];
                    pointer2++;
                }
                counter++;
            }

            while (pointer1 < arr1.Length)
            {
                nums[counter] = arr1[pointer1];
                counter++;
                pointer1++;
            }

            while (pointer2 < arr2.Length)
            {
                nums[counter] = arr2[pointer2];
                counter++;
                pointer2++;
            }

        }
        private void merge_sort_helper1(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 1; j < nums.Length - i; j++)
                {
                    if (nums[j - 1] > nums[j])
                    {
                        int temp = nums[j];
                        nums[j] = nums[j - 1];
                        nums[j - 1] = temp;
                    }
                }
            }
        }

        public void quick_sort()
        {
            int[] nums = new int[] { 2,1,4,7,67,23,5,6,3,74,345,23423,57,234,67,345,67,534,67,35,7788,43243,7688,888,6455,
            2543,7665,44,332,22,888,56,445,55};

            int low = 0;
            int high = nums.Length - 1;

            quickSort(nums, low, high);


            foreach (var item in nums)
                Console.WriteLine(item);

        }

        private void quickSort(int[] nums, int low, int high)
        {
            if (low < high)
            {
                int parttitionIndex = Partition(nums, low, high);
                quickSort(nums, low, parttitionIndex-1);
                quickSort(nums, parttitionIndex + 1, high);
            }
        }

        private int Partition(int[] nums, int low, int high)
        {
            int pivot = nums[low];
            int i = low+1;
            int j = high;

            while (i<j)
            {
                while (nums[i] <= pivot)
                    i++;

                while (j>=i && nums[j] > pivot)
                    j--;

                    int temp = nums[i];
                    nums[i] = nums[j];
                    nums[j] = temp;
               
            }

            int tempP = nums[j];
            nums[j] = pivot;
            nums[low] = tempP;

            return j;
        }


    }
}
