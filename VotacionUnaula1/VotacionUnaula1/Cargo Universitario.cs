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
    public partial class Cargo_Universitario : Form
    {
        public Cargo_Universitario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try { 
            MySqlConnection conectar = new MySqlConnection(("server=127.0.01; database=unaulavota2; Uid=root; pwd="));
            conectar.Open();
            
                MySqlCommand comando = new MySqlCommand(string.Format("INSERT INTO tipoconsejo VALUES('" + textBox1.Text + "','" + textBox2.Text + "')"), conectar);
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

        private void Cargo_Universitario_Load(object sender, EventArgs e)
        {
            
            MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database=unaulavota2; Uid=root; pwd=");
            conectar.Open();

            MySqlCommand comando = new MySqlCommand(string.Format("SELECT * FROM tipoconsejo"), conectar);
            MySqlDataAdapter adapt = new MySqlDataAdapter(comando);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Visible = true;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            try { 
            MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database=unaulavota2; Uid=root; pwd=");
            conectar.Open();
            MySqlCommand comando = new MySqlCommand(string.Format("DELETE FROM tipoconsejo WHERE codConsejo='"+textBox3.Text+"'"), conectar);
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

        private void button3_Click(object sender, EventArgs e)
        {
            MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database=unaulavota2; Uid=root; pwd=");
            conectar.Open();
            MySqlCommand comando = new MySqlCommand(string.Format("SELECT * FROM tipoconsejo"),conectar);
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

            MySqlCommand comando = new MySqlCommand(string.Format("SELECT * FROM tipoconsejo WHERE codConsejo = '" + textBox4.Text + "'"), conectado);

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
            try { 
            MySqlConnection conectado = new MySqlConnection("server=127.0.0.1; database=unaulavota2; Uid=root; pwd=;");
            conectado.Open();

            MySqlCommand comando = new MySqlCommand(string.Format("UPDATE tipoconsejo SET " + this.comboBox1.GetItemText(this.comboBox1.SelectedItem) + " = '" + textBox6.Text + "' WHERE codConsejo= '" + textBox5.Text + "'"), conectado);

            MySqlDataAdapter adapt = new MySqlDataAdapter(comando);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Visible = true;


            comboBox1.SelectedIndex = -1;
        }
            catch (Exception)
            {
                MessageBox.Show("Rectifique he intente nuevamente");
            }
}

        private void button6_Click(object sender, EventArgs e)
        {
            Menu m = new Menu();
            m.Show();
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
