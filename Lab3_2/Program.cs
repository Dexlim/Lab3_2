using System;

namespace Lab3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dane semafory = new Dane();
            var Filozofowie = new Laboratorium3_2(semafory);
            Filozofowie.Run();
        }
    }
}
