using SmartHouseMVC.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmartHouseMVC.Models.clas
{
    public class Refrigerator : Temperature, IBright
    {

        int bright;
        public Refrigerator(string name, int temprich, bool status, int bright) : base(name, temprich, status)
        {
            this.bright = bright;
        }

        public int Bright
        {
            get
            {
                return bright;
            }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    bright = value;
                }
            }
        }

        public void IncreaseBright()
        {
            Bright += 5;
        }

        public void DecreasBright()
        {
            Bright -= 5;
        }


    }
}