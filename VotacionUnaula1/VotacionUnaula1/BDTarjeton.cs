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
    public partial class BDTarjeton : Form
    {
        public BDTarjeton()
        {
            InitializeComponent();
            MessageBox.Show("Bienvenido al Sistema de Votación de la Universidad Aútonoma Latinoamericana");
            
           


        }
        int contador = 0;

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                MySqlConnection conectado = new MySqlConnection("server=127.0.0.1; database=unaulavota2; Uid=root; pwd=;");
                conectado.Open();

                MySqlCommand comando = new MySqlCommand(string.Format("INSERT INTO unaulavota2.pbtarjeton(nombre, apellido, hvotacion, ncandidato, candidato_codCandidato, votante_codVotante) VALUES ('victor','echavarria','21','1','6001', '" + textBox3.Text + "')"), conectado);

                MySqlDataAdapter adapt = new MySqlDataAdapter(comando);
                DataTable dt = new DataTable();
                adapt.Fill(dt);

                MessageBox.Show("El voto ha sido efectuado, Gracias por participar");

                button2.Enabled = false;
                button3.Enabled = false;
                button1.Enabled = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Usuario incorrecto por Favor intenta nuevamente");
            }
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Deseas cerrar sesión?", "My Application",
          MessageBoxButtons.YesNo, MessageBoxIcon.Question)
          == DialogResult.Yes)
            {
                MessageBox.Show("Gracias por ser parte de UNAULA");
                Application.Exit();
            }

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try { 
            MySqlConnection conectado = new MySqlConnection("server=127.0.0.1; database=unaulavota2; Uid=root; pwd=;");
            conectado.Open();

            MySqlCommand comando = new MySqlCommand(string.Format("INSERT INTO unaulavota2.pbtarjeton(nombre, apellido, hvotacion, ncandidato, candidato_codCandidato, votante_codVotante) VALUES ('Debora','Arango','0','2','6002', '" + textBox3.Text + "')"), conectado);

            MySqlDataAdapter adapt = new MySqlDataAdapter(comando);
            DataTable dt = new DataTable();
            adapt.Fill(dt);

            MessageBox.Show("El voto ha sido efectuado, Gracias por participar");

            button2.Enabled = false;
            button3.Enabled = false;
            button1.Enabled = false;
            textBox3.Enabled = false;

        }
            catch (Exception)
            {
                MessageBox.Show("Usuario incorrecto por Favor intenta nuevamente");
            }
}

        private void BDTarjeton_Load(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                MySqlConnection conectado = new MySqlConnection("server=127.0.0.1; database=unaulavota2; Uid=root; pwd=;");
                conectado.Open();

                MySqlCommand comando = new MySqlCommand(string.Format("INSERT INTO unaulavota2.pbtarjeton(nombre, apellido, hvotacion, ncandidato, candidato_codCandidato, votante_codVotante) VALUES ('JERONIMO','HERNANDEZ SALDARRIAGA','00','3','6003', '" + textBox3.Text + "')"), conectado);

                MySqlDataAdapter adapt = new MySqlDataAdapter(comando);
                DataTable dt = new DataTable();
                adapt.Fill(dt);

                MessageBox.Show("El voto ha sido efectuado, Gracias por participar");

                button2.Enabled = false;
                button3.Enabled = false;
                button1.Enabled = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Usuario incorrecto por Favor intenta nuevamente");
            }
        }
    }
}
