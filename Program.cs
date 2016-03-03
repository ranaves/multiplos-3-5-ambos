using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    public class Program
    {
        public void Main(string[] args)
        {
        	int n = Convert.ToInt32(Console.ReadLine());

        	if (n <= 100)
        	{
        		for(int i= 1; i <= n; i++) 
        		{
        			if (i % 3 == 0 && i % 5 == 0)
        			    Console.WriteLine("FizzBuzz");
        			else if (i % 3 == 0)
        			    Console.WriteLine("Fizz");
        			else if (i % 5 == 0)
        			    Console.WriteLine("Buzz");
        			else 
        			    Console.WriteLine(i);    	
        		}
        	}
        }             	
    }
}
