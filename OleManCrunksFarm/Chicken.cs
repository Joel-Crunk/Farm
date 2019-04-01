using System;

namespace OleManCrunksFarm
{
    internal class Chicken
    {
        int Chickens = 0;
        int day = 1;
       

        public Chicken()
        {
            //Reproduce();
        }

        private void Reproduce() => Chickens++;
       

        public void Eggs()
        {
            int i = Chickens;
            int moreEggs = i += day;
            Console.WriteLine($"There are now {moreEggs} eggs");
       
        }

        private void Day()
        {
            Eggs();
            Reproduce();
        }
      
        public void live()
        {
          
            
            Day();
        }
    }
}