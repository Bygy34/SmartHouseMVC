using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmartHouseMVC.Models.DBClas
{
    public class Refrigeratordb
    {
        private int bright;
        private int temperature;
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; }
        public virtual ICollection<Techicadb> Techicadb { get; set; }
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

        public int Temprich
        {
            get
            {
                return temperature;
            }
            set
            {
                if (value >= 5 && value <= 27)
                {
                    temperature = value;
                }
            }
        }

        public void IncreaseTempriche()
        {
            Temprich++;
        }

        public void DecreasTempriche()
        {
            Temprich--;
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