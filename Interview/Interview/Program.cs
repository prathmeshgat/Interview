﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview
{
    class Program
    {
        static void Main(string[] args)
        {
            //DynamicArray testArray = new DynamicArray();
            //testArray.demo();

            //StringBuilderDemo teStringBuilderDemo = new StringBuilderDemo();
            //teStringBuilderDemo.demo();

            //string input = Console.ReadLine(); 
            //UniqueCharacterString testUniqueCharacterString = new UniqueCharacterString(input);
            //if(testUniqueCharacterString.isunique2())
            //    Console.WriteLine("String has each character unique");
            //else
            //    Console.WriteLine("String does not have unique characters");

            //Console.Read();

            //string input1 = Console.ReadLine();
            //string input2 = Console.ReadLine();
            //StringPermutationCheck testPermutationCheck = new StringPermutationCheck(input1,input2);
            //if (testPermutationCheck.PermutationCheck())
            //    Console.WriteLine("Permutation Strings");
            //else
            //    Console.WriteLine("No Permutation");

            //Console.Read();

            URLify testUrLify = new URLify("b gzv        ", 7);
            Console.WriteLine(testUrLify.modify());

            Console.Read();
        }
    }
}
