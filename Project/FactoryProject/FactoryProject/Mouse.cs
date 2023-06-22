using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryProject
{
    class Mouse : IAnimal
    {
        public Mouse(string username)
        {
            Username = username;
            Name = "Twitch";
            Passive = "DEADLY VENOM";
            Q = "AMBUSH";
            W = "VENOM CASK";
            E = "CONTAMINATE";
            R = "SPRAY AND PRAY";
            Difficulty = "MODERATE";
            Role = "AD carry";
            Image = @"D:\\Software Design Patern\\Project\\FactoryProject\\Picture\\Mouse.jpg";
        }
    }
}
