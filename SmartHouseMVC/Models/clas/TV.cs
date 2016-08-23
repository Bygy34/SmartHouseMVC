using SmartHouseMVC.Models.enums;
using SmartHouseMVC.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmartHouseMVC.Models.clas
{
    public class TV : Volume, IChanel
    {
        public Chanels directionChanel;

        public TV(string name, int volume, Chanels chanel, bool status) : base(name, volume, status)
        {
            directionChanel = chanel;
        }

        public string Chanel
        {
            get
            {
                return directionChanel.ToString();
            }

        }

        public void NextChanel()
        {
            if (directionChanel == Chanels.inter)
            { directionChanel = Chanels.estv; }
            else { directionChanel++; }
        }


        public void PreviousChanel()
        {
            if (directionChanel == Chanels.estv)
            { directionChanel = Chanels.inter; }
            else { directionChanel--; }
        }
    }
}