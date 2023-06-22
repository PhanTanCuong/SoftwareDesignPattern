using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace GoogleTranslate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Adapter adapter= new Adapter();

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> list = new List<string>();
            textBox2.Text= string.Empty;
            textBox2.Text = adapter.DichNgonNgu(list);
        }

    }
}
