using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmartHouseMVC.Models.clas
{
    public abstract class Technics
    {
        private bool technicalStatus;
        public bool status
        {
            get
            {
                return technicalStatus;
            }
            set
            {
                technicalStatus = value;
            }
        }

        public Technics(string name, bool status)
        {
            Name = name;
            technicalStatus = status;
        }
        public string Name { get; set; }

    }
}