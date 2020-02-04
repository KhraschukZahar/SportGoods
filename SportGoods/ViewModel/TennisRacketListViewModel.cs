using SportGoods.Main.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportGoods.ViewModel
{
    public class TennisRacketListViewModel
    {
        public IEnumerable<TennisRacket> allTennisRackets { get; set; }
        public string currentCategory { get; set; }
    }
}
