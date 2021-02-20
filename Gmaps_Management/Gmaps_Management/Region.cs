using Gmaps_Management.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gmaps_Management
{
    class Region
    {
        public List<Departament> departaments { get; set; }
        public string name { get; set; }
        public int size { get; set; }

        public Region(string region)
        {
            name = region;
            departaments = new List<>();
        }
        public void add(string nameTown, int id, int cantPeople, string covid, int cantConfirm)
        {
            Departament dept = null;

            for (int i = 0; i < size; i++)
            {
                if (departaments.ElementAt(i).Equals(id))
                {
                    dept = departaments.ElementAt(i);
                    break;
                }
            }
            if (dept == null)
            {
                dept = new Departament( name,id);
                departaments.Add(dept);
                size++;
            }

            dept.add(nameTown, idTown, cantPeople, covid, cantConfirm, region);
        }
    }
}
