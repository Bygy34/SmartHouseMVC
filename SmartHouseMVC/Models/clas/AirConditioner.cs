using SmartHouseMVC.Models.enums;
using SmartHouseMVC.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmartHouseMVC.Models.clas
{
    public class AirConditioner : Temperature, ISpeedWind, IDirectionWind
    {
        private int speedWind;
        private DirectionWinds directionWind;
        public AirConditioner(string name, int temprich, int speedWind, DirectionWinds direction, bool status) : base(name, temprich, status)
        {
            directionWind = direction;
            this.speedWind = speedWind;
        }

        public int SpeedWind
        {
            get
            {
                return speedWind;
            }
            set
            {
                if (value >= 0 && value <= 12)
                {
                    speedWind = value;
                }
            }
        }

        public void IncreaseSpeedWind()
        {
            SpeedWind++;
        }
        public void DecreasSpeedWind()
        {
            SpeedWind--;
        }


        public string DirectionWind
        {
            get
            {
                return directionWind.ToString();
            }

        }

        public void NextDirectionWind()
        {
            if (directionWind == DirectionWinds.right)
            {
                directionWind = DirectionWinds.top;
            }
            else { directionWind++; }
        }

        public void PreviousDirectionWind()
        {
            if (directionWind == DirectionWinds.right)
            {
                directionWind = DirectionWinds.top;
            }
            else { directionWind++; }
        }
    }
}