using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gmaps_Management.Model
{
    public class Town
    {
        public string nameTown { get;  }
        public int id { get;  }
        public int cantPeople { get; }
        public string covid { get; }
        public int cantConfirm { get;  }
        public double latitud { get; }
        public double longitud { get; }
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
