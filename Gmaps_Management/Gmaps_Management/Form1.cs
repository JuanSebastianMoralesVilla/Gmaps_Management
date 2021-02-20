using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using Gmaps_Management.Class;
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




namespace Gmaps_Management
{
    public partial class Form1 : Form
    {



        // ruta del archivo
        private string path;
        // pais

        private Country colombia;
        // data mostrar municipios

        private AllTowns data;


        // capas y listas (marcadores, puntos)

        private List<PointLatLng> points;      //marcadores
        GMapOverlay markers = new GMapOverlay("markers");   //capa de marcadores




        public Form1()
        {
            Console.WriteLine("Entreee");
            InitializeComponent();
            colombia = new Country();
            data = new AllTowns();
            points = new List<PointLatLng>();

            //Ubicacion del archivo a cargar
            path = @"..\..\Data";


        }

        OpenFileDialog file = new OpenFileDialog();



        private void button1_Click(object sender, EventArgs e)
        {

            file.Filter = "CSV|*.csv";

            if (file.ShowDialog() == DialogResult.OK)
            {
                txloadFile.Text = file.FileName;
                path = file.FileName;
                txBoxload2.Text = file.SafeFileName;
                MessageBox.Show("Datos cargados correctamente.");
                colombia = new Country();
                loadGrid();
            }

        }

        private void loadGrid()
        {
            try
            {
                
                var reader = new StreamReader(File.OpenRead(path));
                string line = reader.ReadLine();
                line = reader.ReadLine();
                List<AllTowns> towns = new List<AllTowns>();
                while (!string.IsNullOrEmpty(line))
                {
                    try
                    {
                        string[] array = line.Split(',');
                        string nameTown = (array[0]);
                        int idTown = Int32.Parse(array[1]);
                        string nameDepartament = (array[2]);
                        int idDept = Int32.Parse(array[3]);
                        int cantPeople = Int32.Parse(array[4]);
                        string covid = (array[5]);
                        int cantConfirm = Int32.Parse(array[6]);
                        string region = (array[7]);

                        AllTowns all = new AllTowns(nameTown, idTown, nameDepartament, idDept, cantPeople, covid, cantConfirm, region);

                        colombia.add(nameTown, idTown, nameDepartament, idDept, cantPeople, covid, cantConfirm, region);

                        //Console.WriteLine(all.ToString());

                        towns.Add(all);
                        
                    }
                    catch(FormatException e)
                    {
                        Console.WriteLine("Line is empty");
                    }
                    line = reader.ReadLine();

                }
                dataGridView1.DataSource = towns;
                

            }
            catch (Exception alm)
            {
                
                Console.WriteLine(alm.ToString());
            }


        }



        private void Form1_Load(object sender, EventArgs e)
        {

            loadGrid();
            cb_initialization();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gMapControl1_Load(object sender, EventArgs e)
        {
            gMap.MapProvider = GoogleMapProvider.Instance;
            GMaps.Instance.Mode = AccessMode.ServerOnly;

            gMap.Position = new PointLatLng(3.42158, -75.7643);

            gMap.Overlays.Add(markers);

        }

        // boton para que aparezcan los municipios
        private void button2_Click(object sender, EventArgs e)
        {
            List<String> lista = data.getListTowns();
            foreach (string f in lista)
            {
                Console.WriteLine(f,"Casteo PRo");
                GeoCoderStatusCode statusCode;
                PointLatLng? point = OpenStreet4UMapProvider.Instance.GetPoint(f, out statusCode);

                if (point != null)
                {
                    GMapMarker marker00 = new GMarkerGoogle(new PointLatLng(point.Value.Lat, point.Value.Lng), GMarkerGoogleType.blue_dot);
                    marker00.ToolTipText = f + "\n " + point.Value.Lat + "\n" + point.Value.Lng;
                    markers.Markers.Add(marker00);

                }

            }
        }

        // limpiar elementos de gmaps
        private void button2_Click_1(object sender, EventArgs e)
        {
            markers.Clear();
        }

        private void cbFilter1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbFilter1.SelectedIndex)
            {
                case 0:
                    cbCategories.Visible = true;
                    break;
                case 1:
                    cbCategories.Visible = false;
                    break;
                case 2:
                    cbCategories.Visible = false;
                    break;
                default:
                    cbCategories.Visible = false;
                    break;
            }
        }

        private void cb_initialization()
        {
            /*
            List<Region> regions = colombia.regions;
            for (int i = 0; i < colombia.size; i++)
            {
                cbCategories.Items.Add(regions.ElementAt(i).name);
            }
            cbCategories.Visible = false;
            */
        }

        private void chartData1()
        {

            // string[] nameDept= colombia
        }

        private void cbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {



        }



    }
}
