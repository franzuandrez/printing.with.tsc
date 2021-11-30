﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json; // Nuget Package
using Newtonsoft.Json.Linq;

namespace TSCLIB_DLL_IN_C_Sharp
{
    public class PendingOrdersProcessor
    {

        public static async Task<List<PurchaseModel>> LoadPendingOrders()
        {
            string url = "https://localhost/api-gomezmedical/public/api/v1/purchases?status=2";


            using (HttpResponseMessage response = await APIHelper.APIClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    string content= await response.Content.ReadAsStringAsync();
                    var bodyResponse = JsonConvert.DeserializeObject<JObject>(content);

                    var orders = bodyResponse.  Value<JArray>("data")
                        .ToObject<List<PurchaseModel>>();
                    return orders;

                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }


               

            }

            
        }
    }
}
