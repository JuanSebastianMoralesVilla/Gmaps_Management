using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gmaps_Management.Class
{
    public class Country {

        private List<Departament> departaments { get; set; }
        public int size { get; set; }


        public Country() {
            departaments = new List<Departament>();
            size = 0;
        }


        public void add(string nameTown, int idTown, string nameDepartament,int idDept, int cantPeople, string covid, int cantConfirm, string region)
        {
            Departament dept = null;
          
            for (int i = 0; i < size; i++)
            {
                if (departaments.ElementAt(i).id == idDept)
                {
                    dept= departaments.ElementAt(i);
                    break;
                }
            }


            if (dept == null)
            {
                dept = new Departament(nameDepartament,idDept);
                departaments.Add(dept);
                size++;
            }

            dept.add(nameTown,idTown,cantPeople,covid,cantConfirm,region);
        }
    }

    
}
