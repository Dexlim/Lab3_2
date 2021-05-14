namespace Lab3_2
{
    class Laboratorium3_2
    {
        private Filozof[] filozofowie = new Filozof[5];
        private Dane semafory;

        public Laboratorium3_2(Dane semafory)
        {
            this.semafory = semafory;
            for(int i=0; i < 5; i++)
            {
                filozofowie[i] = new Filozof(semafory, i);
            }
        }

        public void Run()
        {
            foreach(Filozof filozof in filozofowie)
            {
                filozof.Start();
            }
        }
        public void Join()
        {
            foreach(Filozof filozof in filozofowie)
            {
                filozof.Join();
            }
        }
    }
}
