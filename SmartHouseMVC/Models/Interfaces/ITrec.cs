using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmartHouseMVC.Models.Interfaces
{
    public interface ITrec
    {
        string Trec { get; }
        void NextTrec();
        void PreviousTrec();
    }
}