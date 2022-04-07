using System;

namespace BitMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            
            BigMatrix m = new BigMatrix(4);
            Console.WriteLine(m);
            Console.WriteLine(m[2,2]);
            m[2, 2] = true;
            Console.WriteLine(m);
        }
    }
}
