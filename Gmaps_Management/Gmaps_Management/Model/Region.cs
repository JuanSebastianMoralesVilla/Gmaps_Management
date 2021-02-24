using Gmaps_Management.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gmaps_Management.Model
{
    public class Region
    {
        public List<Departament> departaments { get;}
        public string name { get;}
        public int size { get; private set; }

        public Region(string region)
        {
            name = region;
            departaments = new List<Departament>();
        }
        public void add(string nameTown, int idTown, string nameDepartament, int idDept, int cantPeople, string covid, int cantConfirm,double latitud, double longitud)
        {
            Departament dept = null;

            for (int i = 0; i < size; i++)
            {
                if (departaments.ElementAt(i).id == idDept)
                {
                    dept = departaments.ElementAt(i);
                    break;
                }
            }
            if (dept == null)
            {
                dept = new Departament(nameDepartament, idDept);
                departaments.Add(dept);
                size++;
            }

            dept.add(nameTown, idTown, cantPeople, covid, cantConfirm,latitud,longitud);
        }
    }
}
