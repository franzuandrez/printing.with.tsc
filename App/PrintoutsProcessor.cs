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
    public class PrintoutsProcessor
    {

        public static async Task<List<PrintoutModel>> LoadPrintouts(int docId)
        {
            string url = $"https://localhost/api-gomezmedical/public/api/v1/pending_printouts/{docId}";


            using (HttpResponseMessage response = await APIHelper.APIClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    var bodyResponse = JsonConvert.DeserializeObject<JObject>(content);

                    var printouts = bodyResponse.Value<JArray>("data")
                        .ToObject<List<PrintoutModel>>();
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
