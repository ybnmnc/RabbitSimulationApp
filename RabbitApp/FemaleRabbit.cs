using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RabbitApp
{
   public class FemaleRabbit : Rabbit
    {
        private int timeofPregnancy;
        private int loseofFertility;
        private bool isPregnant;

        public FemaleRabbit()
        {
            this.lifetime = Statistics.femalelifetime;
            this.loseofFertility = Statistics.loseofFertility;
            this.timeofPregnancy = Statistics.timeofPregnancy;
            this.age = 0;
            this.isPregnant = false;
        }

        public FemaleRabbit(int lifetime,int loseofFertility, int timeofPregnancy,bool isPregnant)
        {
            this.lifetime = lifetime;
            this.loseofFertility = loseofFertility;
            this.timeofPregnancy = timeofPregnancy;
            this.isPregnant = isPregnant;

        }

        public int getTimeofPregnant()
        {
            return timeofPregnancy;
        }


        public void setTimeofPregnant(int timeofPregnancy)
        {
            this.timeofPregnancy = timeofPregnancy;
        }


        public int getLoseOfFertility()
        {
            return loseofFertility;
        }

        public void SetLoseofFertility(int loseOfFertility)
        {
            this.loseofFertility = loseOfFertility;
        }

        public Boolean getIsPregnant()
        {
            return isPregnant;
        }
        
        public void setIsPregnant(bool ispregnant)
        {
            this.isPregnant = ispregnant;
        }
    }
}
