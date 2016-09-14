using SmartHouseMVC.Models.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmartHouseMVC.Models.DBClas
{
    public class TVdb
    {
        private int volume;
        public Chanels directionChanel;
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; }
        public virtual ICollection<Techicadb> Techicadb { get; set; }
        public Chanels Chanel
        {
            get
            {
                return directionChanel;
            }
            set
            {
                if (value>0 && (int)value <6)
                {
                    directionChanel = value;
                }
            }

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

        public void NextChanel()
        {
            directionChanel++;
        }
        
        public void PreviousChanel()
        {
            directionChanel--;
        }
    }
}