using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmartHouseMVC.Models.Interfaces
{
    public interface IDirectionWind
    {
        string DirectionWind { get; }
        void NextDirectionWind();
        void PreviousDirectionWind();
    }
}