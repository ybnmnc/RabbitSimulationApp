using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RabbitApp
{
    public abstract class Rabbit
    {
        protected int lifetime;
        protected int age;

        public int getAge()
        {
            return age;
        }

        public void setAge(int age)
        {
            this.age = age;
        }

        public int getLifetime()
        {
            return lifetime;
        }

        public void setLifeTime(int lifetime)
        {
            this.lifetime = lifetime;
        }


    }
}
