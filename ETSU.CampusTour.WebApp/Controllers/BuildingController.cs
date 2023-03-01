using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using Newtonsoft.Json;
using ETSU.CampusTour.SharedLibrary.Models;

namespace ETSU.CampusTour.WebAPI.Controllers
{
    public class BuildingController : Controller
    {
        private readonly HttpClient _httpClient;
        private readonly string _apiUrl = "https://localhost:7246/api/Building";

        public BuildingController(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }


        // GET: Building
        public async Task<IActionResult> Index()
        {
            var response = await _httpClient.GetAsync(_apiUrl);
            if (response.IsSuccessStatusCode)
            {
                var buildingsJson = await response.Content.ReadAsStringAsync();
                var buildings = JsonConvert.DeserializeObject<List<Building>>(buildingsJson);
                return View(buildings);
            }

            return BadRequest();
        }


        // GET: Building/Details/5
        public async Task<IActionResult> Details(int id)
        {
            var response = await _httpClient.GetAsync($"{_apiUrl}/{id}");
            if (response.IsSuccessStatusCode)
            {
                var buildingJson = await response.Content.ReadAsStringAsync();
                var building = JsonConvert.DeserializeObject<Building>(buildingJson);
                return View(building);
            }

            return NotFound();
        }


    }
}
