using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview
{
    #region normal inheritance & function ovveride & hiding function
    class Parent
    {
        string var1;
        internal string var2="test";

        public void parent_mathod()
        {
            var1 = "Arun";
            Console.WriteLine(var1);
        }

        public virtual void vir_method1()
        {
            Console.WriteLine("Base Method1");
        }

        public virtual void vir_method2()
        {
            Console.WriteLine("Base Method2");
        }
    }

    class Derived : Parent
    {
        string var3;
        
        public void children_method()
        {
            var3 = "Prathmesh";
            Console.WriteLine(var2);
        }

        //overiding the inherited method
        public override void vir_method1()
        {
            //base.vir_method1();
            Console.WriteLine("Over Ridden method");
        }

        //hiding the inherited method
        public new void vir_method2()
        {
            //base.vir_method1();
            Console.WriteLine("hiding method");
        }
    }

    #endregion

    #region Inheritance with abstract class
    public class testd
    {
        int x;
        public void Disp()
        {
            Console.WriteLine("fgh");
        }
    }
    public abstract class AbstMethods: testd
    {
        public int x;
        public abstract void getabsmethod();

    }

    public class absDerived:AbstMethods
    {
        public override void getabsmethod()
        {
            Console.WriteLine("abstract derive");
        }
    }

    #endregion

    #region sealed class
    sealed class sealedClass
    {
        int x;

        public void display()
        {
            Console.WriteLine(x);
        }
    }

    #endregion

    #region interface

    public interface myinterface
    {
        void func1();
        int func2();
    }

    class inerfaceDervied:myinterface
    {
        public void func1()
        {
            Console.WriteLine("func1");
        }

        public int func2()
        {
            return 1;
        }
    }
    #endregion

    #region Polymorphism

    public class shape
    {
        public virtual void calculateArea()
        {
            Console.WriteLine("Area Calculator");
        }
        
    }

    public class Square :shape
    {
        double length;
        public Square(double l)
        {
            length = l;
        }
        public override void calculateArea()
        {
            base.calculateArea();
            Console.WriteLine("Area of square::"+(length*length));
        }
    }

    public class Rectangle : shape
    {
        double length;
        double breadth;

        public Rectangle(double l, double b)
        {
            length = l;
            breadth = b;
        }
        public override void calculateArea()
        {
            Console.WriteLine("Area of rectangle::" + (length * breadth));
        }
    }
    #endregion
}
