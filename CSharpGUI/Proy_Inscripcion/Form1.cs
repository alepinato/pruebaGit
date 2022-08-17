using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proy_Inscripcion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rdbNo.Checked = true;
                
        }

        private void rdbOk_Click(object sender, EventArgs e)
        {
            if (txtNombres.Text == "" || txtApellidos.Text == "")
            {
                MessageBox.Show("Debe ingresar nombres y apellidos");
                txtNombres.Clear();
                txtNombres.Focus();
            }
            else
            {
                panAcademico.Visible = true;
            }
        }

        private void rdbOk_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
