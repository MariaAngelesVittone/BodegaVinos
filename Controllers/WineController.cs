using BodegaVinos.Models;
using BodegaVinos.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BodegaVinos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WineController : ControllerBase
    {
        private readonly WineRepository _wineRepository;
        public WineController(WineRepository wineRepository)
        {
            _wineRepository = wineRepository;
        }


        [HttpGet]
        public IActionResult GetWines()
        {
            return Ok(_wineRepository.Wines);
        }

        [HttpPost]
        public IActionResult CreateWine(CreateWineDTO dto)
        {
            Wine newWine = new Wine()
            {
                Id = _wineRepository.Wines.Max(x => x.Id) + 1,
                Name = dto.Name,
                Variety = dto.Variety,
                Year = dto.Year,
                Region = dto.Region,
                Stock = dto.Stock,
            };
            _wineRepository.Wines.Add(newWine);

            return Ok(newWine);
        }
    }
}
