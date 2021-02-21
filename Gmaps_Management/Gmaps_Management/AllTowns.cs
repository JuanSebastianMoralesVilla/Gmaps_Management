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
        public double latitud { get; set; }
        public double longitud { get; set; }
       
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
        }

        // to string
        override
        public String ToString()
        { 
        return nameTown + "" + idTown+ ""+ nameDepartament + ""+ ""+ idDept+ + cantPeople + " "+ covid + " " + cantConfirm + " " + region;
        }
    }
}
