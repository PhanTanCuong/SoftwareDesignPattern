using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryProject
{
    class Dog : IAnimal
    {
        public Dog(string username)
        {
            Username = username;
            Name = "Nasus";
            Passive = "SOUL EATER";
            Q = "SIPHONING STRIKE";
            W = "WITHER";
            E = "SPIRIT FIRE";
            R = "FURY OF THE SANDS";
            Difficulty = "MODERATE";
            Role = "Top Laner";
            Image = @"D:\\Software Design Patern\\Project\\FactoryProject\\Picture\\Dog.jpg";
        }
    }
}
