using System.Threading;

namespace Lab3_2
{
    public class Blokada
    {
        public readonly int LICZBA_FILOZOFOW = 5;

        public Semaphore lokaj = new Semaphore(4,4);
        public SemaphoreSlim[] sem;

        public Blokada()
        {
            this.sem = new SemaphoreSlim[LICZBA_FILOZOFOW];
            for(int i = 0; i < LICZBA_FILOZOFOW; i++)
            {
                this.sem[i] = new SemaphoreSlim(1, 1);
            }
        }
    }
}
