using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using Newtonsoft.Json;
using ETSU.CampusTour.SharedLibrary.Models;

namespace ETSUGuidedTourApp.Web.Controllers
{
    public class BuildingController : Controller
    {
        private readonly HttpClient _httpClient;
        private readonly string _apiUrl = "https://localhost:7246/api/Building";

        public BuildingController(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        // Retrieves a list of buildings from the Building API and returns them to the Index view as the model.

        public async Task<IActionResult> Index()
        {
            var response = await _httpClient.GetAsync(_apiUrl);
            if (response.IsSuccessStatusCode)
            {
                var buildingJson = await response.Content.ReadAsStringAsync();
                var building = JsonConvert.DeserializeObject<List<Building>>(buildingJson);
                return View(building);
            }

            return BadRequest();
        }

        // Retrieves the details of a specific building with the given id from the Building API and returns them to the Details view as the model.

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

        // Returns the Create view for creating a new building.

        public IActionResult Create()
        {
            return View();
        }

        // Sends a new building to the Building API to be created and redirects to the Index view.

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Building_Id,Building_Name,Building_Description")] Building building)
        {
            var buildingJson = JsonConvert.SerializeObject(building);
            var content = new StringContent(buildingJson, System.Text.Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync(_apiUrl, content);
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction(nameof(Index));
            }

            return BadRequest();
        }

        // Retrieves the details of a specific building with the given id from the Building API and returns them to the Edit view as the model.

        public async Task<IActionResult> Edit(int id)
        {
            var response = await _httpClient.GetAsync($"{_apiUrl}/{id}");
            if (response.IsSuccessStatusCode)
            {
                var buildingJson = await response.Content.ReadAsStringAsync();
                var building = JsonConvert.DeserializeObject<Tour>(buildingJson);
                return View(building);
            }

            return NotFound();
        }

    }

}
