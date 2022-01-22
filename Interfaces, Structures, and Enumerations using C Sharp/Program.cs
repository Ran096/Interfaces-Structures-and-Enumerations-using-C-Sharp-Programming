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
}
    
