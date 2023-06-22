using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryProject
{
    class Cat : IAnimal
    {
        public Cat(string username)
        {
            Username = username;
            Name = "Yuumi";
            Passive = "FELINE FRIENDSHIP";
            Q = "PROWLING PROJECTILE";
            W = "YOU AND ME!";
            E = "ZOOMIES";
            R = "FINAL CHAPTER";
            Difficulty = "LOW";
            Role = "Support";
            Image = @"D:\\Software Design Patern\\Project\\FactoryProject\\Picture\\Cat.jpg";
        }
    }
}
