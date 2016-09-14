using SmartHouseMVC.Models.enums;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Routing;

namespace SmartHouseMVC.Models.DBClas
{
    public class AirConditionerdb
    {
        private int speedWind;
        private DirectionWinds directionWind;
        private int temperature;
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; }
        public virtual ICollection<Techicadb> Techicadb { get; set; }
        public int Temprich
        {
            get
            {
                return temperature;
            }
            set
            {
                if (value >= 5 && value <= 27)
                {
                    temperature = value;
                }
            }
        }
       
        public int SpeedWind
        {
            get
            {
                return speedWind;
            }
            set
            {
                if (value >= 0 && value <= 12)
                {
                    speedWind = value;
                }
            }
        }
        
        public DirectionWinds DirectionWind
        {
            get
            {
                return directionWind;
            }
            set
            {
                if (value > 0 && (int)value < 4)
                {
                    directionWind = value;
                }
                
            }

        }

        public void IncreaseTempriche()
        {
            Temprich++;
        }

        public void DecreasTempriche()
        {
            Temprich--;
        }

        public void IncreaseSpeedWind()
        {
            SpeedWind++;
        }

        public void DecreasSpeedWind()
        {
            SpeedWind--;
        }

        public void NextDirectionWind()
        {
            DirectionWind++;
        }
        

        public void PreviousDirectionWind()
        {
                DirectionWind--;
            
        }
    }
}