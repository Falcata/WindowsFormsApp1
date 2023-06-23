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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            sqlManagement objDbgestor = new sqlManagement();
            Console.WriteLine("entrando en conexion");
            objDbgestor.conexion(); // abre la conexion
            objDbgestor.buscar();      
            
            
        }

        private void linkLogoff_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           this.Close();    
        }

        private void pictureLogoff_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
