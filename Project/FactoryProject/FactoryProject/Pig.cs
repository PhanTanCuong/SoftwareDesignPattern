using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryProject
{
    class Pig : IAnimal
    {
        public Pig(string username)
        {
            Username = username;
            Name = "Sejuani";
            Passive = "FURY OF THE NORTH";
            Q = "ARCTIC ASSAULT";
            W = "WINTER'S WRATH";
            E = "PERMAFROST";
            R = "GLACIAL PRISON";
            Difficulty = "MODERATE";
            Role = "Jungler";
            Image = @"D:\\Software Design Patern\\Project\\FactoryProject\\Picture\\Pig.jpg";
        }
    }
}
