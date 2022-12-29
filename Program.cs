using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        { Console.WriteLine("the prime numbers");
            Console.WriteLine("enter n1");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter n2");
            int n2 = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int k = n1; k <= n2; k++) 
            {
              
                for (int q = 1; q <= K; q++) 
                {
                    if (k % q == 0) 
                    sum++;
                }
                if (sum == 2)
                {
                    Console.WriteLine(a);
                    sum = 0;
                }
                else
                {
                    sum = 0;
                    continue;
                }


                //project2
                int n1, n2;
                Console.WriteLine("enter n1");
                int n1 = int.Parse(Console.ReadLine());
                Console.WriteLine("enter n2");
                int n2 = int.Parse(Console.ReadLine());
                int i, sum;
                for (int e = n1; e <= n2; e++) ;
                {
                    i = 1;
                    sum = 0;
                    while (i < e)
                    {
                        if (e % i == 0) ;
                        sum = sum + i;
                        i++;
                    }

                    if (sum == e) ;
                    Console.WriteLine("{0},e");
                }
            
            
            
            
            
            
            
            
            
            }
    
        
        
        
        
        
        
        
        
        
        
        
        }
}
//project 2 
