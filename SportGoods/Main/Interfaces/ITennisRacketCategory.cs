using SportGoods.Main.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportGoods.Main.Interfaces
{
    public interface ITennisRacketCategory
    {
        IEnumerable<CategoryTennisRacket> AllTennisRacketCategories { get; }
    }
}
