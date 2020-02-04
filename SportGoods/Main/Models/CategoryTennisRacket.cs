using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportGoods.Main.Models
{
    public class CategoryTennisRacket
    {
        public int id { get; set; }

        public string categoryName { get; set; }

        public string categoryDescription { get; set; }

        public List<TennisRacket> TennisRacket { get; set; }
    }
}
