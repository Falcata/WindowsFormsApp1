using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = true;
            textBox1.Text = "funciona";
            // este es un comentario

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("este es un mensaje");
            textBox3.Text = "funciona 3";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "funciona 2";
        }
    }
}
