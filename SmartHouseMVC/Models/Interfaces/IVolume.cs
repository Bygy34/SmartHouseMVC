using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmartHouseMVC.Models.Interfaces
{
    public interface IVolume
    {
        void IncreaseVolume();
        void DecreasVolume();
        int Volumes { get; set; }
    }
}