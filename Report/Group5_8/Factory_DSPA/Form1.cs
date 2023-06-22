using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Factory_DSPA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            AnimalFactory af = new AnimalFactory();
            Animal ani = af.viewAnimal(AnimalTextBox.Text, NameTextBox.Text);
            NameTextBox1.Text = ani.Name;
            pictureBox.Image = Image.FromFile(ani.Image);
            FoodTextBox.Text = ani.Food;
            AbilityTextBox.Text = ani.Ability;
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
