using SmartHouseMVC.Models.enums;
using SmartHouseMVC.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmartHouseMVC.Models.clas
{
    public class AudioPlayer : Volume, ITrec
    {
        Music directioMusic;
        public AudioPlayer(string name, int volume, Music Music, bool status) : base(name, volume, status)
        {
            directioMusic = Music;
        }


        public string Trec
        {
            get
            {
                return directioMusic.ToString();
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


    }
}