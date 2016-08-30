using SmartHouseMVC.Models.DBClas;
using SmartHouseMVC.Models.enums;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace SmartHouseMVC.Controllers
{
    public class MyController : Controller
    {
        private TechicaContext db = new TechicaContext();
        public ActionResult Index()
        {
            SelectListItem[] TechnicsList = new SelectListItem[5];
            TechnicsList[0] = new SelectListItem { Text = "Холодильник", Value = "Refrigerator"};
            TechnicsList[1] = new SelectListItem { Text = "Телевизор", Value = "TV" };
            TechnicsList[2] = new SelectListItem { Text = "Магнитофон", Value = "AudioPlayer", Selected = true };
            TechnicsList[3] = new SelectListItem { Text = "Кондиционер", Value = "AirCondition" };
            TechnicsList[4] = new SelectListItem { Text = "Люстра", Value = "CeilingLamp" };
            ViewBag.TecnicaList = TechnicsList;
            ViewBag.AirConditioners = db.AirConditioners.ToList();
            ViewBag.AudioPlayers = db.AudioPlayers.ToList();
            ViewBag.Refrigerators = db.Refrigerators.ToList();
            ViewBag.Ceilings = db.CeilingLamps.ToList();
            ViewBag.TVs = db.TVs.ToList();
            return View();
        }

        public ActionResult Add(string TecnicaType)
        {
            switch (TecnicaType)
            {
                default:
                    db.Refrigerators.Add(new Refrigeratordb {Id=3, Name="Холодильник",Temprich= 7,Status= false, Bright=30 });
                    break;
                case "TV":
                    db.TVs.Add(new TVdb { Id = 3, Name = "Телевизор", Volumes = 10, directionChanel = Chanels.M1, Status = false });
                    break;
                case "AudioPlayer":
                    db.AudioPlayers.Add(new AudioPlayerdb { Id = 3, Name = "Магнитофон", Volumes = 9, Status = false });
                    break;
                case "AirCondition":
                    db.AirConditioners.Add(new AirConditionerdb { Id = 3, Name = "Кондиционер3", SpeedWind = 2, Status = false, Temprich = 16 });
                    break;
                case "CeilingLamp":
                    db.CeilingLamps.Add(new CeilingLampdb { Id = 3, Name = "Люстра", BrightLight = 80, Status = true });
                    break;
            }
            db.SaveChanges();
            return RedirectToAction("Index");



        }

        public ActionResult OnOff(int id)
        {
            AudioPlayerdb b = db.AudioPlayers.Find(id);

            if (b.Status == false)
            {
                b.Status = true;
            }
            else 
            {
                b.Status = false;
            }
            db.Entry(b).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult OnOffTV(int id)
        {
            TVdb b = db.TVs.Find(id);

            if (b.Status == false)
            {
                b.Status = true;
            }
            else
            {
                b.Status = false;
            }
            db.Entry(b).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult OnOffAir(int id)
        {
            AirConditionerdb b = db.AirConditioners.Find(id);

            if (b.Status == false)
            {
                b.Status = true;
            }
            else
            {
                b.Status = false;
            }
            db.Entry(b).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult OnOffCeiling(int id)
        {
            CeilingLampdb b = db.CeilingLamps.Find(id);

            if (b.Status == false)
            {
                b.Status = true;
            }
            else
            {
                b.Status = false;
            }
            db.Entry(b).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult OnOffRef(int id)
        {
            Refrigeratordb b = db.Refrigerators.Find(id);

            if (b.Status == false)
            {
                b.Status = true;
            }
            else
            {
                b.Status = false;
            }
            db.Entry(b).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult IncreaseVolume(int? id)
        {
            if (id == null) { return HttpNotFound(); }
            AudioPlayerdb b = db.AudioPlayers.Find(id);
            if (b == null) { return HttpNotFound(); }
            if (b is AudioPlayerdb)
            {
                b.DecreasVolume();
                db.Entry(b).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
        public ActionResult IncreaseVolumeTV(int? id)
        {
            if (id == null) { return HttpNotFound(); }
            TVdb b = db.TVs.Find(id);
            if (b == null) { return HttpNotFound(); }
            if (b is TVdb)
            {
                b.IncreaseVolume();
                db.Entry(b).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
        public ActionResult DecreasVolumeTV(int? id)
        {
            if (id == null) { return HttpNotFound(); }
            TVdb b = db.TVs.Find(id);
            if (b == null) { return HttpNotFound(); }
            if (b is TVdb)
            {
                b.DecreasVolume();
                db.Entry(b).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        public ActionResult DecreasVolume(int? id)
        {
            if (id == null) { return HttpNotFound(); }
            AudioPlayerdb b = db.AudioPlayers.Find(id);
            if (b == null) { return HttpNotFound(); }
            if (b is AudioPlayerdb)
            {
                b.IncreaseVolume();
                db.Entry(b).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        public ActionResult ChanelNext(int? id)
        {
            if (id == null) { return HttpNotFound(); }
            TVdb b = db.TVs.Find(id);
            if (b == null) { return HttpNotFound(); }
            if (b is TVdb)
            {
                b.NextChanel();
                db.Entry(b).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        public ActionResult ChanelPrevious(int? id)
        {
            if (id == null) { return HttpNotFound(); }
            TVdb b = db.TVs.Find(id);
            if (b == null) { return HttpNotFound(); }
            if (b is TVdb)
            {
                b.PreviousChanel();
                db.Entry(b).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        public ActionResult TrecNext(int? id)
        {
            if (id == null) { return HttpNotFound(); }
            AudioPlayerdb b = db.AudioPlayers.Find(id);
            if (b == null) { return HttpNotFound(); }
            if (b is AudioPlayerdb)
            {
                b.NextTrec();
                db.Entry(b).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        public ActionResult TrecPrevious(int? id)
        {
            if (id == null) { return HttpNotFound(); }
            AudioPlayerdb b = db.AudioPlayers.Find(id);
            if (b == null) { return HttpNotFound(); }
            if (b is AudioPlayerdb)
            {
                b.PreviousTrec();
                db.Entry(b).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        public ActionResult IncreaseBright(int? id)
        {
            if (id == null) { return HttpNotFound(); }
            Refrigeratordb b = db.Refrigerators.Find(id);
            if (b == null) { return HttpNotFound(); }
            if (b is Refrigeratordb)
            {
                b.IncreaseBright();
                db.Entry(b).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        public ActionResult DecreasBright(int? id)
        {
            if (id == null) { return HttpNotFound(); }
            Refrigeratordb b = db.Refrigerators.Find(id);
            if (b == null) { return HttpNotFound(); }
            if (b is Refrigeratordb)
            {
                b.DecreasBright();
                db.Entry(b).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        public ActionResult IncreaseTempriche(int? id)
        {
            if (id == null) { return HttpNotFound(); }
            AirConditionerdb b = db.AirConditioners.Find(id);
            if (b == null) { return HttpNotFound(); }
            if (b is AirConditionerdb)
            {
                b.IncreaseTempriche();
                db.Entry(b).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        public ActionResult DecreasTempriche(int? id)
        {
            if (id == null) { return HttpNotFound(); }
            AirConditionerdb b = db.AirConditioners.Find(id);
            if (b == null) { return HttpNotFound(); }
            if (b is AirConditionerdb)
            {
                b.DecreasTempriche();
                db.Entry(b).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        public ActionResult IncreaseTempricheRef(int? id)
        {
            if (id == null) { return HttpNotFound(); }
            Refrigeratordb b = db.Refrigerators.Find(id);
            if (b == null) { return HttpNotFound(); }
            if (b is Refrigeratordb)
            {
                b.IncreaseTempriche();
                db.Entry(b).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
        public ActionResult DecreasTempricheRef(int? id)
        {
            if (id == null) { return HttpNotFound(); }
            Refrigeratordb b = db.Refrigerators.Find(id);
            if (b == null) { return HttpNotFound(); }
            if (b is Refrigeratordb)
            {
                b.DecreasTempriche();
                db.Entry(b).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }


        public ActionResult NextDirectionWind(int? id)
        {
            if (id == null) { return HttpNotFound(); }
            AirConditionerdb b = db.AirConditioners.Find(id);
            if (b == null) { return HttpNotFound(); }
            if (b is AirConditionerdb)
            {
                b.NextDirectionWind();
                db.Entry(b).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        public ActionResult PreviousDirectionWind(int? id)
        {
            if (id == null) { return HttpNotFound(); }
            AirConditionerdb b = db.AirConditioners.Find(id);
            if (b == null) { return HttpNotFound(); }
            if (b is AirConditionerdb)
            {
                b.PreviousDirectionWind();
                db.Entry(b).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        public ActionResult IncreaseSpeedWind(int? id)
        {
            if (id == null) { return HttpNotFound(); }
            AirConditionerdb b = db.AirConditioners.Find(id);
            if (b == null) { return HttpNotFound(); }
            if (b is AirConditionerdb)
            {
                b.IncreaseSpeedWind();
                db.Entry(b).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        public ActionResult DecreasSpeedWind(int? id)
        {
            if (id == null) { return HttpNotFound(); }
            AirConditionerdb b = db.AirConditioners.Find(id);
            if (b == null) { return HttpNotFound(); }
            if (b is AirConditionerdb)
            {
                b.DecreasSpeedWind();
                db.Entry(b).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
        public ActionResult DecreasBrightLight(int? id)
        {
            if (id == null) { return HttpNotFound(); }
            CeilingLampdb b = db.CeilingLamps.Find(id);
            if (b == null) { return HttpNotFound(); }
            if (b is CeilingLampdb)
            {
                b.DecreasBrightLight();
                db.Entry(b).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        public ActionResult IncreaseBrightLight(int? id)
        {
            if (id == null) { return HttpNotFound(); }
            CeilingLampdb b = db.CeilingLamps.Find(id);
            if (b == null) { return HttpNotFound(); }
            if (b is CeilingLampdb)
            {
                b.IncreaseBrightLight();
                db.Entry(b).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }


        public ActionResult DeleteCeling(int? id)
        {
            CeilingLampdb b = db.CeilingLamps.Find(id);
            if (b != null)
            {
                db.CeilingLamps.Remove(b);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
        public ActionResult DeleteAudio(int? id)
        {
            AudioPlayerdb b = db.AudioPlayers.Find(id);
            if (b != null)
            {
                db.AudioPlayers.Remove(b);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
        public ActionResult DeleteAir(int? id)
        {
            AirConditionerdb b = db.AirConditioners.Find(id);
            if (b != null)
            {
                db.AirConditioners.Remove(b);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
        public ActionResult DeleteRef(int? id)
        {
            Refrigeratordb b = db.Refrigerators.Find(id);
            if (b != null)
            {
                db.Refrigerators.Remove(b);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
        public ActionResult DeleteTV(int? id)
        {
            TVdb b = db.TVs.Find(id);
            if (b != null)
            {
                db.TVs.Remove(b);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
        public ActionResult AllOn()
        {
            foreach(var item in db.Techicas.ToList())
            {
                item.Refrigeratordb.Status = true;
                item.TVdb.Status = true;
                item.AudioPlayerdb.Status = true;
                item.AirConditionerdb.Status = true;
                item.CeilingLampdb.Status = true;
                db.Entry(item).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }         
            return RedirectToAction("Index");
        }
        public ActionResult AllOff()
        {
            foreach (var item in db.Techicas.ToList())
            {
                item.Refrigeratordb.Status = false;
                item.TVdb.Status = false;
                item.AudioPlayerdb.Status = false;
                item.AirConditionerdb.Status = false;
                item.CeilingLampdb.Status = false;
                db.Entry(item).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
        public ActionResult OnWork()
        {
            foreach (var item in db.Techicas.ToList())
            {
                item.Refrigeratordb.Status = true;
                item.TVdb.Status = false;
                item.AudioPlayerdb.Status = false;
                item.AirConditionerdb.Status = false;
                item.CeilingLampdb.Status = false;
                db.Entry(item).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
        public ActionResult FromWork()
        {
            foreach (var item in db.Techicas.ToList())
            {
                item.Refrigeratordb.Status = true;
                item.TVdb.Status = false;
                item.AudioPlayerdb.Status = true;
                item.AudioPlayerdb.Volumes =17;
                item.AirConditionerdb.Status = true;
                item.AirConditionerdb.Temprich = 28;
                item.CeilingLampdb.Status = true;
                item.CeilingLampdb.BrightLight=90;
                db.Entry(item).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}
