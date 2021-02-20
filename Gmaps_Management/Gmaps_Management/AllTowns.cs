using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gmaps_Management.Class
{
    public class AllTowns
    {
       // nombre municipio
        public string nameTown { get; set; }
        public int idTown { get; set; }

        public string nameDepartament { get; set; }
        public int idDept { get; set; }


        public int cantPeople { get; set; }

        public string covid { get; set; }

        public int cantConfirm { get; set; }

        public string region { get; set; }

        private const String path = "..\\..\\..\\Data\\Colombia_COVID19_Coronavirus_Municipio.csv";
         List<String> listTowns;
       
        public AllTowns(string nameTown, int idTown, string nameDepartament,int idDept, int cantPeople, string covid, int cantConfirm, string region)
        {
            this.nameTown = nameTown;
            this.idTown = idTown;
            this.nameDepartament = nameDepartament;
            this.idDept = idDept;
            this.cantPeople = cantPeople;
            this.covid = covid;
            this.cantConfirm = cantConfirm;
            this.region = region;
            
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
            while (!reader.EndOfStream && count < 150) { 
                var line = reader.ReadLine();
                var array = line.Split(';');
                listTowns.Add(array[0] +", "+ array[2] + ", COLOMBIA");
                count++;
            }
        }
        public List<String> getListTowns() {
            return listTowns;
            
        }


    }
}
