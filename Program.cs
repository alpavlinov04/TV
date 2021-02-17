using System;

namespace TV
{
    class Program
    {
        static void Main(string[] args)
        {
            TV TV1 = new TV();
            TV TV2 = new TV("NEO", 64, 32);
            Console.WriteLine(TV1);
            Console.WriteLine(TV2);
            Console.ReadLine();
        }
    }
}
