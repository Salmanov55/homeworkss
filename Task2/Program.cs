using System;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "Salam";
            int count = 0;
            for (int i = 0; i < str .Length; i++)
            {
                if (str[i] == 'a')
                {  
                  count++;
                }
                   
                    Console.WriteLine(count);
            }
        }
    }
}
