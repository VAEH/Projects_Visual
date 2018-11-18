using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace VotacionUnaula1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox2.MaxLength = 6;
            textBox2.PasswordChar = '*';

        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conectar  = new MySqlConnection("server=127.0.0.1; database=unaulavota2; Uid=root; pwd=;");
                if (textBox1.Text == "admin" && textBox2.Text == "123456")
                {
                    //MessageBox.Show("SE HA CONECTADO");
                    MessageBox.Show("Bienvenido! has ingresado como administrador");

                    Menu menu = new Menu();
                    menu.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("USUARIO Y/O CONTRASEÑA INCORRECTO");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("ERROR");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Deseas cerrar sesión?", "Unaula",
          MessageBoxButtons.YesNo, MessageBoxIcon.Question)
          == DialogResult.Yes)
            {

                MessageBox.Show("Gracias Por Contribuir con tu Universidad");
                Application.Exit();
            }
        }
    }
}
