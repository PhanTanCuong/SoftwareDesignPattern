using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_DSPA
{
    class Dog : Animal
    {
        public Dog(string name)
        {
            Name = name;
            Food = "dog food";
            Ability = "dog ability";
            Image = @"C:\Users\ASUS\Desktop\PowerPoint\2165706.png";
        }

        
    }
}
