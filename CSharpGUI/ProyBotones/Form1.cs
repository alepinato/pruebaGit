using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyBotones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.txtmensaje.SetToolTip(this.button1, "Has clic para inhabilitar este botón");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            if (button1.Text == "Habilitado")
            {
                button1.Enabled = false;
                button1.Text = "Inhabilitado";
            }
            
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == Convert.ToChar(Keys.F1))
            {
                button1.Enabled = true;
                button1.Text = "Habilitado";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
