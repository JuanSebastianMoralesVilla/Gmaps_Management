using Gmaps_Management.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Gmaps_Management
{
    public partial class Form2 : Form
    {

        private Country Colombia;

        public Form2(Country co)
        {
            InitializeComponent();
            Colombia = co;

        }


        private void charData1() {
          
            
        
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            GraphicBar.Titles.Add("Gráfico de barras de cantidad de municipios por región");
            pointChar3.Titles.Add("Gráfico de puntos de cantidad de casos por departamentos");
            PieChart.Titles.Add("Gráfico de pastel de cantidad de casos confirmados respecto a la población");
            PieChart.Palette = ChartColorPalette.EarthTones;
            
        }

        public void loadBarChart()
        {
            List<Region> r = Colombia.Regions;
        }

        public void loadPointChart()
        {

        }

        public void loadPieChart()
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
