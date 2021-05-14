using System.Threading;

namespace Lab3_2
{
    class Filozof
    {
        private Thread watek;

        public Filozof()
        {
            this.watek = new Thread(FunkcjaWatku);
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

        }
    }
}
