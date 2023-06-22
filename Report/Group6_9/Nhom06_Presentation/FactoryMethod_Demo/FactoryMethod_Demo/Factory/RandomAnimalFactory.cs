using FactoryMethod_Demo.Animal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod_Demo.Factory
{
    class RandomAnimalFactory : IAnimalFactory
    {
        public IAnimal CreateAnimal()
        {
            Random random = new Random();
            int type = random.Next(0, 3);
            if (type == 0)
            {
                return new Cat();
            }
            else if(type == 1)
            {
                return new Lion();
            }
            else
            {
                return new Duck();
            }
        }
    }
}
