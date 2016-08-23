using SmartHouseMVC.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmartHouseMVC.Models.clas
{
    public class Volume : Technics, IVolume
    {
        private int volume;
        public Volume(string name, int volume, bool status) : base(name, status)
        {
            this.volume = volume;
        }


        public int Volumes
        {
            get
            {
                return volume;
            }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    volume = value;
                }
            }

        }
        public void IncreaseVolume()
        {
            Volumes++;
        }
        public void DecreasVolume()
        {
            Volumes--;
        }
    }
}