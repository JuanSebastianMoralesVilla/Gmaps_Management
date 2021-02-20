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
            InitializeComponent();
            colombia = new Country();
            data = new AllTowns();
            points = new List<PointLatLng>();

            //Ubicacion del archivo a cargar
            path = @"C:\Users\user\Desktop\Gmaps_Management\Gmaps_Management\Gmaps_Management\Data";
         
            
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
            try {
                Console.WriteLine("ENTREEE");
                var reader = new StreamReader(File.OpenRead(path));
                string line = reader.ReadLine();
                line = reader.ReadLine();
                List<AllTowns> towns = new List<AllTowns>();
                while (!string.IsNullOrEmpty(line))
                {
                    string[] array = line.Split(';');
                    string nameTown = (array[0]);
                    int idTown = Int32.Parse(array[1]);
                    string nameDepartament = (array[2]);
                    int idDept = Int32.Parse(array[3]);
                    int cantPeople = Int32.Parse(array[4]);
                    string covid = (array[5]);
                    int cantConfirm = Int32.Parse(array[6]);
                    string region = (array[7]);
                    AllTowns all = new AllTowns(nameTown, idTown, nameDepartament,idDept, cantPeople, covid, cantConfirm, region);
                  
                    colombia.add(nameTown, idTown, nameDepartament,idDept, cantPeople, covid, cantConfirm, region);

                    Console.WriteLine(all.ToString());



                    towns.Add(all);
                    line = reader.ReadLine();
                }
                dataGridView1.DataSource = towns;
            }
            catch (Exception alm) {
                Console.WriteLine(alm.ToString());
            }
          

        }



        private void Form1_Load(object sender, EventArgs e) {

            loadGrid();
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
            foreach (string f in lista) {

                GeoCoderStatusCode statusCode;
                PointLatLng? point = OpenStreet4UMapProvider.Instance.GetPoint(f, out statusCode);

                if (point != null) {
                    GMapMarker marker00 = new GMarkerGoogle(new PointLatLng (point.Value.Lat, point.Value.Lng),GMarkerGoogleType.blue_dot);
                        marker00.ToolTipText = f + "\n " + point.Value.Lat + "\n" + point.Value.Lng;
                    markers.Markers.Add(marker00);

                }

            }
        }
    }
}
