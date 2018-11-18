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
    public partial class tarjeton : Form
    {
        public tarjeton()
        {
            InitializeComponent();
        }

        private void tarjeton_Load(object sender, EventArgs e)
        {
            MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database=unaulavota2; Uid=root; pwd=;");
            conectar.Open();

            MySqlCommand comando = new MySqlCommand(string.Format("SELECT * FROM pbtarjeton"),conectar);
            MySqlDataAdapter adapt = new MySqlDataAdapter(comando);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Visible = true;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            try { 
            MySqlConnection conectado = new MySqlConnection("server=127.0.0.1; database=unaulavota2; Uid=root; pwd=;");
            conectado.Open();

            MySqlCommand comando = new MySqlCommand(string.Format("INSERT INTO pbtarjeton VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox11.Text + "')"), conectado);

            MySqlDataAdapter adapt = new MySqlDataAdapter(comando);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Visible = true;
        }
            catch (Exception)
            {
                MessageBox.Show("Rectifique he intente nuevamente");
            }
}

        private void button2_Click(object sender, EventArgs e)
        {
            try { 
            MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database=unaulavota2; Uid=root; pwd=;");
            conectar.Open();

            MySqlCommand comando = new MySqlCommand(string.Format("DELETE FROM pbtarjeton WHERE codPbtarjeton='"+textBox7.Text+"'"), conectar);
            MySqlDataAdapter adapt = new MySqlDataAdapter(comando);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Visible = true;
        }
            catch (Exception)
            {
                MessageBox.Show("Rectifique he intente nuevamente");
            }
}

        private void button3_Click(object sender, EventArgs e)
        {
            try { 
            MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database=unaulavota2; Uid=root; pwd=;");
            conectar.Open();

            MySqlCommand comando = new MySqlCommand(string.Format("SELECT * FROM pbtarjeton WHERE codPbtarjeton='"+textBox8.Text+"'"), conectar);
            MySqlDataAdapter adapt = new MySqlDataAdapter(comando);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Visible = true;

            BDprueba limpiar = new BDprueba();
            limpiar.BorrarCampos(this, groupBox1);
        }
            catch (Exception)
            {
                MessageBox.Show("Rectifique he intente nuevamente");
            }
}

        private void button5_Click(object sender, EventArgs e)
        {
            MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database=unaulavota2; Uid=root; pwd=;");
            conectar.Open();

            MySqlCommand comando = new MySqlCommand(string.Format("SELECT * FROM pbtarjeton"), conectar);
            MySqlDataAdapter adapt = new MySqlDataAdapter(comando);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Visible = true;

            BDprueba limpiar = new BDprueba();
            limpiar.BorrarCampos(this, groupBox1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try { 
            MySqlConnection conectado = new MySqlConnection("server=127.0.0.1; database=unaulavota2; Uid=root; pwd=;");
            conectado.Open();

            MySqlCommand comando = new MySqlCommand(string.Format("UPDATE pbtarjeton SET " + this.comboBox1.GetItemText(this.comboBox1.SelectedItem) + "='" + textBox10.Text + "' WHERE codPbtarjeton= '" + textBox9.Text + "'"), conectado);

            MySqlDataAdapter adapt = new MySqlDataAdapter(comando);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Visible = true;
        }
            catch (Exception)
            {
                MessageBox.Show("Rectifique he intente nuevamente");
            }
}

        private void button6_Click(object sender, EventArgs e)
        {
            Menu MENU = new Menu();
            MENU.Show();
            MENU.Close();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            Menu m = new Menu();
            m.Show();
            Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database=unaulavota2; Uid=root; pwd=;");
                conectar.Open();

                MySqlCommand comando = new MySqlCommand(string.Format(" SELECT COUNT(candidato_codCandidato) FROM unaulavota2.pbtarjeton   WHERE candidato_codCandidato='"+textBox12.Text+"'"), conectar);
                MySqlDataAdapter adapt = new MySqlDataAdapter(comando);
                DataTable dt = new DataTable();
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.Visible = true;

                BDprueba limpiar = new BDprueba();
                limpiar.BorrarCampos(this, groupBox1);



            }
            catch (Exception)
            {
                MessageBox.Show("Rectifique he intente nuevamente");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database=unaulavota2; Uid=root; pwd=;");
                conectar.Open();

                MySqlCommand comando = new MySqlCommand(string.Format("SELECT COUNT(votante_codVotante) FROM unaulavota2.pbtarjeton"),conectar);
                MySqlDataAdapter adapt = new MySqlDataAdapter(comando);
                DataTable dt = new DataTable();
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.Visible = true;



            }
            catch (Exception)
            {
                MessageBox.Show("Error en el Conteo");
            }
        }
    }
}
