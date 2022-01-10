using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TSCLIB_DLL_IN_C_Sharp.Models;

namespace TSCLIB_DLL_IN_C_Sharp.App
{
    public class InventoryPrintoutsProcessor
    {

        public static async Task<List<PrintoutModel>> loadInventoryPrintous()
        {
            string url = $"https://localhost/api-gomezmedical/public/api/v1/inventory_printouts";


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
