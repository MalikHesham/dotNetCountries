using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CountriesAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PopulationsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public PopulationsController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet("ByCountryId")]
        public async Task<IActionResult> getByCountryIdAsync(int countryId)
        {
            var populations = await _context.Populations.Include(m => m.Country)
                .Where(p => p.CountryId == countryId)
                .ToListAsync();

            return Ok(
                populations
            );
        }

    }
}
