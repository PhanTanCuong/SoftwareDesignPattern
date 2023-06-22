using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactoryProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void Createbutton_Click(object sender, EventArgs e)
        {
            AnimalFactory animalfactory = new AnimalFactory();
            IAnimal animal = animalfactory.viewAnimal(AnimalcomboBox.Text, usernametextBox.Text);
            playertextBox.Text = animal.Username;
            AnimaltextBox.Text = animal.Name;
            PassivetextBox.Text = animal.Passive;
            QtextBox.Text = animal.Q;
            WtextBox.Text = animal.W;
            EtextBox.Text = animal.E;
            RtextBox.Text = animal.R;
            DifficultytextBox.Text = animal.Difficulty;
            RoletextBox.Text = animal.Role;
            pictureBox1.Image = Image.FromFile(animal.Image);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
