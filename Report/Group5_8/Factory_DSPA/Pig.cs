using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_DSPA
{
    class Pig:Animal
    {
        public Pig(string name)
        {
            Name = name;
            Food = "pig food";
            Ability = "pig ability";
            Image = @"C:\\Users\admin\\OneDrive\\Desktop\\Software Design Patterns\\Factory_DSPA\\image\\z3950798905413_d1808e0063c18e257bd6edec41b26aa9.jpg";
        }

        
    }
}
