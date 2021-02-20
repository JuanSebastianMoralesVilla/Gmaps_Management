using System;
using System.Collections.Generic;
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

        // to string
        public String ToString()
        { 
        return nameTown + "" + idTown+ ""+ nameDepartament + ""+ ""+ idDept+ + cantPeople + " "+ covid + " " + cantConfirm + " " + region;
        }
    }
}
