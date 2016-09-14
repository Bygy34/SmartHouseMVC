using SmartHouseMVC.Models.DBClas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SmartHouseMVC.Controllers
{
    public class ValuesController : ApiController
    {
        private TechicaContext db = new TechicaContext();
        public string Get()
        {
            return "value" ;
        }

        // GET: api/Default/5
        public string Get(int id)
        {
            return "value"+id;
        }

        // POST: api/Default
        public string Post([FromBody]string value)
        {
            return  "// PUT: api/Default/5";
        }

//PUT
        public string Put(int id, [FromBody]string value)
        {
            AirConditionerdb b = db.AirConditioners.Find(id);
            if (b is AirConditionerdb)
            {
                b.IncreaseTempriche();
                db.Entry(b).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
            return b.Temprich.ToString();
        }

        [Route("api/values/item/{id}")]
        public string PutDown(int id, [FromBody]string value)
        {
            AirConditionerdb b = db.AirConditioners.Find(id);
            if (b is AirConditionerdb)
            {
                b.DecreasTempriche();
                db.Entry(b).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }            
            return b.Temprich.ToString();
        }

        [Route("api/values/SWU/{id}")]
        public string PutUPSW(int? id, [FromBody]string value)
        {
            AirConditionerdb b = db.AirConditioners.Find(id);
            if (b is AirConditionerdb)
            {
                b.IncreaseSpeedWind();
                db.Entry(b).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
            return b.SpeedWind.ToString();
        }

        [Route("api/values/SWD/{id}")]
        public string PutDownSW(int? id, [FromBody]string value)
        {
            AirConditionerdb b = db.AirConditioners.Find(id);
            if (b is AirConditionerdb)
            {
                b.DecreasSpeedWind();
                db.Entry(b).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
            return b.SpeedWind.ToString();
        }

        [Route("api/values/DWU/{id}")]
        public string PutUPDW(int? id, [FromBody]string value)
        {
            AirConditionerdb b = db.AirConditioners.Find(id);
            if (b is AirConditionerdb)
            {
                b.NextDirectionWind();
                db.Entry(b).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
            return b.DirectionWind.ToString();
        }

        [Route("api/values/DWD/{id}")]
        public string PutDownDW(int? id, [FromBody]string value)
        {
            AirConditionerdb b = db.AirConditioners.Find(id);
            if (b is AirConditionerdb)
            {
                b.PreviousDirectionWind();
                db.Entry(b).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
            return b.DirectionWind.ToString();
        }


        // DELETE: api/Default/5
        public string Delete(int id)
        {
            AirConditionerdb b = db.AirConditioners.Find(id);
            if (b != null)
            {
                db.AirConditioners.Remove(b);
                db.SaveChanges();
            }
            return "Устройство удалено";
        }
    }
}
