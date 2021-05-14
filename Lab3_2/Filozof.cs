using System;
using System.Threading;

namespace Lab3_2
{
    class Filozof
    {
        private Thread watek;
        private Dane semafory;
        private int id;

        public Filozof(Dane semafory,int id)
        {
            this.watek = new Thread(FunkcjaWatku);
            this.semafory = semafory;
            this.id = id;
        }
        public void Start()
        {
            watek.Start();
        }

        public void Join()
        {
            watek.Join();
        }

        private void FunkcjaWatku()
        {
            while (true)
            {
                Console.WriteLine($"Filozof[{id}]: filozofuje...");
                semafory.lokaj.WaitOne();
                semafory.sem[id].Wait();
                semafory.sem[(id + 1) % 5].Wait();
                Console.WriteLine($"\t\t\t\t\tFilozof[{id}]: je...");
                Thread.Sleep(3000); // zakladamy ze filozof je 3 sekundy
                semafory.sem[id].Release();
                semafory.sem[(id + 1) % 5].Release();
                semafory.lokaj.Release();
            }
        }
    }
}
