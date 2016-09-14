using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;

namespace SmartHouseMVC.Models.DBClas
{
    public class TechicaContextInitializer : DropCreateDatabaseAlways<TechicaContext>
    {

        protected override void Seed(TechicaContext context)
        {
            context.Techicas.Add(new Techicadb { AirConditionerdbId = 1, AudioPlayerdbId = 1, Id = 1,CeilingLampdbId=1,RefrigeratordbId=1,TVdbId=1 });
            context.Techicas.Add(new Techicadb { AirConditionerdbId = 2, AudioPlayerdbId = 2, Id = 2, CeilingLampdbId = 2, RefrigeratordbId = 2, TVdbId = 2 });
            context.AirConditioners.Add(new AirConditionerdb { Id = 1, Name = "Кондиционер", SpeedWind = 2, Status = false, Temprich = 16 });
            context.AirConditioners.Add(new AirConditionerdb { Id = 2, Name = "Кондиционер", SpeedWind = 2, Status = false, Temprich = 16 });
            context.AudioPlayers.Add(new AudioPlayerdb { Id = 1, Name = "Магнитофон", Status = false, Volumes = 3 });
            context.AudioPlayers.Add(new AudioPlayerdb { Id = 2, Name = "Магнитофон", Status = false, Volumes = 3 });
            context.CeilingLamps.Add(new CeilingLampdb { Id =1, Name = "Люстра", Status = false, BrightLight = 90 });
            context.CeilingLamps.Add(new CeilingLampdb { Id = 2, Name = "Люcтра", Status = false, BrightLight = 90 });
            context.Refrigerators.Add(new Refrigeratordb { Id = 1, Name = "Холодильник", Status = false, Bright = 90 ,Temprich=10});
            context.Refrigerators.Add(new Refrigeratordb { Id = 2, Name = "Холодильник", Status = false, Bright = 90 ,Temprich=10});
            context.TVs.Add(new TVdb { Id = 1, Name = "Телевизор", Status = false, Volumes = 14 });
            context.TVs.Add(new TVdb { Id = 2, Name = "Телевизор", Status = false, Volumes = 14 });
            context.SaveChanges();
        }
    }
}