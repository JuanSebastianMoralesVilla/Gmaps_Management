﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gmaps_Management.Class
{
    public class Town
    {
        private String nameTown { get; set; }
        private  int id { get; set; }

        public int cantPeople { get; set; }

        public string covid { get; set; }

        public int cantConfirm { get; set; }

        public Town(string nameTown, int id, int cantPeople, string covid, int cantConfirm)
        {
            this.nameTown = nameTown;
            this.id = id;
            this.cantPeople = cantPeople;
            this.covid = covid;
            this.cantConfirm = cantConfirm;
        }
    }
}
