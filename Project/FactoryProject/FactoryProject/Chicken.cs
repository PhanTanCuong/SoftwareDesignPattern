using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryProject
{
    class Chicken : IAnimal
    {
        public Chicken(string username)
        {
            Username = username;
            Name = "Azir";
            Passive = "SHURIMA'S LEGACY";
            Q = "CONQUERING SANDS";
            W = "ARISE!";
            E = "SHIFTING SANDS";
            R = "EMPEROR'S DIVIDE";
            Difficulty = "HIGH";
            Role = "Mid laner";
            Image = @"D:\\Software Design Patern\\Project\\FactoryProject\\Picture\\Chicken.jpg";
        }
    }
}
