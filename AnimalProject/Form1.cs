using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimalProject
{
    public partial class Form1 : Form
    {
        private Animal dog;
        private Animal cat;
        public Form1()
        {
            InitializeComponent();
            dog = new Animal("dog", "Tio", 4);
            cat = new Animal("cat", "Magic", 2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dog.ListDetails());
            MessageBox.Show(cat.ListDetails());
        }
    }
}
