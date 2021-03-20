using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Proyecto_P2
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user;
            string contraseña;

            if (string.IsNullOrEmpty(txtusuario.Text))
            {
                MessageBox.Show("Error celda vacia");
            }
            else if (string.IsNullOrEmpty(txtcontraseña.Text))
            {
                MessageBox.Show("Error celda vacia");
            }
            else
            {
                user = txtusuario.Text;
                contraseña = txtcontraseña.Text;
                try
                {
                    if (user.Equals(user))
                    {

                        if (contraseña.Equals(contraseña))
                        {
                            MessageBox.Show("Bienvenido....");
                            Form formulario = new Menu();
                            formulario.Visible = true;
                            Visible = false;
                        }

                    }

                }
                catch (Exception Error)
                {
                    MessageBox.Show(Error.Message);
                }

            }
               
               
            
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                if (txtcontraseña.UseSystemPasswordChar == true)
                {
                    txtcontraseña.UseSystemPasswordChar = false;
                }
            }
            else
            {
                txtcontraseña.UseSystemPasswordChar = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
