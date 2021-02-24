using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using Gmaps_Management.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace Gmaps_Management.Gui
{
    public partial class Form1 : Form
    {



        // ruta del archivo
        private string path;
        // pais

        private Country colombia;
        // data mostrar municipios

        private AllTowns data;

        private Form2 chartWindow;

        // capas y listas (marcadores, puntos)

        private List<PointLatLng> points;      //marcadores
        GMapOverlay markers = new GMapOverlay("markers");   //capa de marcadores

        private List<PointLatLng> poligonos; // poligonos
        GMapOverlay polygons = new GMapOverlay("polygons");




        public Form1()
        {
            Console.WriteLine("Entreee");
            InitializeComponent();
            colombia = new Country();
            data = new AllTowns();
            points = new List<PointLatLng>();
            poligonos = new List<PointLatLng>();

            //Ubicacion del archivo a cargar
            path = @"..\..\Data";
            cbFilter1.Visible = false;
            cbCategories.Visible = false;

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
                        //Console.WriteLine(array[8]);
                        double latitud = array[8].ElementAt(0).Equals('#') ? 0 : Double.Parse(Regex.Replace(array[8], "[.,]", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator));
                        //Console.WriteLine(array[8] + " " + latitud);
                        double longitud = array[9].ElementAt(0).Equals('#') ? 0 : Double.Parse(Regex.Replace(array[9], "[.,]", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator));
                        AllTowns all = new AllTowns(nameTown, idTown, nameDepartament, idDept, cantPeople, covid, cantConfirm, region,latitud,longitud);

                        colombia.add(nameTown, idTown, nameDepartament, idDept, cantPeople, covid, cantConfirm, region,latitud,longitud);

                        //Console.WriteLine(all.ToString());

                        towns.Add(all);
                        
                    }
                    catch(FormatException e)
                    {
                        Console.WriteLine(e.Message,"Line is empty");
                    }
                    line = reader.ReadLine();

                }
                dataGridView1.DataSource = towns;
                drawOnMap(towns);
                cbFilter1.Visible = true;
                cb_initialization();
<<<<<<< HEAD:Gmaps_Management/Gmaps_Management/Gui/Form1.cs

=======
                
>>>>>>> 2ddac05e885804ed8ebbde7ba19b75962d7fe0b3:Gmaps_Management/Gmaps_Management/Form1.cs
            }
            catch (Exception alm)
            {
                
                Console.WriteLine(alm.ToString());
            }


        }



        private void Form1_Load(object sender, EventArgs e)
        {
            loadGrid();
            
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        // carga gMap
        private void gMapControl1_Load(object sender, EventArgs e)
        {
            gMap.MapProvider = GoogleMapProvider.Instance;
            GMaps.Instance.Mode = AccessMode.ServerOnly;

            gMap.Position = new PointLatLng(3.42158, -75.7643);

            gMap.Overlays.Add(markers);
            gMap.Overlays.Add(polygons);

        }


        


                       // boton para que aparezcan los municipios
        private void button2_Click(object sender, EventArgs e)
        {
            
            markers.IsVisibile = true;
           // polygons.IsVisibile = true;
        }

        // limpiar elementos de gmaps
        private void button2_Click_1(object sender, EventArgs e)
        {
            markers.IsVisibile = false;
            polygons.Clear();
            //polygons.IsVisibile = false;
            txtSaveCoordenates.Clear();

        }

        private void cbFilter1_SelectedIndexChanged(object sender, EventArgs e)
        {
            search.Visible = false;
            textBox1.Visible = false;
            tb_menor.Visible = false;
            tb_mayor.Visible = false;
            cbCategories.Visible = false;
            mayorLabel.Visible = false;
            menorLabel.Visible = false;
            search_range.Visible = false;
            switch (cbFilter1.SelectedIndex)
            {
                case 0:
                    cbCategories.Visible = true;
                    break;
                case 1:
                    search.Visible = true;
                    textBox1.Visible = true;
                    break;
                case 2:
                    mayorLabel.Visible = true;
                    menorLabel.Visible = true;
                    tb_menor.Visible = true;
                    tb_mayor.Visible = true;
                    search_range.Visible = true;
                    break;
            }
        }

        private void cb_initialization()
        {
            
            List<Gmaps_Management.Model.Region> regions = colombia.Regions;
            Console.WriteLine("Eoooo");
            for (int i = 0; i < colombia.size; i++)
            {
                
                cbCategories.Items.Add(regions.ElementAt(i).name);
            }
            cbCategories.Items.Add("all");
            cbCategories.Visible = false;
            
        }

     

        private void cbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbCategories.SelectedIndex;
            if (index == 6)
            {
                loadGrid_Categoric();
            }
            else
            {
                List<AllTowns> listTowns = new List<AllTowns>();
                string region = colombia.Regions.ElementAt(index).name;
                List<Departament> departments = colombia.Regions.ElementAt(index).departaments;
                foreach (Departament department in departments)
                {
                    string nameDepartment = department.name;
                    int idDept = department.id;
                    List<Town> towns = department.towns;
                    foreach (Town town in towns)
                    {
                        int idTown = town.id;
                        string nameTown = town.nameTown;
                        int cantPeople = town.cantPeople;
                        int cantConfirm = town.cantConfirm;
                        string covid = town.covid;
                        double latitud = town.latitud;
                        double longitud = town.longitud;
                        AllTowns all = new AllTowns(nameTown, idTown, nameDepartment, idDept, cantPeople, covid, cantConfirm, region, latitud, longitud);
                        listTowns.Add(all);
                    }
                }
                dataGridView1.DataSource = listTowns;
                drawOnMap(listTowns);
            }
            
        }

        public void loadGrid_Categoric()
        {
            List<AllTowns> listTowns = new List<AllTowns>();
            List<Gmaps_Management.Model.Region> regions = colombia.Regions;
            foreach(Gmaps_Management.Model.Region currentRegion in regions)
            {
                
                string region = currentRegion.name;
                List<Departament> departments = currentRegion.departaments;
                foreach (Departament department in departments)
                {
                    string nameDepartment = department.name;
                    int idDept = department.id;
                    List<Town> towns = department.towns;
                    foreach (Town town in towns)
                    {
                        int idTown = town.id;
                        string nameTown = town.nameTown;
                        int cantPeople = town.cantPeople;
                        int cantConfirm = town.cantConfirm;
                        string covid = town.covid;
                        double latitud = town.latitud;
                        double longitud = town.longitud;
                        AllTowns all = new AllTowns(nameTown, idTown, nameDepartment, idDept, cantPeople, covid, cantConfirm, region, latitud, longitud);
                        listTowns.Add(all);
                    }
                }
            }
            
            dataGridView1.DataSource = listTowns;
            drawOnMap(listTowns);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            string text = textBox1.Text.ToUpper();

            List<AllTowns> listTowns = new List<AllTowns>();
            List<Gmaps_Management.Model.Region> regions = colombia.Regions;
            foreach (Gmaps_Management.Model.Region currentRegion in regions)
            {

                string region = currentRegion.name;
                List<Departament> departments = currentRegion.departaments;
                foreach (Departament department in departments)
                {
                    int idDept = department.id;
                    string nameDepartment = department.name;
                    List<Town> towns = department.towns;
                    foreach (Town town in towns)
                    {
                        if (town.nameTown.Contains(text))
                        {
                            int idTown = town.id;
                            string nameTown = town.nameTown;
                            int cantPeople = town.cantPeople;
                            int cantConfirm = town.cantConfirm;
                            string covid = town.covid;
                            double latitud = town.latitud;
                            double longitud = town.longitud;
                            AllTowns all = new AllTowns(nameTown, idTown, nameDepartment, idDept, cantPeople, covid, cantConfirm, region, latitud, longitud);
                            listTowns.Add(all);
                        }
                    }
                }
            }
            dataGridView1.DataSource = listTowns;
            drawOnMap(listTowns);
        }

        public void drawOnMap(List<AllTowns> towns)
        {
            markers.Clear();
            foreach (AllTowns town in towns)
            {
                string f = town.nameTown + ", " + town.nameDepartament + ", COLOMBIA";
                double latitud = town.latitud;
                double longitud = town.longitud;
                GeoCoderStatusCode statusCode;
                PointLatLng? point;
                if(latitud ==0 && longitud == 0)
                {
                    point =  OpenStreet4UMapProvider.Instance.GetPoint(f, out statusCode);
                }
                else
                {
                    point = new PointLatLng(latitud, longitud);
                }
                 

                if (point != null)
                {
                    GMapMarker marker00 = new GMarkerGoogle(new PointLatLng(point.Value.Lat, point.Value.Lng), GMarkerGoogleType.blue_dot);
                    marker00.ToolTipText = f + "\n " + point.Value.Lat + "\n" + point.Value.Lng;
                    markers.Markers.Add(marker00);

                }

            }
        }

        private void menorValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void search_range_Click(object sender, EventArgs e)
        {
            try
            {
                int menor = Int32.Parse(tb_menor.Text);
                int mayor = Int32.Parse(tb_mayor.Text);
                if (menor > mayor)
                {
                    int aux = menor;
                    menor = mayor;
                    mayor = aux;
                    menor = menor < 0 ? 0 : menor;
                    mayor = mayor < 0 ? 0 : mayor;
                    tb_menor.Text = menor + "";
                    tb_mayor.Text = mayor + "";
                }

                List<AllTowns> listTowns = new List<AllTowns>();
                List<Gmaps_Management.Model.Region> regions = colombia.Regions;
                foreach (Gmaps_Management.Model.Region currentRegion in regions)
                {

                    string region = currentRegion.name;
                    List<Departament> departments = currentRegion.departaments;
                    foreach (Departament department in departments)
                    {
                        int idDept = department.id;
                        string nameDepartment = department.name;
                        List<Town> towns = department.towns;
                        foreach (Town town in towns)
                        {
                            if (town.cantConfirm>=menor && town.cantConfirm<=mayor)
                            {
                                int idTown = town.id;
                                string nameTown = town.nameTown;
                                int cantPeople = town.cantPeople;
                                int cantConfirm = town.cantConfirm;
                                string covid = town.covid;
                                double latitud = town.latitud;
                                double longitud = town.longitud;
                                AllTowns all = new AllTowns(nameTown, idTown, nameDepartment, idDept, cantPeople, covid, cantConfirm, region, latitud, longitud);
                                listTowns.Add(all);
                            }
                        }
                    }
                }
                dataGridView1.DataSource = listTowns;
                drawOnMap(listTowns);

            }
            catch(FormatException t)
            {
                Console.WriteLine(t.Message);
            }
        }



        public void addMarkers() {
            foreach (PointLatLng p in points) {
                GMapMarker marker = new GMarkerGoogle(p, GMarkerGoogleType.green_dot);
                markers.Markers.Add(marker);
               
            }
        }

        public void addPolygons() {

            GMapPolygon polygon = new GMapPolygon(poligonos, "Poligono");
            polygons.Polygons.Add(polygon);
        }

        private void chartButton_Click(object sender, EventArgs e)
        {
            chartWindow = new Form2(colombia);
            chartWindow.loadBarChart();
            chartWindow.loadPieChart();
            chartWindow.loadPointChart();
            chartWindow.ShowDialog();
        }

        private void AddForm_Click(object sender, EventArgs e)
        {

            // pido latitud y longitud
<<<<<<< HEAD:Gmaps_Management/Gmaps_Management/Gui/Form1.cs
            try
            {
                double latitud = double.Parse(txtLatitud.Text);
                txtLatitud.Text = "";
                double longitud = double.Parse(txtLongitud.Text);
                txtLongitud.Text = "";
=======
            double latitud = Double.Parse(Regex.Replace(txtLatitud.Text, "[.,]", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator));
           txtLatitud.Text = "";
            double longitud = Double.Parse(Regex.Replace(txtLongitud.Text, "[.,]", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator));
            txtLongitud.Text = "";
>>>>>>> 2ddac05e885804ed8ebbde7ba19b75962d7fe0b3:Gmaps_Management/Gmaps_Management/Form1.cs

                txtSaveCoordenates.Text = "Latitud: " + latitud + "   Longitud:" + longitud;
                PointLatLng p = new PointLatLng(latitud, longitud);



<<<<<<< HEAD:Gmaps_Management/Gmaps_Management/Gui/Form1.cs
                if (cbMap.SelectedIndex == 0)
                {
                    // Console.WriteLine("entre");
                    points.Add(p);
                    addMarkers();

                    gMap.Position = new PointLatLng(latitud, longitud);
=======
            if (cbMap.SelectedIndex == 0) {
               // Console.WriteLine("entre");
                points.Add(p);
                addMarkers();
            
                gMap.Position = new PointLatLng(latitud, longitud);
>>>>>>> 2ddac05e885804ed8ebbde7ba19b75962d7fe0b3:Gmaps_Management/Gmaps_Management/Form1.cs

                if (!markers.IsVisibile)
                {
                    markers.IsVisibile = true;
                }

<<<<<<< HEAD:Gmaps_Management/Gmaps_Management/Gui/Form1.cs
                }
                else if (cbMap.SelectedIndex == 1)
                {
                    poligonos.Add(p);
                    addPolygons();

                }

=======
            } else if (cbMap.SelectedIndex==1){
                poligonos.Add(p);
                addPolygons();
                
                gMap.Position = new PointLatLng(latitud, longitud);
>>>>>>> 2ddac05e885804ed8ebbde7ba19b75962d7fe0b3:Gmaps_Management/Gmaps_Management/Form1.cs
            }
            catch(FormatException t)
            {
                Console.WriteLine(t.Message);
            }




<<<<<<< HEAD:Gmaps_Management/Gmaps_Management/Gui/Form1.cs
=======


            
            
           
>>>>>>> 2ddac05e885804ed8ebbde7ba19b75962d7fe0b3:Gmaps_Management/Gmaps_Management/Form1.cs
        }

        private void txBoxload2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
