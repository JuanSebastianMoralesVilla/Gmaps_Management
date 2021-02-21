using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gmaps_Management.Class
{
    public class Departament

    {

        public List<Town> towns{get; set;}
        public string name { get; set; }

        public int id { get; set; }


        private int size { get;set; }

        public Departament( string name, int id)
        {
            towns = new List<Town>();
            this.name = name;
            this.id= id;
            size = 0;
        }
        public void add(string nameTown, int id, int cantPeople, string covid, int cantConfirm, double latitud, double longitud) {
            Town town = new Town(nameTown, id, cantPeople, covid, cantConfirm,latitud,longitud);
            towns.Add(town);
            size++;
        }
    }
}
