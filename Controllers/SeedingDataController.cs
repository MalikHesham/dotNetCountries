using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Text.Json.Serialization;
using RestSharp;
using Newtonsoft.Json;

namespace CountriesAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SeedingDataController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public SeedingDataController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet("AddCountriesAsync")]
        public async Task<IActionResult> AddCountriesAsync()
        {
            var client = new RestSharp.RestClient("https://countriesnow.space/api/v0.1/countries/population");
            var request = new RestRequest();
            request.Method = Method.Get;
            RestResponse response = await client.ExecuteAsync(request);
            var responseString = response.Content;


            return Ok(
                responseString
                );
        }
    }
}
