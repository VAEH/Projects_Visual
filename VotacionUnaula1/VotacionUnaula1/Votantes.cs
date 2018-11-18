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
    public partial class Votantes : Form
    {
        public Votantes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database=unaulavota2; Uid=root; pwd=;");
            //conectar.Open();

            //MySqlCommand comando = new MySqlCommand(string.Format("INSERT INTO votante VALUES('"+textBox1.Text+"','" + textBox2.Text+"','"+ textBox3.Text+"','"+ textBox4.Text+"','"+textBox5.Text+"','"+textBox7+"')"), conectar);
            //MySqlDataAdapter adapt = new MySqlDataAdapter(comando);
            //DataTable dt = new DataTable();
            //adapt.Fill(dt);
            //dataGridView1.DataSource = dt;
            //dataGridView1.Visible = true;
            try { 
            MySqlConnection conectado = new MySqlConnection("server=127.0.0.1; database=unaulavota2; Uid=root; pwd=;");
            conectado.Open();


            MySqlCommand comando = new MySqlCommand(string.Format("INSERT INTO votante VALUES( '" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox7.Text + "')"), conectado);

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

        private void Votantes_Load(object sender, EventArgs e)
        {
            MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database=unaulavota2; Uid=root; pwd=;");
            conectar.Open();

            MySqlCommand comando = new MySqlCommand(string.Format("SELECT * FROM votante"),conectar);
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
            MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database=unaulavota2; Uid=root; pwd=;");
            conectar.Open();

            MySqlCommand comando = new MySqlCommand(string.Format("DELETE FROM votante WHERE codVotante='"+textBox6.Text+"'"), conectar);
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

            MySqlCommand comando = new MySqlCommand(string.Format("SELECT * FROM votante WHERE codVotante='"+textBox8.Text+"'"), conectar);
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

        private void button4_Click(object sender, EventArgs e)
        {
            /*MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database=unaulavota2; Uid=root; pwd=;");
            conectar.Open();

            MySqlCommand comando = new MySqlCommand(string.Format("UPDATE votante SET "+this.comboBox1.GetItemText(this.comboBox1.SelectedItem)+"'='"+textBox10.Text+"'WHERE codVotante='"+textBox9+""), conectar);
            MySqlDataAdapter adapt = new MySqlDataAdapter(comando);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Visible = true;*/
            try { 
            MySqlConnection conectado = new MySqlConnection("server=127.0.0.1; database=unaulavota2; Uid=root; pwd=;");
            conectado.Open();

            MySqlCommand comando = new MySqlCommand(string.Format("UPDATE votante SET " + this.comboBox1.GetItemText(this.comboBox1.SelectedItem) + " = '" + textBox10.Text + "' WHERE codVotante= '" + textBox9.Text + "'"), conectado);

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

        private void button5_Click(object sender, EventArgs e)
        {
            MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database=unaulavota2; Uid=root; pwd=;");
            conectar.Open();

            MySqlCommand comando = new MySqlCommand(string.Format("SELECT * FROM votante"), conectar);
            MySqlDataAdapter adapt = new MySqlDataAdapter(comando);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Visible = true;

            BDprueba limpiar = new BDprueba();
            limpiar.BorrarCampos(this, groupBox1);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            menu.Close();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            Menu m = new Menu();
            m.Show();
            Close();
        }

        
    }
}
