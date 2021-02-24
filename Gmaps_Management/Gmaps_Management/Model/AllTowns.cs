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
