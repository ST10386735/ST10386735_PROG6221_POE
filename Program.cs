using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10386735_PROG6221_POE
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("please enter recipe name");
            string recipe = Console.ReadLine();

            try
            {
                Console.WriteLine("please enter how many ingredients you will be adding");
                int i = Convert.ToInt32(Console.ReadLine());
                string[] ing = new string[i];
                int[] qty = new int[99];
                string[] mes = new string[99];

                Console.WriteLine("please enter ingredients");
                for (int j = 0; j < i; j++)
                {
                    Console.Write((j + 1) + ".");
                    ing[j] = Console.ReadLine();

                    Console.Write("please enter quantity:");
                    qty[j] = Convert.ToInt32(Console.ReadLine());

                    Console.Write("please enter measurement:");
                    mes[j] = Console.ReadLine();
                }
                Console.WriteLine("please enter the number of steps");
                int s = Convert.ToInt32(Console.ReadLine());
                string[] stp = new string[99];
                Console.WriteLine("please enter the steps");
                for (int j = 0; j < s; j++)
                {
                    Console.Write((j + 1) + ".");
                    stp[j] = Console.ReadLine();
                }
            


            for (int j = 0; j <= i; j++)
            {
                Console.WriteLine("ingredients :" + ing[j]);
                Console.WriteLine("quantity :" + qty[j]);
                Console.WriteLine("measurement :" + mes[j]);

            }
                
            for (int j = 0; j < s; j++)
            {
                    Console.WriteLine("step"+j+" :"+ stp[j]);
            }
            Console.WriteLine("would you like to scale the ingredients quantities\n"
                +"please select :\n"
                +"1. x0.5\n" +
                "2. x2\n"+
                "3. x3");
                int input = Convert.ToInt32(Console.ReadLine());
                if (input == 1)
                {
                    for (int j = 0; j < i; j++)
                    {
                        Console.WriteLine("ingredients :" + ing[j]);
                        Console.WriteLine("quantity :" + (qty[j]/2));
                        Console.WriteLine("measurement :" + mes[j]);
                    }
                }else if (input == 2)
                {
                    for (int j = 0; j < i; j++)
                    {
                        Console.WriteLine("ingredients :" + ing[j]);
                        Console.WriteLine("quantity :" + (qty[j] * 2));
                        Console.WriteLine("measurement :" + mes[j]);
                    }
                }
                else
                {
                    for (int j = 0; j < i; j++)
                    {
                        Console.WriteLine("ingredients :" + ing[j]);
                        Console.WriteLine("quantity :" + (qty[j] * 3));
                        Console.WriteLine("measurement :" + mes[j]);
                    }
                }
        } 
            catch (FormatException e)
            {
                Console.WriteLine("incorrect!!");
            }
            
            
           
                Console.ReadKey();
            
        }
    }
}