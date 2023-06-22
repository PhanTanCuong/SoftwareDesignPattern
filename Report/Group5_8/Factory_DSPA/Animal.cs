using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Factory_DSPA
{
    public abstract class Animal
    {
        private string name;
        private string ability;
        private string food;
        private string image;

        public string Name { get => name; set => name = value; }
        public string Ability { get => ability; set => ability = value; }
        public string Food { get => food; set => food = value; }
        public string Image { get => image; set => image = value; }

        

    }
}
