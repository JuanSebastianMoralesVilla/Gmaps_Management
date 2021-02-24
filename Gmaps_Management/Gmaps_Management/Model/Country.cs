using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gmaps_Management.Model
{
    public class Country
    {

        public List<Region> Regions { get;  }
        public int size { get; private set; }

        public Country()
        {
            Regions = new List<Region>();
            size = 0;
        }

        public void add(string nameTown, int idTown, string nameDepartament, int idDept, int cantPeople, string covid, int cantConfirm, string region, double latitud, double longitud)
        {
            Region region1 = null;

            for (int i = 0; i < size; i++)
            {
                if (Regions.ElementAt(i).name.Equals(region))
                {
                    region1 = Regions.ElementAt(i);
                    break;
                }
            }
            if (region1 == null)
            {
                region1 = new Region(region);
                Regions.Add(region1);
                size++;
            }

            region1.add(nameTown, idTown, nameDepartament, idDept, cantPeople,covid,cantConfirm,latitud,longitud);
        }

        public List<Region> GetRegions()
        {
            return Regions;
        }

    }


}
