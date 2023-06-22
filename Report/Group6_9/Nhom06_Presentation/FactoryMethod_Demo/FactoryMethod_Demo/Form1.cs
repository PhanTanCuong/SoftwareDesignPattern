using FactoryMethod_Demo.Factory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactoryMethod_Demo
{
    public partial class form_CreateAnimal : Form
    {
        public form_CreateAnimal()
        {
            InitializeComponent();
        }

        private void btn_CreateAnimal_Click(object sender, EventArgs e)
        {
            IAnimalFactory factory;
            Random random = new Random();
            int type = random.Next(0, 2);
            if (type == 0)
            {
                factory = new BasicAnimalFactory();
                PictureBox1.Image = Image.FromFile(factory.CreateAnimal().GetName());
                PictureBox2.Image = Image.FromFile(factory.CreateAnimal().GetName());
                PictureBox3.Image = Image.FromFile(factory.CreateAnimal().GetName());
            }
            else
            {
                factory = new RandomAnimalFactory();
                PictureBox1.Image = Image.FromFile(factory.CreateAnimal().GetName());
                PictureBox2.Image = Image.FromFile(factory.CreateAnimal().GetName());
                PictureBox3.Image = Image.FromFile(factory.CreateAnimal().GetName());
            }
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
