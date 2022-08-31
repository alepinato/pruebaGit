using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proy_CRUD_File
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            try
            {
                TextWriter escribir = new StreamWriter("producto.txt");
                escribir.WriteLine("Hola Mundo 2");
                escribir.Close();
                   

                StreamWriter agregar = File.AppendText("producto.txt");
                agregar.WriteLine("Nueva linea agregada");
                MessageBox.Show("Escritura OK");
                escribir.Close();
                agregar.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            try
            {
                ofdLeer.Title = "Buscar el archivo";
                ofdLeer.ShowDialog();
                string Texto = ofdLeer.FileName;
                if (File.Exists(ofdLeer.FileName))
                {
                    StreamReader leer = new StreamReader(Texto);
                    rtbContenido.Text = leer.ReadToEnd();
                    leer.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (sfdGuardar.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfdGuardar.FileName))
                    {
                        string txt = sfdGuardar.FileName;
                        StreamWriter textoguardar = File.CreateText(txt);
                        textoguardar.Write(rtbContenido.Text);
                        textoguardar.Flush();
                        textoguardar.Close();

                        txtProducto.Text = txt;

                    }
                    else
                    {
                        string txt = sfdGuardar.FileName;
                        StreamWriter textoguardar = File.CreateText(txt);
                        textoguardar.Write(rtbContenido.Text);
                        textoguardar.Flush();
                        textoguardar.Close();

                        txtProducto.Text = txt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
