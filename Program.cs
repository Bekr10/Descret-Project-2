using System;

namespace Ahmed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            Console.WriteLine("Get All Perfect Numbers In Range Of Between Two numbers");
            Console.Write("Enter The Starting Number :");
            x = int.Parse(Console.ReadLine());
            Console.Write("enter the Ending Number :");
            y = int.Parse(Console.ReadLine());

            Console.WriteLine("Below are the perfect number between" + x + "and" + y);

            for (int Z = x; Z <= y; Z++) 
            {
                decimal sum = 0;
                for (int j = 1; j < Z; j++) 
                {
                    if ( Z % j == 0) 
                    sum = sum + j;
                }
                    if (sum == Z) 
                    Console.WriteLine("\t" + Z);
            }    
            Console.ReadKey();
        }
    }
}
