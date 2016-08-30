using SmartHouseMVC.Models.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmartHouseMVC.Models.DBClas
{
    public class AudioPlayerdb
    {
        Music directioMusic;
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

        public string Trec
        {
            get
            {
                return directioMusic.ToString();
            }
            set
            {
            }
        }

        public void NextTrec()
        {
            if (directioMusic == Music.trec10)
            {
                directioMusic = Music.trec1;
            }
            else { directioMusic++; }

        }

        public void PreviousTrec()
        {
            if (directioMusic == Music.trec0)
            {
                directioMusic = Music.trec9;
            }
            else { directioMusic--; }
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