using Gmaps_Management.Model;
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

namespace Gmaps_Management.Gui
{
    public partial class Form2 : Form
    {

        private Country Colombia;
        private AllTowns data;

        public Form2(Country co)
        {
            InitializeComponent();
            Colombia = co;
            data = new AllTowns();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            GraphicBar.Titles.Add("Gráfico de barras de cantidad de municipios por región");
            pointChar3.Titles.Add("Gráfico de dona de cantidad de casos por departamentos");
            PieChart.Titles.Add("Gráfico de pastel de cantidad de casos confirmados respecto a la población");
            PieChart.Palette = ChartColorPalette.EarthTones;
            
        }

        public void loadBarChart()
        {
            List<Gmaps_Management.Model.Region> r = Colombia.Regions;
            int count = 0;
            int indexChart = 0;
            foreach (Gmaps_Management.Model.Region currentR in r)
            {
                string region = currentR.name;
                List<Departament> d = currentR.departaments;
                foreach(Departament currentD in d)
                {
                    count+=currentD.towns.Count();
                }
                GraphicBar.Series["Series1"].Points.AddXY(region, count);
                GraphicBar.Series["Series1"].Points[indexChart].LegendText = region;
                GraphicBar.Series["Series1"].Points[indexChart].Label = "" + count;
                count = 0;
                indexChart++;
            }
        }

        public void loadPointChart()
        {
            List<Gmaps_Management.Model.Region> r = Colombia.Regions;
            int confirmed = 0;
            int indexChart = 0;
            foreach (Gmaps_Management.Model.Region currentR in r)
            {
                List<Departament> d = currentR.departaments;
                foreach (Departament currentD in d)
                {
                    string dName = currentD.name;
                    List<Town> t = currentD.towns;
                    foreach (Town currentT in t)
                    {
                        confirmed += currentT.cantConfirm;
                    }
                    pointChar3.Series["Series1"].Points.AddXY(dName, confirmed);
                    pointChar3.Series["Series1"].Points[indexChart].LegendText = dName+" - "+confirmed;
                    pointChar3.Series["Series1"].Points[indexChart].Label = " ";
                    confirmed = 0;
                    indexChart++;
                }
            }
        }

        public void loadPieChart()
        {
            List<Gmaps_Management.Model.Region> r = Colombia.Regions;
            int confirmed = 0;
            int total = 0;
            foreach (Gmaps_Management.Model.Region currentR in r)
            {
                string region = currentR.name;
                List<Departament> d = currentR.departaments;
                foreach (Departament currentD in d)
                {
                    List<Town> t = currentD.towns;
                    foreach(Town currentT in t)
                    {
                        confirmed += currentT.cantConfirm;
                        total += currentT.cantPeople;
                    }
                }
            }
            PieChart.Series["Series3"].Points.AddXY("Contagiados", confirmed);
            PieChart.Series["Series3"].Points[0].LegendText = "Contagiados";
            PieChart.Series["Series3"].Points[0].Label = "" + confirmed;
            PieChart.Series["Series3"].Points.AddXY("Poblacion Total", total);
            PieChart.Series["Series3"].Points[1].LegendText = "Poblacion Total";
            PieChart.Series["Series3"].Points[1].Label = "" + total;
        }
<<<<<<< HEAD:Gmaps_Management/Gmaps_Management/Gui/Form2.cs
        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void PieChart_Click(object sender, EventArgs e)
        {

        }

        private void GraphicBar_Click(object sender, EventArgs e)
        {

        }
=======

>>>>>>> 2ddac05e885804ed8ebbde7ba19b75962d7fe0b3:Gmaps_Management/Gmaps_Management/Form2.cs
    }
}
