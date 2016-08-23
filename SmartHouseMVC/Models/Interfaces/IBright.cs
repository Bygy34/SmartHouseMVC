﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmartHouseMVC.Models.Interfaces
{
    public interface IBright
    {
        int Bright { get; set; }
        void IncreaseBright();
        void DecreasBright();
    }
}