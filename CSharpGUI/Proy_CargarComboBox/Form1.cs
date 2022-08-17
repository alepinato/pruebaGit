using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proy_CargarComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrir = new OpenFileDialog();
            abrir.Filter = "Archivo texto | *.txt";
            
            if (abrir.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader lector = new StreamReader(abrir.FileName))
                {
                    while (lector.Peek() >=0)
                    {
                        comboBox1.Items.Add(lector.ReadLine());
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String linea;
            StreamReader sr = new StreamReader(@"C:\nombres.txt");
            linea = sr.ReadLine();
            while (linea != null)
            {
                comboBox2.Items.Add(linea);
                linea = sr.ReadLine();
            }
            sr.Close();
        }
    }
}
