using BodegaVinos.Models;

namespace BodegaVinos.Repositories
{
    public class WineRepository
    {
        public List<Wine> Wines = new List<Wine>
        {
            new Wine { Id = 1, Name = "Cabernet Sauvignon", Variety = "Tinto", Year = 2018, Region = "Mendoza", Stock = 150 },
            new Wine { Id = 2, Name = "Malbec", Variety = "Tinto", Year = 2019, Region = "La Rioja", Stock = 200 },
            new Wine { Id = 3, Name = "Chardonnay", Variety = "Blanco", Year = 2020, Region = "San Juan", Stock = 80 },
            new Wine { Id = 4, Name = "Pinot Noir", Variety = "Tinto", Year = 2017, Region = "Patagonia", Stock = 120 },
            new Wine { Id = 5, Name = "Sauvignon Blanc", Variety = "Blanco", Year = 2018, Region = "Salta", Stock = 50 },
            new Wine { Id = 6, Name = "Syrah", Variety = "Tinto", Year = 2021, Region = "Mendoza", Stock = 90 },
            new Wine { Id = 7, Name = "Merlot", Variety = "Tinto", Year = 2016, Region = "La Rioja", Stock = 70 },
            new Wine { Id = 8, Name = "Tempranillo", Variety = "Tinto", Year = 2015, Region = "Castilla-La Mancha", Stock = 30 },
            new Wine { Id = 9, Name = "Rosé", Variety = "Rosado", Year = 2021, Region = "Provence", Stock = 40 },
            new Wine { Id = 10, Name = "Carmenere", Variety = "Tinto", Year = 2019, Region = "Valle de Colchagua", Stock = 60 }
        };
    }
}
