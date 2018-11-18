using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVotacion2
{
    public partial class Facultad : Form
    {
        public Facultad()
        {
            InitializeComponent();
        }

        private void facultadBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.facultadBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bd_unaulavotaDataSet);

        }

        private void Facultad_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bd_unaulavotaDataSet.facultad' Puede moverla o quitarla según sea necesario.
            this.facultadTableAdapter.Fill(this.bd_unaulavotaDataSet.facultad);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
