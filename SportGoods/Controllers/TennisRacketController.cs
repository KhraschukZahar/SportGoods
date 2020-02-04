using SportGoods.Main.Interfaces;
using SportGoods.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SportGoods.Controllers
{
    public class TennisRacketController : Controller
    {
        private readonly IAllTennisRackets _allTennisRackets;
        private readonly ITennisRacketCategory _allTennisRacketCategories;
        public TennisRacketController(IAllTennisRackets iAllTennisRackets, ITennisRacketCategory ITennisRacketCategory)
        {
            _allTennisRackets = iAllTennisRackets;
            _allTennisRacketCategories = ITennisRacketCategory;
        }

        public ViewResult List()
        {
            ViewBag.Title = "TennisRackets";
            TennisRacketListViewModel obj = new TennisRacketListViewModel();
            obj.allTennisRackets = _allTennisRackets.TennisRackets;
            obj.currentCategory = "Category";
            return View(obj);
        }
    }
}
