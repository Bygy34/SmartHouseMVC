using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SmartHouseMVC.Models.DBClas
{
    public class TechicaContext : DbContext
    {
        public DbSet<Techicadb> Techicas { get; set; }
        public DbSet<AirConditionerdb> AirConditioners { get; set; }
        public DbSet<AudioPlayerdb> AudioPlayers { get; set; }
        public DbSet<CeilingLampdb> CeilingLamps { get; set; }
        public DbSet<Refrigeratordb> Refrigerators { get; set; }
        public DbSet<TVdb> TVs { get; set; }
    }

}