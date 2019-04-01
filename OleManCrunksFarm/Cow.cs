using System;

namespace OleManCrunksFarm
{
    internal class Cow
    {
        int Cows = 0;
        int Milk = 0;
        public Cow()
        {
            //Feed();
            //Reproduce();
            //ProduceMilk();
            //Live();
        }

        private void Feed()
        {
            Console.WriteLine("Feed cows");
        }

        private void Reproduce()
        {
            Cows++;
        }

        private void ProduceMilk()
        {
            Milk += Cows;
        }

        public void Live()
        {
            Feed();
            Reproduce();
            ProduceMilk();
        }
    }
}