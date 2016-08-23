using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmartHouseMVC.Models.Interfaces
{
    public interface ISpeedWind
    {
        int SpeedWind { get; set; }
        void IncreaseSpeedWind();
        void DecreasSpeedWind();
    }
}