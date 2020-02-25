using System;

namespace notes
// Write a C# Sharp program to that takes three numbers(x,y,z) as input and print the output of (x+y)*z and x*y + y*z.
	//be more precise with your methods descriptive 
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("multiply (x+y)z ? y/n");
            string answer1 = Console.ReadLine(); 
            if(answer1 == "y")
            {
                Console.WriteLine("enter variable x");
                int x = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("enter variable y");
                int y = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("enter variable z");
                int z = Convert.ToInt32(Console.ReadLine());

                Add1 a = new Add1(); 
                //console.writeline your results here after doing the calculation
                Console.WriteLine(a.Sum1(x, y, z));
                
            }
            Console.WriteLine("multiply (x*y)+(y*z) ? y/n");
            string answer2 = Console.ReadLine(); 
            if (answer2 == "y")
            {
                Console.WriteLine("enter variable x");
                int x = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("enter variable y");
                int y = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("enter variable z");
                int z = Convert.ToInt32(Console.ReadLine());

                Add1 b = new Add1();
                //console.writeline your results here after doing the calculation
                Console.WriteLine(b.Sum2(x, y, z));

            }
        }
    }

    public class Add1
    {
        public int Sum1(int x, int y, int z)
        {
           int a = x + y;
           //Don't write result inside of this method
            //Let it have one responsiblity to do the mathematical calculation and return
           //Console.WriteLine(a * z);
            return a * z;
        }
        
        public int Sum2(int x, int y, int z)
        {
            int b = x * y;
            int c = y * z;
            //Don't write result inside of this method
            //Let it have one responsiblity to do the mathematical calculation and return
           // Console.WriteLine(b + c);
            return b + c; 
        }
    }
}