using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TSCLIB_DLL_IN_C_Sharp.Models;

namespace TSCLIB_DLL_IN_C_Sharp.DataSource
{
    public class LabelTypeProcesor
    {
        private static string API_URL = Settings.Default.API_URL;
        public static async Task<List<LabelTypeModel>> loadLabels()
        {

            string url = $"{API_URL}/labels_types";


            using (HttpResponseMessage response = await APIHelper.APIClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    var bodyResponse = JsonConvert.DeserializeObject<JObject>(content);

                    var labels = bodyResponse.Value<JArray>("data").ToObject<List<LabelTypeModel>>();

                    return labels;
                }
                else
                {

                    throw new Exception(response.ReasonPhrase);
                }
            }

        }

    }
}
