using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryProject
{
    public abstract class IAnimal
    {
        private string name;
        private string username;
        private string passive;
        // q,w,e,r ability of LOL champions
        private string q;
        private string w;
        private string e;
        private string r;
        private string difficulty;
        private string role;
        private string image;

        public string Name { get => name; set => name = value; }
        public string Username { get => username; set => username = value; }
        public string Passive { get => passive; set => passive = value; }
        public string Q { get => q; set => q = value; }
        public string W { get => w; set => w = value; }
        public string E { get => e; set => e = value; }
        public string R { get => r; set => r = value; }
        public string Difficulty { get => difficulty; set => difficulty = value; }
        public string Role { get => role; set => role = value; }
        public string Image { get => image; set => image = value; }
    }
}
