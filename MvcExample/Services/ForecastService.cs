using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MvcExample.Models.ViewModels;
using Newtonsoft.Json;


namespace MvcExample.Services
{
    public class ForecastService
    {
        public async Task<List<string>> GetSomeFood()
        {
            List<string> foo = new List<string>();
            foo.Add("pasta");
            foo.Add("breakfast");
            foo.Add("muffin");
            return foo;
        }

        public async Task<List<TimeSeriesData>> GetFooData()
        {
            List<TimeSeriesData> fooData = new List<TimeSeriesData>();
            string prodSampleFilePath = System.IO.Path.GetFullPath("wwwroot" + System.IO.Path.DirectorySeparatorChar + "fooData.json");
            string prodDataRawJson = System.IO.File.ReadAllText(prodSampleFilePath);
            try
            {
                fooData = JsonConvert.DeserializeObject<List<TimeSeriesData>>(prodDataRawJson);
            }
            catch (Exception ex)
            {
                //@todo return an error to the front end
            }
            return fooData;
        }

        public async Task<List<TimeSeriesData>> GetCompanySupplierData()
        {
            List<TimeSeriesData> CPData = new List<TimeSeriesData>();
            string prodSampleFilePath = System.IO.Path.GetFullPath("wwwroot" + System.IO.Path.DirectorySeparatorChar + "companyProductionData.json");
            string prodDataRawJson = System.IO.File.ReadAllText(prodSampleFilePath);
            try
            {
                CPData = JsonConvert.DeserializeObject<List<TimeSeriesData>>(prodDataRawJson);
            }
            catch (Exception ex)
            {
                //@todo return an error to the front end
            }
            return CPData;

        }
    }
}
