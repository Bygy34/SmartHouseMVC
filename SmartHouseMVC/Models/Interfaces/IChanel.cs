using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmartHouseMVC.Models.Interfaces
{
    public interface IChanel
    {
        string Chanel { get; }
        void NextChanel();
        void PreviousChanel();
    }
}