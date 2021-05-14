using System;
using System.Threading;

namespace Lab3_2
{
    class Filozof
    {
        private const int CZAS_JEDZENIA = 3000;

        private Thread watek;
        private Blokada semafory;
        private int id;

        public Filozof(Blokada semafory,int id)
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
                ZamknijSemafory();

                Console.WriteLine($"\t\t\t\t\tFilozof[{id}]: je...");
                Thread.Sleep(CZAS_JEDZENIA); 

                OtworzSemafory();
            }
        }

        private void OtworzSemafory()
        {
            semafory.sem[id].Release();
            semafory.sem[(id + 1) % semafory.LICZBA_FILOZOFOW].Release();
            semafory.lokaj.Release();
        }

        private void ZamknijSemafory()
        {
            semafory.lokaj.WaitOne();
            semafory.sem[id].Wait();
            semafory.sem[(id + 1) % semafory.LICZBA_FILOZOFOW].Wait();
        }
    }
}
