using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmartHouseMVC.Models.Interfaces
{
    public interface ITecnica
    {
        string Name { get; set; }
        bool status { get; set; }
    }
}