using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmartHouseMVC.Models.Interfaces
{
    public interface ICeilingLamp
    {
        int BrightLight { get; set; }
        void IncreaseBrightLight();
        void DecreasBrightLight();
    }
}