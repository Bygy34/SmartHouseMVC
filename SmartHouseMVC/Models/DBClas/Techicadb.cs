using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmartHouseMVC.Models.DBClas
{
    public class Techicadb
    {
        public int Id { get; set; }
        public int AirConditionerdbId { get; set; }
        public virtual AirConditionerdb AirConditionerdb { get; set; }
        public int AudioPlayerdbId { get; set; }
        public virtual AudioPlayerdb AudioPlayerdb { get; set; }
        public int CeilingLampdbId { get; set; }
        public virtual CeilingLampdb CeilingLampdb { get; set; }
        public int RefrigeratordbId { get; set; }
        public virtual Refrigeratordb Refrigeratordb { get; set; }
        public int TVdbId { get; set; }
        public virtual TVdb TVdb { get; set; }
    }
}