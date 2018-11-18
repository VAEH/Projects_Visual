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
    public partial class Facultad : Form
    {
        public Facultad()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Facultad_Load(object sender, EventArgs e)
        {

            MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database=unaulavota2; Uid=root; pwd=;");
            conectar.Open();

            MySqlCommand comando = new MySqlCommand(string.Format("SELECT * FROM facultad"), conectar);

            MySqlDataAdapter adapt = new MySqlDataAdapter(comando);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Visible = true;

            textBox1.Enabled = false;
            textBox6.Enabled = false;
            textBox5.Enabled = false;
            textBox7.Enabled = false;
            textBox4.Enabled = false;
            comboBox1.Enabled = false;

            button1.Enabled = false;
            button6.Enabled = false;
            button4.Enabled = false;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            try { 
            MySqlConnection conectado = new MySqlConnection("server=127.0.0.1; database=unaulavota2; Uid=root; pwd=;");
            conectado.Open();

            MySqlCommand comando = new MySqlCommand(string.Format("UPDATE facultad SET " + this.comboBox1.GetItemText(this.comboBox1.SelectedItem) + " = '" + textBox7.Text + "' WHERE codFacultad = '" + textBox5.Text + "'"), conectado);

            MySqlDataAdapter adapt = new MySqlDataAdapter(comando);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Visible = true;

            textBox5.Text = "";
            textBox5.Enabled = false;
            textBox7.Text = "";
            textBox7.Enabled = false;
            comboBox1.Enabled = false;
            comboBox1.SelectedIndex = -1;

            button6.Enabled = false;
            button5.Enabled = true;
        }
            catch (Exception)
            {
                MessageBox.Show("Rectifique he intente nuevamente");
            }
}

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox6.Enabled = true;
            

            button1.Enabled = true;
            button2.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try { 
            MySqlConnection conectado = new MySqlConnection("server=127.0.0.1; database=unaulavota2; Uid=root; pwd=;");
            conectado.Open();

            MySqlCommand comando = new MySqlCommand(string.Format("INSERT INTO facultad VALUES('" + textBox1.Text + "', '" + textBox6.Text  + "')"), conectado);

            MySqlDataAdapter adapt = new MySqlDataAdapter(comando);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Visible = true;

            textBox1.Text = "";
            textBox1.Enabled = false;
            textBox6.Text = "";
            textBox6.Enabled = false;
            
           

            button1.Enabled = false;
            button2.Enabled = true;
        }
            catch (Exception)
            {
                MessageBox.Show("Rectifique he intente nuevamente");
            }
}

        private void button3_Click(object sender, EventArgs e)
        {
            textBox4.Enabled = true;
            button3.Enabled = false;
            button4.Enabled = true;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox5.Enabled = true;
            textBox7.Enabled = true;
            comboBox1.Enabled = true;
            button6.Enabled = true;
            button5.Enabled = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try { 
            MySqlConnection conectado = new MySqlConnection("server=127.0.0.1; database=unaulavota2; Uid=root; pwd=;");
            conectado.Open();

            MySqlCommand comando = new MySqlCommand(string.Format("SELECT * FROM facultad WHERE codFacultad = '" + textBox8.Text + "'"), conectado);

            MySqlDataAdapter adapt = new MySqlDataAdapter(comando);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Visible = true;

            textBox8.Text = "";
        }
            catch (Exception)
            {
                MessageBox.Show("Rectifique he intente nuevamente");
            }
}

        private void button7_Click(object sender, EventArgs e)
        {
            MySqlConnection conectado = new MySqlConnection("server=127.0.0.1; database=unaulavota2; Uid=root; pwd=;");
            conectado.Open();

            MySqlCommand comando = new MySqlCommand(string.Format("SELECT * FROM facultad"), conectado);

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

            MySqlCommand comando = new MySqlCommand(string.Format("DELETE FROM facultad WHERE codFacultad = '" + textBox4.Text + "'"), conectado);

            MySqlDataAdapter adapt = new MySqlDataAdapter(comando);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Visible = true;

            textBox4.Text = "";
            textBox4.Enabled = false;

            button4.Enabled = false;
            button3.Enabled = true;
        }
            catch (Exception)
            {
                MessageBox.Show("Rectifique he intente nuevamente");
            }
}

        private void button10_Click(object sender, EventArgs e)
        {
            Menu m = new Menu();
            m.Show();
            Close();
        }
    }
}
