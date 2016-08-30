using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmartHouseMVC.Models.DBClas
{
    public class CeilingLampdb
    {
        private int brightnessLight;
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; }
        public virtual ICollection<Techicadb> Techicadb { get; set; }
        public int BrightLight
        {
            get
            {
                return brightnessLight;
            }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    brightnessLight = value;
                }
            }
        }

        public void IncreaseBrightLight()
        {
            BrightLight += 5;
        }

        public void DecreasBrightLight()
        {
            BrightLight -= 5;
        }
    }
}