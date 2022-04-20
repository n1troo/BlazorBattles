﻿using System.Net.Http.Json;
using BlazorBattles.Shared;
using Blazored.Toast.Services;

namespace BlazorBattles.Client.Services
{
    public class UnitService : IUnitService
    {
        private readonly IToastService _toastService;
        private readonly HttpClient _httpClient;

        public UnitService(IToastService toastService, HttpClient httpClient)
        {
            _toastService = toastService;
            _httpClient = httpClient;
        }

        public IList<Unit>? Units { get; set; } = new List<Unit>();
        public IList<UserUnit> MyUnits { get; set; } =  new List<UserUnit>();

        public void AddUnit(int unitId)
        {
            
            var unit = Units.First(unit => unit.Id == unitId);  
            MyUnits.Add(new UserUnit { UnitId = unit.Id , HitPoints = unit.HitPoints});
         
            _toastService.ShowSuccess($"Unit {unit.Titie} added!");
        }

        public async Task LoadUnitsAsync()
        {
            // if (Units.Count == 0)
            // {
                Units = await _httpClient.GetFromJsonAsync<List<Unit>>("/api/unit");
            //}
        }
    }
}
