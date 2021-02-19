using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gmaps_Management
{
    public partial class Form1 : Form
    {
        // ruta del archivo
        private string path;

        public Form1()
        {
            //Ubicacion del archivo a cargar
            path = @"";
            InitializeComponent();
        }

        OpenFileDialog file = new OpenFileDialog();
        private void button1_Click(object sender, EventArgs e)
        {


            if (file.ShowDialog() == DialogResult.OK) { 
            txloadFile.Text = file.FileName;
            path = file.FileName;
            txBoxload2.Text = file.SafeFileName;
            MessageBox.Show("Datos cargados correctamente.");
        }

        }
    }
}
