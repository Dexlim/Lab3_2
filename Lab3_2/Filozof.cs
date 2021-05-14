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
                Console.WriteLine($"Filozof[{id}]");
                Thread.Sleep(1000);
            }
        }
    }
}
