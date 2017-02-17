using System;
using System.Collections.Generic;
using System.Globalization;
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

            ListMethodsDemo tdemo = new ListMethodsDemo();
            //tdemo.DEMO_INTLIST();
            //tdemo.DEMO_OBJ();
            //tdemo.DEMO_STRINGLIST();
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

            //LinkedList<int> teo = new LinkedList<int>();
            //teo.AddLast(10);

            //teo.RemoveLast();

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
            //Stack<int> mystack = new Stack<int>();

            //mystack.Push(100);
            //mystack.Push(200);
            //Console.WriteLine(mystack.Pop());
            //mystack.Min();
            //StackOperations<int> testStackOperations = new StackOperations<int>();
            //try
            //{
            //    testStackOperations.push(1);
            //    testStackOperations.push(2);
            //    testStackOperations.push(3);
            //    testStackOperations.push(4);

            //    testStackOperations.pop();
            //    testStackOperations.pop();
            //    testStackOperations.pop();
            //    Console.WriteLine(testStackOperations.peek());
            //    testStackOperations.display();
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            #endregion

            #region Queue

            //QueueOperations<int> myQueueOperations = new QueueOperations<int>();

            //myQueueOperations.Add(10);
            //myQueueOperations.Add(20);
            //myQueueOperations.Add(30);
            //myQueueOperations.Add(40);

            //Console.WriteLine(myQueueOperations.remove());
            //Console.WriteLine(myQueueOperations.remove());
            //Console.WriteLine(myQueueOperations.remove());
            //Console.WriteLine(myQueueOperations.remove());
            ////Console.WriteLine(myQueueOperations.remove());

            //Queue<int> tempQ = new Queue<int>();
            //tempQ.Enqueue(7);
            //tempQ.Dequeue();

            #endregion

            /*
            DateTime testTime = Convert.ToDateTime("12/12/2016");
            DateTimeFormatInfo dfi = DateTimeFormatInfo.CurrentInfo;
            Calendar cal = dfi.Calendar;

            Console.WriteLine(testTime);
            string[] myarr = new string[] {"234"};
            Console.WriteLine("");
           */
            #region Singlton pattern

            //SingeltonClass temp1 = SingeltonClass.getInstance();

            //SingeltonClass temp2 = SingeltonClass.getInstance();

            //Console.WriteLine(temp2.name);
            #endregion

            #region static class
            //StaticClassDemo.display();
            #endregion

            #region Function Overloading
            //FunctionOverLoading myTest = new FunctionOverLoading();
            //myTest.setName("Prathmesh");
            //myTest.displayName();

            //myTest.setName("Prathmesh","Gat");
            //myTest.displayName();
            #endregion

            #region inheritance and overiding

            //Derived tempObj = new Derived();
            //tempObj.children_method();
            //tempObj.vir_method2();

            //absDerived tempObg1 = new absDerived();
            //tempObg1.getabsmethod();
            //tempObg1.Disp();


            //sealedClass tempObj2 = new sealedClass();
            //tempObj2.display();

            //inerfaceDervied tempObj3 = new inerfaceDervied();
            //tempObj3.func1();
            //Console.WriteLine(tempObj3.func2());

            #endregion

            #region polymorphism
            //shape tempobj1 = new Square(2);
            //tempobj1.calculateArea();

            //shape tempobj2 = new Rectangle(5, 6);
            //tempobj2.calculateArea();
            #endregion

            #region sorting

            //Sorting mySorting = new Sorting();

            //mySorting.bubbleSort();

            //mySorting.selectionSort();

            //mySorting.merge_sort();

            //mySorting.quick_sort();
            #endregion

            #region searching

            //Searching mysearching = new Searching();

            //mysearching.binarySearch();
            #endregion

            #region dictionary methods
            //DictionaryMethods myDict = new DictionaryMethods();
            //myDict.demoDict1();
            #endregion

            #region 2-d Matrix
            int[,] myMatrix = new int[,] { { 1, 2, 3 }, { 4, 5, 6 } };
            MatrixOperations myMatrixOperations = new MatrixOperations();
            myMatrixOperations.DisplayMatrix(myMatrix);
            
            #endregion

            Console.Read();
        }

    }
}
