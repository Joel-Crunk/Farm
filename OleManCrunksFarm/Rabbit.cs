using System;

namespace OleManCrunksFarm
{
    internal class Rabbit
    {
        int rabbits = 0;
        public Rabbit()
        {
         
        }
        public void Live()
        {
            Reproduce();
            Sleep();
            Jump();
            Eat();
            Console.WriteLine($" There are {rabbits} rabbits");
        }


        private void Reproduce()
        {
            rabbits++;
        }

        private void Sleep()
        {
            Console.WriteLine("The Rabbits sleep");
        }

        private void Jump()
        {
            Console.WriteLine("The rabbits jump");
        }

        private void Eat()
        {
            Console.WriteLine("Rabbits eat their food");
        }
    }
}