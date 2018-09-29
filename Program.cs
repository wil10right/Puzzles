using System;
using System.Collections.Generic;

namespace Puzzles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Puzzles!");
            // RandoArray();
            // CoinFlip();
            // System.Console.WriteLine(CoinFlip("heads"));
            System.Console.WriteLine(Names());
        }

        public static void RandoArray()
        {
            int min = 0; 
            int max = 0;
            int sum = 0;

            Random rand = new Random();

            int[] arr = new int[10];

            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(5,25);
                System.Console.WriteLine(arr[i]);
                sum = sum + arr[i];
                if(min == 0){
                    min = arr[i];
                }
                if(arr[i]<min)
                {
                    min = arr[i];
                }else if(arr[i]>max)
                {
                    max = arr[i];
                }
            }
            System.Console.WriteLine("Want SUM of this?!? - "+sum);
            System.Console.WriteLine("To the MAX!!! - "+max);
            System.Console.WriteLine("The bare MINimum - "+min);
        }

        public static string CoinFlip(string HeadsOrTails)
        {
            System.Console.WriteLine("Flipping Coin...");
            Random randy = new Random();
            string[] coin = {"heads","tails"};
            string result = coin[randy.Next(0,2)];
            // System.Console.WriteLine(result);
            //min is inclusive, max is exclusive
            if(result == HeadsOrTails)
            {
                System.Console.WriteLine($"{result}! You Win!");
                return result;
            }else{
                System.Console.WriteLine($"{result}! You Lose Sucker!");
                return result;
            }
        }

        public static string[] Names()
        {
            string[] peepls = {"Toddy","Tiffy","Chuckie","Geenie","Sid"};
            Random randy = new Random();
            for(var i = 0; i<peepls.Length; i++)
            {
                int ridx = randy.Next(0,5);
                string temp = peepls[i];
                peepls[i] = peepls[ridx];
                peepls[ridx] = temp;
            }
            return peepls;
        }
    }
}
