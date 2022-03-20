using System;

namespace FactorialUpperBound
{
    class Program
    {
      
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Your Upper Bound Value");
            int UpperboundValue = Int32.Parse(Console.ReadLine());
            
            for (int i = 1; i <= UpperboundValue; i++)
            {
                 int fact = 1;
                for (int j = 1; j <=i; j++)
                {
                    
                       fact = fact * j; 

                }
                Console.WriteLine("{0},   {1}", i, fact);

            }
            






        }
    }
}
