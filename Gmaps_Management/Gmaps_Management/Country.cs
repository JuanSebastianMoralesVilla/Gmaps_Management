using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gmaps_Management.Class
{
    public class Country {

        private List<Departament> regions { get; set; }
        public int size { get; set; }


        public Country() {
            regions = new List<Departament>();
            size = 0;
        }


        public void add(string nameTown, int idTown, string nameDepartament,int idDept, int cantPeople, string covid, int cantConfirm, string region)
        {
            Region region = null;
          
            for (int i = 0; i < size; i++)
            {
                if (regions.ElementAt(i).id == idDept)
                {
                    region = regions.ElementAt(i);
                    break;
                }
            }
            if (region == null)
            {
                region = new Departament(nameDepartament,idDept);
                regions.Add(region);
                size++;
            }

            region.add(nameTown,idTown,cantPeople,covid,cantConfirm);
        }
    }

    
}
