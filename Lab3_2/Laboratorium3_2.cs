namespace Lab3_2
{
    class Laboratorium3_2
    {
        Filozof[] filozofowie = new Filozof[5];
        public Laboratorium3_2()
        {
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
