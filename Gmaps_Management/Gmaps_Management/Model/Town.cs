using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gmaps_Management.Model
{
    public class Town
    {
<<<<<<< HEAD:Gmaps_Management/Gmaps_Management/Model/Town.cs
        public string nameTown { get;  }
        public int id { get;  }
        public int cantPeople { get; }
        public string covid { get; }
        public int cantConfirm { get;  }
        public double latitud { get; }
        public double longitud { get; }
=======
        public String nameTown { get; set; }
        public int id { get; set; }
        public int cantPeople { get; set; }
        public string covid { get; set; }
        public int cantConfirm { get; set; }
        public double latitud { get; set; }
        public double longitud { get; set; }
>>>>>>> 2ddac05e885804ed8ebbde7ba19b75962d7fe0b3:Gmaps_Management/Gmaps_Management/Town.cs
        public Town(string nameTown, int id, int cantPeople, string covid, int cantConfirm, double latitud, double longitud)
        {
            this.nameTown = nameTown;
            this.id = id;
            this.cantPeople = cantPeople;
            this.covid = covid;
            this.cantConfirm = cantConfirm;
            this.latitud = latitud;
            this.longitud = longitud;
        }
    }
}
