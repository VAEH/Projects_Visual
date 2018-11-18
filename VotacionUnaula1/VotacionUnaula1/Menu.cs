using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VotacionUnaula1
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            
        }

        private void fINALIZARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            Close();
        }

        private void facultadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Facultad fc = new Facultad();

            fc.Show();
            this.Hide();
        }

        private void programaAcademicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Programa prg = new Programa();

            prg.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 mc = new Form1();
            mc.Show();
            Close();
        }

        private void cargoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cargo_Universitario cargo = new Cargo_Universitario();
            cargo.Show();
            Close();
        }

        private void rOLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rol rol = new Rol();
            rol.Show();
            Close();
        }

        private void vOTANTESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Votantes votante = new Votantes();
            votante.Show();
            Close();
        }

        private void cANDIDATOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Candidato candidato = new Candidato();
            candidato.Show();
            Close();
        }

        private void tARGETONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tarjeton tarjeton = new tarjeton();
            tarjeton.Show();
            Close();
        }

        private void aYUDAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ayuda ayuda = new ayuda();
            ayuda.Show();
            Close();
        }

        private void rESULTADOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BDTarjeton td = new BDTarjeton();
            td.Show();
            Close();
        }

        private void vOTACIONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Detalles detalle = new Detalles();
            detalle.Show();
            Close();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
