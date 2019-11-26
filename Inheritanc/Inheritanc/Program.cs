using System;


namespace Inheritanc
{
    public class BaseClass
    {
        public virtual void DoWork() {
            Console.WriteLine("This Is virtual Base Class method Dowork.");
        }
        public virtual int WorkProperty
        {
            get{ return 0; }
        }

        public virtual void DoNotWork(int a)
        {
            Console.WriteLine("THis is virtual Base Class method DoNotWork");
        }
    }

    public class DerivedClass : BaseClass
    {
        public override void DoWork()
        {
            Console.WriteLine("This is override child class method DoWork.");
        }
        public override int WorkProperty
        {
            get { return 1; }
        }

        public override void DoNotWork(int a)
        {
            Console.WriteLine("This is override child class method DONotWork.\n Value of integer a is {0}: ",a);
        } 

        public void DoNotWork(char a)
        {
            Console.WriteLine("This is new child class method DONotWork.\n Value of char a is {0}: ", a);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BaseClass B = new BaseClass();
            DerivedClass D = new DerivedClass();
            BaseClass BD = new DerivedClass();
            B.DoWork();
            B.DoNotWork(2);
            Console.WriteLine(B.WorkProperty);
            D.DoWork();
            D.DoNotWork('4');
            Console.WriteLine(D.WorkProperty);
            BD.DoWork();
            BD.DoNotWork(3);
            Console.WriteLine(BD.WorkProperty);
            Console.ReadKey();
        }
    }
}
