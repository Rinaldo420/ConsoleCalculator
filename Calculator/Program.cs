using System;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Calculator
{
    internal static class Program
    {
         static char[] Operators = new[]{ '+', '-', '*', '/' };
         static int[] _numbers = new int[]{};
        
        private static void Main(string[] args)
        {
            string line = Console.ReadLine();
            string[] splits = line.Split(' ');

            foreach (var split in splits)
            {
                if (int.TryParse(split, out var re))
                {
                    int num = int.Parse(split);
                    _numbers = new int[] {num};

                }else if (split.Length==1 && Operators.Contains(split.First()))
                {
                    char.Parse(split);
                    
                }else
                {
                    Console.WriteLine("Wrong Input");
                }
                
            }
            for(k = 1; )
            Console.WriteLine(_numbers);
        }
    }
}