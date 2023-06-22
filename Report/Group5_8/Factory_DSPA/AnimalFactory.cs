using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_DSPA
{
    class AnimalFactory
    {
        public Animal viewAnimal(string animalType, string name)
        {
            Animal a;
            if (String.Compare(animalType, "Dog", true) == 0)
            {
                a = new Dog(name);
            }
            else if (String.Compare(animalType, "Cat", true) == 0)
            {
                a = new Cat(name);
            }
            else if (String.Compare(animalType, "Mouse", true) == 0)
            {
                a = new Mouse(name);
            }
            else 
            {
                a = new Pig(name);
            }

            return a;
        }
    }
}
