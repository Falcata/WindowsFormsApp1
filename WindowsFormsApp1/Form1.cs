using System;
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
            Console.WriteLine("probando...");
            
            objDbgestor.conexion(); // abre la conexion

            if (objDbgestor.buscar(textUser.Text, textPassword.Text))
            {


                this.Hide();
                var formulario = new MDIParent1();
                formulario.Show();

            }
            else {
                MessageBox.Show("Usuario erroneo"); // conviene crear un form de rechazo del mismo tipo
            }


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
