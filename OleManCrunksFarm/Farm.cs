using System;

namespace OleManCrunksFarm
{
    internal class Farm
    {
        Chicken chicken = new Chicken();
        Rabbit rabbit = new Rabbit();
        Horse horse = new Horse();
        Cow cows = new Cow();
        int NewDay;
        
        public Farm() { }
 
        
        internal void Run()
        {            
            OneDay();
        }

        private void OneDay()
        {
            chicken.live();
            //Console.WriteLine(chicken.Eggs());
            horse.Live();
            rabbit.Live();
            cows.Live();
            FeedAnimals();
           
        }

        private void FeedAnimals()
        {
          
            NewDay++;
            horse.Eat();

        }
    }
}