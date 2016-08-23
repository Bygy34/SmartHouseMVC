using SmartHouseMVC.Models.clas;
using SmartHouseMVC.Models.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SmartHouseMVC.Models.Interfaces;
using SmartHouseMVC.Models;

namespace SmartHouseMVC.Controllers
{
    public class MyController : Controller
    {

        public ActionResult Index()
        {
            IDictionary<int, Technics> TecnicaDictionary;

            if (Session["Technics"] == null)
            {
                TecnicaDictionary = new SortedDictionary<int, Technics>();
                TecnicaDictionary.Add(1, new TV("TV", 10, Chanels.M1, false));
                TecnicaDictionary.Add(2, new AudioPlayer("Магнитофон", 13, Music.trec1, false));
                TecnicaDictionary.Add(3, new AirConditioner("Кондиционер", 28, 2, DirectionWinds.down, false));
                TecnicaDictionary.Add(4, new Refrigerator("Холодильник", 7, false, 30));
                TecnicaDictionary.Add(5, new CeilingLamp("Торшер", 100, false));

                Session["Technics"] = TecnicaDictionary;
                Session["NextId"] = 6;
            }
            else
            {
                TecnicaDictionary = (SortedDictionary<int, Technics>)Session["Technics"];
            }

            SelectListItem[] TechnicsList = new SelectListItem[5];
            TechnicsList[0] = new SelectListItem { Text = "Холодильник", Value = "Refrigerator", Selected = true };
            TechnicsList[1] = new SelectListItem { Text = "Телевизор", Value = "TV" };
            TechnicsList[2] = new SelectListItem { Text = "Магнитофон", Value = "AudioPlayer" };
            TechnicsList[3] = new SelectListItem { Text = "Кондиционер", Value = "AirCondition" };
            TechnicsList[4] = new SelectListItem { Text = "Люстра", Value = "CeilingLamp" };
            ViewBag.TecnicaList = TechnicsList;
            return View(TecnicaDictionary);
        }

        public ActionResult Add(string TecnicaType)
        {
            Technics newTecnica;

            switch (TecnicaType)
            {
                default:
                    newTecnica = new Refrigerator("Холодильник", 7, false, 30);
                    break;
                case "TV":
                    newTecnica = new TV("Телевизор", 10, Chanels.M1, false);
                    break;
                case "AudioPlayer":
                    newTecnica = new AudioPlayer("Магнитофон", 13, Music.trec1, false);
                    break;
                case "AirCondition":
                    newTecnica = new AirConditioner("Кондиционер", 28, 2, DirectionWinds.down, false);
                    break;
                case "CeilingLamp":
                    newTecnica = new CeilingLamp("Люстра", 80, true);
                    break;
            }
            int id = (int)Session["NextId"];
            IDictionary<int, Technics> TecnicaDictionary = (SortedDictionary<int, Technics>)Session["Technics"];
            TecnicaDictionary.Add(id, newTecnica);
            id++;
            Session["NextId"] = id;
            return RedirectToAction("Index");
        }

        public ActionResult On(int id)
        {
            IDictionary<int, Technics> TecnicaDictionary = (SortedDictionary<int, Technics>)Session["Technics"];
            TecnicaDictionary[id].status=true;
            return RedirectToAction("Index");
        }

        public ActionResult Off(int id)
        {
            IDictionary<int, Technics> TecnicaDictionary = (SortedDictionary<int, Technics>)Session["Technics"];
            TecnicaDictionary[id].status = false;
            return RedirectToAction("Index");
        }

        public ActionResult IncreaseVolume(int id)
        {
            IDictionary<int, Technics> TecnicaDictionary = (SortedDictionary<int, Technics>)Session["Technics"];
            ((IVolume)TecnicaDictionary[id]).IncreaseVolume();
            return RedirectToAction("Index");
        }

        public ActionResult DecreasVolume(int id)
        {
            IDictionary<int, Technics> TecnicaDictionary = (SortedDictionary<int, Technics>)Session["Technics"];
            ((IVolume)TecnicaDictionary[id]).DecreasVolume();
            return RedirectToAction("Index");
        }

