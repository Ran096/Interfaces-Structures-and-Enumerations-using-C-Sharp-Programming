using System;

namespace Interfaces__Structures__and_Enumerations_using_C_Sharp
{
    /*
    public interface ISeries
    {
        int GetNext();
        void Reset();
        void SetStart(int x);
    }
    
    public class ByTwo : ISeries
    {
        int start;
        int val;
     public ByTwo()
        {
            start = 0;
            val = 0;
        }
        public int GetNext()
        {
            val += 2;
            return val;
        }
        public void Restart()
        {
            val = start;
        }
        public void SetStart(int x)
        {
            start = x;
            val = start;
        }
    }
    public class InterfaceExmple
    {
        public static void Main()
        {
            ByTwo ob = new ByTwo();
            for(int i= 0; i<5;i++)
            {
                Console.WriteLine(" Next Value Is " + ob.GetNext());
            }
            Console.WriteLine("Restart Setting ");
            ob.Restart();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(" Next Value Is " + ob.GetNext());
            }
            Console.WriteLine("\nStarting at 100");
            ob.SetStart(100);
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Next value is " +
                ob.GetNext());
            }
        }
    
    public class Primes:ISeries
    {
        int val;
        int start;
       
        public Primes()
        {
            val = 2;
            start = 2;
           
        }
        public int GetNext()
        {
            int i, j;
            bool isprimes;
            val++;
            for(i=val;i<200;i++)
            {
                isprimes = true;
                for (j = 2; j <= i / j; j++)
                {
                    if ((i % j) == 0)
                    {
                        isprimes = false;
                        break;
                    }
                }
                if(isprimes)
                {
                    val=i ;
                    break;
                }
            }
            return val;
        }
            public void Reset()
            {
              val = start;
            }
           public void SetStart(int x)
           {
               start = x;
               val = start;
            }
        public static void Main()
        {
            Primes ob = new Primes();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(" Next Value Is " + ob.GetNext());
            }
            Console.WriteLine("Restart Setting ");
            ob.Reset();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(" Next Value Is " + ob.GetNext());
            }
            Console.WriteLine("\nStarting at 100");
            ob.SetStart(100);
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Next value is " +
                ob.GetNext());
            }
        }
    */
    // Use a property in an interface.
    /*
    public interface ISeries
    {
       int Next
        { 
        get;
        set;
        }
    }
    public class ByTwo:ISeries
    {
        int val;
        public ByTwo()
        {
            val = 0;
        }
       public int Next
        {
            get
            {
                val += 2;
                return val;
            }
            set
            {
                val = value;
            }
        }
    }
    class SeriesDemo
    {
        public static void Main()
        {
            int i;
            ByTwo ob = new ByTwo();
            for( i=0;i<5;i++)
            {
                Console.WriteLine("Next Number Is " + ob.Next);
            }
            Console.WriteLine("Strating is 21");
            ob.Next = 20;
            for( i=0;i<5;i++)
            {
                Console.WriteLine("Starting  New Value 21 " + ob.Next);
            }
        }
    }
  
    // Add an indexer in an interface.
    public interface ISeries
    {
        int Next
        {
            get;
            set;
        }
        int this[int indexer]
        {
            get;
        }
    }
    public class ByTwo : ISeries
    {
        int val;
        public ByTwo()
        {
            val = 0;
        }
        public int Next
        {
            get
            {
                val += 2;
                return val;
            }
            set
            {
                val = value;
            }
        }
            public int this[int indexer]
            {
                get
                {
                int val = 0, i;
                for(i=0;i< indexer; i++)
                {
                    val += 2;
                }
                return val;
                }
        
             }
    }
   
    class indexerDemo
    {
        public static void Main()
        {
            int i;
            ByTwo ob = new ByTwo();
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("Next Number Is " + ob.Next);
            }
            Console.WriteLine("Strating is 21");
            ob.Next = 20;
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("Starting  New Value 21 " + ob.Next);
            }
            Console.WriteLine("Restarting Number");
            ob.Next = 2;
            Console.WriteLine("Restarting Value Number", +ob.Next);
            for (i = 0; i < 5; i++)     
            {
                Console.WriteLine("Starting  New Value 21 " + ob[i]);
            }
        }
    }

    // One interface can inherit another.
    public interface OneInterface
    {
        void Method1();
        void Method2();
    }
    public interface TwoInterface:OneInterface
    {
        void Method3();
    }
    public class InterfaceInhert:TwoInterface
    {
       public void Method1()
        {
            Console.WriteLine("Called Method  One");
        }
      public  void Method2()
        {
            Console.WriteLine("Called Method  Two");
        }
       public void Method3()
        {
            Console.WriteLine("Called Method  Three");
        }

    }
    public class InterfaceDemo
    {
        public static void Main()
        {
            InterfaceInhert ob = new InterfaceInhert();
            ob.Method1();
            ob.Method2();
            ob.Method3();

        }
    }
    
    // Explicitly implement an interface member.
     public interface IEven
    {
        public bool IsOdd(int x);
        public bool IsEven(int x);
    }
    public class MyClass : IEven
    {
        bool IEven.IsOdd (int x)
        {
            if((x%2)!=0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
       public bool IsEven(int x)
        {
            IEven o = this;
            return !o.IsOdd(x);
        }
    }
    class EvenOddDemo
    {
        public static void Main()
        {
            MyClass ob = new MyClass();
            bool result;
            result = ob.IsEven(5);
            if(result)
            {
                Console.WriteLine("4 Is even Number");
            }
            IEven iref = (IEven) ob;
            result= iref.IsOdd(3);
            if(result)
            {
                Console.WriteLine("3 Is Odd Number");
            }

        }
    }
          
    // Demonstrate a structure.
    struct Book
    {
        public string Author_Name;
        public string Title_Name;
        public int copyright;
        public Book(string A,string T,int  C)
        {
            Author_Name = A;
            Title_Name = T;
            copyright = C;
        }

    }
    class structDemo
    {
        public static void Main()
        {
            Book book1 = new Book("Herb Schildt", " C# 4.0: The Complete reference ", 2010);
            Book book2 = new Book();
            Book book3;
            Console.WriteLine("Authoe Name Is :" + book1.Author_Name+ "\nBook Title Name " + book1.Title_Name+ "\nBook Copyright:" + book1.copyright);
            Console.WriteLine();

            if(book2.Title_Name==null)
            {
                Console.WriteLine("Book2 Title Is Null");

            }
            book2.Title_Name = "Brave New World";
            book2.Author_Name = "Aldous Huxley";
            book2.copyright = 1992;
            Console.WriteLine("Book 2 Title Name is :"+book2.Title_Name+ "\nBook2 Author Name Is:" + book2.Author_Name+"\nBook2 Copyrigth Son:"+book2.copyright);
            book3.Title_Name= "Red Storm Rising";
            Console.WriteLine("Book 3 Title Name is " + book3.Title_Name);
        }
    }
    
    // Demonstrate an enumeration.
    class EnumDemo
    {
        enum Apple {
            Jonathan, GoldenDel, RedDel, Winesap,
            Cortland, McIntosh
        }
        public static void Main()
        {
            string[] color = {"Red","Yellow","Red","Black","Green","Gray","Red"};

            Apple i;
            for(i=Apple.Jonathan;i<=Apple.McIntosh;i++)
            {
                Console.WriteLine(i + "has value of " + (int)i);
            }
            Console.WriteLine();
            for(i=Apple.Jonathan;i<=Apple.McIntosh;i++)
            {
                Console.WriteLine("Color of  " + i + "is\t" + color[(int)i]);
            }
        }
    }
   
    // Simulate a conveyor belt.
    class ConveyorContronal
    {
       public enum  Action {Start,Stop,Forword,Reverse };
      public void Convey(Action Com)
      {
        switch (Com)
        {
            case Action.Start:
                Console.WriteLine("starting Case");
                break;
            case Action.Stop:
                Console.WriteLine("Stop Case");
                break;
            case Action.Forword:
                Console.WriteLine("Forword Case");
                break;
            case Action.Reverse:
                Console.WriteLine("Reverse Case");
                break;
        }
      }
    }
    class CoveryorDemo
    {
        public static void Main()
        {
            ConveyorContronal ob = new ConveyorContronal();
            ob.Convey(ConveyorContronal.Action.Start);
            ob.Convey(ConveyorContronal.Action.Forword);
            ob.Convey(ConveyorContronal.Action.Reverse);
            ob.Convey(ConveyorContronal.Action.Stop);
        }
    }
 
    // Demonstrate exception handling.
    class ExceptionHandlimg
    {
        public static void Main()
        {
            int[] nums = new int[8];

            Console.WriteLine("Before exception is generated ");
            try
            {
                for(int i=0;i<10;i++)
                {
                    nums[i] = i;
                    Console.WriteLine("nums[{0}]: {1}", i, nums[i]);
                }
            }
            catch(IndexOutOfRangeException)
            {
                Console.WriteLine(" Index Out Of Range exexption");
            }
            Console.WriteLine("After Catch Black");

        }
    }
    
 //An exception can be generated by one
 //method and caught by another. 
      
    class Extest
    {
        public static void Genreted()
        {
            int[] nums = new int[4];
            Console.WriteLine("Before exception is generated");
            for(int i=0;i<10;i++)
            {
                nums[i] = i;
                Console.WriteLine("nums[{0}]: {1}", i, nums[i]);
            }
            Console.WriteLine("This wont Displayed");
        }
    }
    class ExTestDemo
    {
        public static void Main()
        {
            try
            {
                Extest.Genreted();
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("Index Out Of Range exexption");
            }
            Console.WriteLine("After Catch Black ");
        }
    }

    // Handle error gracefully and continue.
    class GraceFulDemo
    {
        public static void Main()
        {
            int[] number = { 4, 8, 16, 32, 64, 128,256,248,4,8, };
            int[] domen = { 2, 0, 4, 4, 0, 8 };
            Console.WriteLine(" Gracefully And Coutinue");
            for(int i=0;i<number.Length;i++)
            {
                try
                {
                    Console.WriteLine("Number Value is\t" + number[i]+ "Domon Value is\t " + domen[i]+"Divided Value\t "+number[i]/ domen[i]);
                }
                catch(IndexOutOfRangeException)
                {
                    Console.WriteLine("Can't divide by Zero!");
                }
                
                
             catch
                {
                    Console.WriteLine("No matching element found");
                }
            }
        }
    }
    
    class Throwing
    {
        public static void Main()
        {
            Console.WriteLine("Starting  Throw ");
            try
            {
                Console.WriteLine("Befor Throw");
               
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("Execptions catch");
                throw;
            }
            Console.WriteLine("After try / Catch Statement");
            
        }
    }
      
    // Used in Finally Keyword 
    using System;

    class UseFinally
    {
        public static void GenException(int what)
        {
            int t;
            int[] num = new int[2];
            Console.WriteLine("Receiving Is : " + what);
            try
            {
                switch(what)
                {
                    case 0:
                        t = 10/what;
                        break;
                    case 1:
                        num[4]= 4;
                        break;
                    case 2:
                        return;

                }
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("Can't divide by Zero!");
                return;
            }
            catch(IndexOutOfRangeException)
            {
                Console.WriteLine("No matching element found");
            }
            finally
            {
                Console.WriteLine("Leaveing try Black");
            }

        }
    }
    class FinallyDemo
    {
      public static void Main()
        {
            int i;
            for(i=0;i<10;i++)
            {
                UseFinally.GenException(i);
                Console.WriteLine();
            }
        }
    }

    // Use the NullReferenceException.
    class X
    {
        int y;
        public X(int a)
        {
            y = a;
        }  
    
    public int Add(X o)
     {
        return y + o.y;

     }
    }
    class NREDome
    {
        public static void Main()
        {
            X p = new X(10);
            X q = null;
            int val;

            try
            {
                val = p.Add(q);
            }
            catch(NullReferenceException)
            {
                Console.WriteLine("NullReferenceException");
                Console.WriteLine("Flexing");
                q = new X(10);
                val = p.Add(q);
            }
            Console.WriteLine("val is {0}", val);

        }   
    } 
        */// Using checked and unchecked.
    class CheckAndUnchecked
    {
        public static void Main()
        {
            byte a, b, result;
            a = 127;
            b = 127;
            try
            {
                result = unchecked((byte)(a * b));
                Console.WriteLine("Unchecked Execption" + result);
                result = checked((byte)(a * b));
                Console.WriteLine("Checked Execption" + result);
            }
            catch(OverflowException exc)
            {
                Console.WriteLine(exc);
            }
        }
    }
}
