using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InscripcionesEstudiantes.UI;

namespace InscripcionesEstudiantes
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load_1(object sender, EventArgs e)
        {

        }
        private void EstudiantesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            rEstudiantes est = new rEstudiantes();
            est.MdiParent = this;
            est.Show();
        }

        private void InscripcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rInscripciones est = new rInscripciones();
            est.MdiParent = this;
            est.Show();
            
        }

        private void EstudiantesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cEstudiantes cEstudiante = new cEstudiantes();
            cEstudiante.MdiParent = this;
            cEstudiante.Show();
        }

        
    }

}
