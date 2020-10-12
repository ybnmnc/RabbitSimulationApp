using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RabbitApp
{
   public class MaleRabbit : Rabbit
    {
        public MaleRabbit()
        {
            this.lifetime = Statistics.malelifetime;
            this.age = 0;
        }

        public MaleRabbit(int lifetime,int age)
        {
            this.lifetime = lifetime;
            this.age = age;
        }
    }
}
