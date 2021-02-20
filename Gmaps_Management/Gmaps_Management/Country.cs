using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gmaps_Management.Class
{
    public class Country
    {

        private List<Region> regions;
        public int size { get; set; }

        public Country()
        {
            regions = new List<Region>();
            size = 0;
        }


        public void add(string nameTown, int idTown, string nameDepartament, int idDept, int cantPeople, string covid, int cantConfirm, string region)
        {
            Region region1 = null;

            for (int i = 0; i < size; i++)
            {
                if (regions.ElementAt(i).name.Equals(region))
                {
                    region1 = regions.ElementAt(i);
                    break;
                }
            }
            if (region1 == null)
            {
                region1 = new Region(region);
                regions.Add(region1);
                size++;
            }

            region1.add(nameTown, idTown, nameDepartament, idDept, cantPeople,covid,cantConfirm);
        }

    }


}
