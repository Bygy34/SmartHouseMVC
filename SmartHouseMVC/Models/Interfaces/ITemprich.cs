using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmartHouseMVC.Models.Interfaces
{
    public interface ITemprich
    {
        int Temprich { get; set; }
        void IncreaseTempriche();
        void DecreasTempriche();
    }
}