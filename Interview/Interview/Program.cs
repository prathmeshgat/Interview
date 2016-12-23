using System;
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
            #region Dynamic Array

            //DynamicArray testArray = new DynamicArray();
            //testArray.demo();
            //testArray.test();

            #endregion

            #region String Builder Demo

            //StringBuilderDemo teStringBuilderDemo = new StringBuilderDemo();
            //teStringBuilderDemo.demo();

            #endregion

            #region Unique Character String

            //string input = Console.ReadLine(); 
            //UniqueCharacterString testUniqueCharacterString = new UniqueCharacterString(input);
            //if(testUniqueCharacterString.isunique2())
            //    Console.WriteLine("String has each character unique");
            //else
            //    Console.WriteLine("String does not have unique characters");

            //Console.Read();


            #endregion

            #region Permutation

            //string input1 = Console.ReadLine();
            //string input2 = Console.ReadLine();
            //StringPermutationCheck testPermutationCheck = new StringPermutationCheck(input1,input2);
            //if (testPermutationCheck.PermutationCheck())
            //    Console.WriteLine("Permutation Strings");
            //else
            //    Console.WriteLine("No Permutation");

            //Console.Read();

            #endregion

            #region URLify

            //URLify testUrLify = new URLify("b gzv        ", 7);
            //Console.WriteLine(testUrLify.modify());

            #endregion

            #region LinkedList

            //LinkedListLib testLinkedListLib = new LinkedListLib();

            //testLinkedListLib.Add(3);
            //testLinkedListLib.Add(8);
            //Node temp = testLinkedListLib.Add(3);
            // testLinkedListLib.Add(2);
            //testLinkedListLib.Add(4);
            //testLinkedListLib.Add(1);

            //testLinkedListLib.DisplayList();

            //Console.WriteLine("*************Deleting****************");
            //testLinkedListLib.DeleteFirstOccurance(2);
            //testLinkedListLib.DisplayList();

            //Console.WriteLine("*************kth from last****************");
            //Console.WriteLine(testLinkedListLib.kthElement(3));

            //Console.WriteLine("*************delete given****************");
            //Console.WriteLine(testLinkedListLib.DeleteGivenNode(temp));
            //testLinkedListLib.DisplayList();

            //Console.WriteLine("*************palindrome test****************");
            //Console.WriteLine(testLinkedListLib.isPalindrome());

            //Console.Read();

            //char c = Console.ReadKey().KeyChar;
            //switch (c)
            //{
            //    case 'd':
            //        Console.WriteLine("yay");
            //        break;
            //    default:
            //        Console.WriteLine("fail");
            //        break;
            //}


            #endregion

            #region stack

            StackOperations<int> testStackOperations = new StackOperations<int>();
            try
            {
                testStackOperations.push(1);
                testStackOperations.push(2);
                testStackOperations.push(3);
                testStackOperations.push(4);
                
                testStackOperations.pop();
                testStackOperations.pop();
                testStackOperations.pop();
                Console.WriteLine(testStackOperations.peek());
                testStackOperations.display();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
           
            Console.Read();


            #endregion



        }
        
    }
}
