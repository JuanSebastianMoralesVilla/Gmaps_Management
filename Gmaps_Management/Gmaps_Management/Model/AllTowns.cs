using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gmaps_Management.Model
{
    public class AllTowns
    {
       // nombre municipio
<<<<<<< HEAD:Gmaps_Management/Gmaps_Management/Model/AllTowns.cs
        public string nameTown { get; }
        public int idTown { get;}
        public string nameDepartament { get; }
        public int idDept { get; }
        public int cantPeople { get;}
        public string covid { get;  }
        public int cantConfirm { get; }
        public string region { get; }
        public double latitud { get; }
        public double longitud { get; }
=======
        public string nameTown { get; set; }
        public int idTown { get; set; }
        public string nameDepartament { get; set; }
        public int idDept { get; set; }
        public int cantPeople { get; set; }
        public string covid { get; set; }
        public int cantConfirm { get; set; }
        public string region { get; set; }
        public double latitud { get; set; }
        public double longitud { get; set; }

        private const String path = @"..\..\Data\Colombia_COVID19_Coronavirus_Municipio.csv";
         List<String> listTowns;
>>>>>>> 2ddac05e885804ed8ebbde7ba19b75962d7fe0b3:Gmaps_Management/Gmaps_Management/AllTowns.cs
       
        public AllTowns(string nameTown, int idTown, string nameDepartament,int idDept, int cantPeople, string covid, int cantConfirm, string region, double latitud, double longitud)
        {
            this.nameTown = nameTown;
            this.idTown = idTown;
            this.nameDepartament = nameDepartament;
            this.idDept = idDept;
            this.cantPeople = cantPeople;
            this.covid = covid;
            this.cantConfirm = cantConfirm;
            this.region = region;
            this.latitud = latitud;
            this.longitud = longitud;
        }

        public AllTowns()
        {
            listTowns = new List<String>();
            visualizationTown();
        }

        // to string
        override
        public String ToString()
        { 
        return nameTown + "" + idTown+ ""+ nameDepartament + ""+ ""+ idDept+ + cantPeople + " "+ covid + " " + cantConfirm + " " + region;
        }


        private void visualizationTown() {
            var reader = new StreamReader(File.OpenRead(path));
            int count = 0;
            while (!reader.EndOfStream && count < 100) { 
                var line = reader.ReadLine();
                var array = line.Split(',');
                listTowns.Add(array[0] +", "+ array[2] + ", COLOMBIA");
                count++;
            }
        }
        public List<String> getListTowns() {
            
            return listTowns;
            
        }


    }
}
