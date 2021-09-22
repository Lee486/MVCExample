using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using System.Collections.Specialized;
using System.Net.Http;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Configuration;

using MvcExample.Models;
using MvcExample.Models.ViewModels;
using MvcExample.Services;
using Newtonsoft.Json;


namespace AMIPWeb.Controllers
{
    public class AjaxController : Controller
    {
        private DataService dataService;
        private ForecastService forecastService;

        public AjaxController()
        {
            dataService = new DataService();
            forecastService = new ForecastService();
        }

        // GET: /Ajax/SupplierData
        public async Task<IActionResult> SupplierData(int? Start, int? Rows)
        {
            int start = 0;
            int rows = 10;
            if (Start != null)
            {
                start = (int)Start;
            }
            if (Rows != null)
            {
                rows = (int)Rows;
            }

            string UserName = User.Identity.Name;
            string IpAddress = Request.HttpContext.Connection.RemoteIpAddress.ToString();

            List<SupplierData> supplierData = await dataService.GetSupplierData(start, rows);
            return Json(supplierData);
        }

        // GET: /Ajax/GetSomeFood
        public async Task<IActionResult> GetSomeFood()
        {
            List<string> food = await forecastService.GetSomeFood();
            return Json(food);
        }

        public async Task<IActionResult> GetFooData()
        {
            List<TimeSeriesData> food = await forecastService.GetFooData();
            return Json(food);
        }

        // GET: /Ajax/GetCompanyProductionData
        public async Task<IActionResult> GetCompanyProductionData()
        {
            List<TimeSeriesData> food = await forecastService.GetCompanySupplierData();
            return Json(food);
        }
    } // controller

} // namespace
