using System.Threading;

namespace Lab3_2
{
    public class Dane
    {
        public Semaphore lokaj = new Semaphore(4,4);
        public SemaphoreSlim[] sem = new SemaphoreSlim[5];
        public Dane()
        {
            for(int i = 0; i < 5; i++)
            {
                this.sem[i] = new SemaphoreSlim(1, 1);
            }
        }
    }
}
