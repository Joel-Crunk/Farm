using System;

namespace OleManCrunksFarm
{
    internal class Horse
    {
        string Name;
        int Hay = 100;
        int Horses = 0;
      
        public Horse()
        {
            //Reproduce();
            //Sleep();
            //Run();
            //Eat();
           // Live();
        }

        public void Live()
        {
            Sleep();
            Reproduce();
            Eat();
        }

        private void Sleep()
        {
            Console.WriteLine("Horses take a nap");
        }

        private void Reproduce()
        {
            Console.WriteLine("Horses reproduce");
             Horses++;
            Console.WriteLine($"There are now {Horses} horses");
        
        }

        public void Eat()
        {
            Console.WriteLine("Horses eat");
             --Hay;
        }

        public Horse(string name, string speak)
        {
            this.Name = name;
          

       
            name = "Gray";
        }
    

        internal void Run()
        {
            Console.WriteLine("The Horse runs!");
        }

        internal void Work()
        {
            Console.WriteLine("Horse pulls wagon");
        }
        
    }
}