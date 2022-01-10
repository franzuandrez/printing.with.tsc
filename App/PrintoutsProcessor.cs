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



        public static async Task<bool> storePrintouts( List<PrintoutModel> printouts)
        {

            string url = $"https://localhost/api-gomezmedical/public/api/v1/pending_printouts";

            var printoutsModel = new PrintoutsModel() { Printouts = printouts };
            
            using (HttpResponseMessage response = await APIHelper.APIClient.PostAsJsonAsync(url, printoutsModel))
            {
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    var bodyResponse = JsonConvert.DeserializeObject<JObject>(content);
                  
                    return true;

                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }




            }
        }

        

        public static void print( string code , string description , int quantity , LabelTypeModel label )
        {
           
           
          

            byte status = TSCLIB_DLL.usbportqueryprinter();//0 = idle, 1 = head open, 16 = pause, following <ESC>!? command of TSPL manual
            TSCLIB_DLL.openport("TSC TE200");
            byte[] result_unicode = System.Text.Encoding.GetEncoding("utf-16").GetBytes(description);
            for (int i = 0; i < quantity; i++)
            {
                sendCommand(code, result_unicode, label);
            }
           
            TSCLIB_DLL.closeport();
        }

        private static void sendCommand(string code, byte[] description, LabelTypeModel label)
        {
            
             TSCLIB_DLL.sendcommand("SIZE "+ label.Name);
             TSCLIB_DLL.sendcommand("SPEED 4");
             TSCLIB_DLL.sendcommand("DENSITY 12");
             TSCLIB_DLL.sendcommand("DIRECTION 1");
             TSCLIB_DLL.sendcommand("SET TEAR ON");
             TSCLIB_DLL.sendcommand("CODEPAGE UTF-8");
             TSCLIB_DLL.clearbuffer();
             TSCLIB_DLL.windowsfontUnicode(20, 3, 35, 0, 0, 0, "Arial", description);  
             TSCLIB_DLL.barcode("50", "50", "128", "108", "1", "0", "1", "2", code);
            
             
             TSCLIB_DLL.printlabel("1", "1");
            
        }
    }
}
