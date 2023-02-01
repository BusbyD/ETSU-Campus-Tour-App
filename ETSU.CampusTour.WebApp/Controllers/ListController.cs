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
    public class ListController : Controller
    {
        private readonly HttpClient _httpClient;
        private readonly string _apiUrl = "https://localhost:7246/api/Tours";

        public ListController(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        // GET: Tours
        public async Task<IActionResult> Index()
        {
            var response = await _httpClient.GetAsync(_apiUrl);
            if (response.IsSuccessStatusCode)
            {
                var toursJson = await response.Content.ReadAsStringAsync();
                var tours = JsonConvert.DeserializeObject<List<Tour>>(toursJson);
                return View(tours);
            }

            return BadRequest();
        }

        // GET: Tours/Details/5
        public async Task<IActionResult> Details(int id)
        {
            var response = await _httpClient.GetAsync($"{_apiUrl}/{id}");
            if (response.IsSuccessStatusCode)
            {
                var tourJson = await response.Content.ReadAsStringAsync();
                var tour = JsonConvert.DeserializeObject<Tour>(tourJson);
                return View(tour);
            }

            return NotFound();
        }

        // GET: Tours/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Tours/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Tour_Id,Tour_Name,Tour_Description")] Tour tour)
        {
            var tourJson = JsonConvert.SerializeObject(tour);
            var content = new StringContent(tourJson, System.Text.Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync(_apiUrl, content);
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction(nameof(Index));
            }

            return BadRequest();
        }

        // GET: Tours/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var response = await _httpClient.GetAsync($"{_apiUrl}/{id}");
            if (response.IsSuccessStatusCode)
            {
                var tourJson = await response.Content.ReadAsStringAsync();
                var tour = JsonConvert.DeserializeObject<Tour>(tourJson);
                return View(tour);
            }

            return NotFound();
        }

    }
}
