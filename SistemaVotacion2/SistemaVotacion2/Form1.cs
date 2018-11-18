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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            this.Hide();
            menu.ShowDialog();
            this.Show();
        }

        private void candidatoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.candidatoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bd_unaulavotaDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bd_unaulavotaDataSet.pro_acad' Puede moverla o quitarla según sea necesario.
            this.pro_acadTableAdapter.Fill(this.bd_unaulavotaDataSet.pro_acad);
            // TODO: esta línea de código carga datos en la tabla 'bd_unaulavotaDataSet.candidato' Puede moverla o quitarla según sea necesario.
            this.candidatoTableAdapter.Fill(this.bd_unaulavotaDataSet.candidato);

        }
    }
}
