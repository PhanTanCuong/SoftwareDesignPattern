using FactoryMethod_Demo.Animal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod_Demo.Factory
{
    class BasicAnimalFactory : IAnimalFactory
    {
        int index = 0;
        public IAnimal CreateAnimal()
        {
            if(index == 0)
            {
                index++;
                return new Duck();
            }
            if(index == 1)
            {
                index ++;
                return new Cat();
            }
            if (index == 2)
            {
                index = 0;
                return new Lion();
            }
            return null;
        }
    }
}
