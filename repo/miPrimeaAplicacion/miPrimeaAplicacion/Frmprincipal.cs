using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miPrimeaAplicacion
{
    public partial class Frmprincipal : Form
    {
        public Frmprincipal()
        {
            InitializeComponent();
        }

        private void Frmprincipal_Load(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void alumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 objAlumno = new Form1();
            objAlumno.MdiParent = this;
            objAlumno.Show();
        }

        private void notasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
