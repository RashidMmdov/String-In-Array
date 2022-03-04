using System;

namespace String_in_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String[] world = { "Rashid", "Ali", "BaxisAli", "Bahadur", "Tural" };
            for(int i = 0; i < world.Length; i++)
            {
                if(world[i].Length > 5)
                {
                    Console.WriteLine(world[i]);
                }
               
            }
        }
    }
}
