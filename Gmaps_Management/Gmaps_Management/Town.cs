using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gmaps_Management.Class
{
    public class Town
    {
        public string nameTown { get; set; }
        public int id { get; set; }
        public int cantPeople { get; set; }
        public string covid { get; set; }
        public int cantConfirm { get; set; }
        public double latitud { get; set; }
        public double longitud { get; set; }
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
