using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryProject
{
    class AnimalFactory
    {
        public IAnimal viewAnimal(string animalType, string username)
        {
            IAnimal a;
            if (String.Compare(animalType, "Dog", true) == 0)
            {
                a = new Dog(username);
            }
            else if (String.Compare(animalType, "Cat", true) == 0)
            {
                a = new Cat(username);
            }
            else if (String.Compare(animalType, "Mouse", true) == 0)
            {
                a = new Mouse(username);
            }
            else if (String.Compare(animalType, "Chicken", true) == 0)
            {
                a = new Chicken(username);
            }
            else
            {
                a = new Pig(username);
            }

            return a;
        }
    }
}
