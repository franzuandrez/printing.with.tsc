using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TSCLIB_DLL_IN_C_Sharp.Models;

namespace TSCLIB_DLL_IN_C_Sharp.App
{
    public class InventoryPrintoutsProcessor
    {
        private static string API_URL = Settings.Default.API_URL;
        public static async Task<List<PrintoutModel>> loadInventoryPrintous()
        {
            
            string url = $"{API_URL}/inventory_printouts";


            using ( HttpResponseMessage response = await APIHelper.APIClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    var bodyResponse = JsonConvert.DeserializeObject<JObject>(content);

                    var printouts = bodyResponse.Value<JArray>("data").ToObject<List<PrintoutModel>>();

                    return printouts;
                }
                else
                {

                    throw new Exception(response.ReasonPhrase);
                }
            }

        }
    }
}