        public ActionResult ChanelNext(int id)
        {
            IDictionary<int, Technics> TecnicaDictionary = (SortedDictionary<int, Technics>)Session["Technics"];
            ((IChanel)TecnicaDictionary[id]).NextChanel();
            return RedirectToAction("Index");
        }

        public ActionResult ChanelPrevious(int id)
        {
            IDictionary<int, Technics> TecnicaDictionary = (SortedDictionary<int, Technics>)Session["Technics"];
            ((IChanel)TecnicaDictionary[id]).PreviousChanel();
            return RedirectToAction("Index");
        }

        public ActionResult TrecNext(int id)
        {
            IDictionary<int, Technics> TecnicaDictionary = (SortedDictionary<int, Technics>)Session["Technics"];
            ((ITrec)TecnicaDictionary[id]).NextTrec();
            return RedirectToAction("Index");
        }

        public ActionResult TrecPrevious(int id)
        {
            IDictionary<int, Technics> TecnicaDictionary = (SortedDictionary<int, Technics>)Session["Technics"];
            ((ITrec)TecnicaDictionary[id]).PreviousTrec();
            return RedirectToAction("Index");
        }

        public ActionResult IncreaseBright(int id)
        {
            IDictionary<int, Technics> TecnicaDictionary = (SortedDictionary<int, Technics>)Session["Technics"];
            ((IBright)TecnicaDictionary[id]).IncreaseBright();
            return RedirectToAction("Index");
        }

        public ActionResult DecreasBright(int id)
        {
            IDictionary<int, Technics> TecnicaDictionary = (SortedDictionary<int, Technics>)Session["Technics"];
            ((IBright)TecnicaDictionary[id]).DecreasBright();
            return RedirectToAction("Index");
        }

        public ActionResult IncreaseTempriche(int id)
        {
            IDictionary<int, Technics> TecnicaDictionary = (SortedDictionary<int, Technics>)Session["Technics"];
            ((ITemprich)TecnicaDictionary[id]).IncreaseTempriche();
            return RedirectToAction("Index");
        }

        public ActionResult DecreasTempriche(int id)
        {
            IDictionary<int, Technics> TecnicaDictionary = (SortedDictionary<int, Technics>)Session["Technics"];
            ((ITemprich)TecnicaDictionary[id]).DecreasTempriche();
            return RedirectToAction("Index");
        }

        public ActionResult NextDirectionWind(int id)
        {
            IDictionary<int, Technics> TecnicaDictionary = (SortedDictionary<int, Technics>)Session["Technics"];
            ((IDirectionWind)TecnicaDictionary[id]).NextDirectionWind();
            return RedirectToAction("Index");
        }

        public ActionResult PreviousDirectionWind(int id)
        {
            IDictionary<int, Technics> TecnicaDictionary = (SortedDictionary<int, Technics>)Session["Technics"];
            ((IDirectionWind)TecnicaDictionary[id]).PreviousDirectionWind();
            return RedirectToAction("Index");
        }

        public ActionResult IncreaseSpeedWind(int id)
        {
            IDictionary<int, Technics> TecnicaDictionary = (SortedDictionary<int, Technics>)Session["Technics"];
            ((ISpeedWind)TecnicaDictionary[id]).IncreaseSpeedWind();
            return RedirectToAction("Index");
        }

        public ActionResult DecreasSpeedWind(int id)
        {
            IDictionary<int, Technics> TecnicaDictionary = (SortedDictionary<int, Technics>)Session["Technics"];
            ((ISpeedWind)TecnicaDictionary[id]).DecreasSpeedWind();
            return RedirectToAction("Index");
        }
        public ActionResult DecreasBrightLight(int id)
        {
            IDictionary<int, Technics> TecnicaDictionary = (SortedDictionary<int, Technics>)Session["Technics"];
            ((ICeilingLamp)TecnicaDictionary[id]).DecreasBrightLight();
            return RedirectToAction("Index");
        }

        public ActionResult IncreaseBrightLight(int id)
        {
            IDictionary<int, Technics> TecnicaDictionary = (SortedDictionary<int, Technics>)Session["Technics"];
            ((ICeilingLamp)TecnicaDictionary[id]).IncreaseBrightLight();
            return RedirectToAction("Index");
        }
        
    }
}
