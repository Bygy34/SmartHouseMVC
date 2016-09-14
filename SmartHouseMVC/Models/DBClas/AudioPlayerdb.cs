using SmartHouseMVC.Models.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmartHouseMVC.Models.DBClas
{
    public class AudioPlayerdb
    {
        private Music directioMusic;
        private int volume;
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; }
        public virtual ICollection<Techicadb> Techicadb { get; set; }
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

        public Music Trec
        {
            get
            {
                return directioMusic;
            }
            set
            {
                if (value > 0 && (int)value < 11)
                {
                    directioMusic = value;
                }
            }
        }

        public void NextTrec()
        {
            directioMusic++; 
        }

        public void PreviousTrec()
        {
            directioMusic--;
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