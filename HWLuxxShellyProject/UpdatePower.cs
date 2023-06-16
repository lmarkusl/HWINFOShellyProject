using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace HWLuxxShellyProject
{



    internal class UpdatePower
    {
        private int Power;
        private RestClient client;
        bool isItPlus;


        public int PowerGet { get => Power; }

        public UpdatePower(string URL, bool lo_isItPlus)
        {
            Power = 10;
            client = new RestClient(URL);
            isItPlus = lo_isItPlus;

        }



        public void refresh()
        {
            //string response3 = "{\"wifi_sta\":{\"connected\":true,\"ssid\":\"godzilla\",\"ip\":\"192.168.0.254\",\"rssi\":-56},\"cloud\":{\"enabled\":true,\"connected\":true},\"mqtt\":{\"connected\":false},\"time\":\"13:43\",\"unixtime\":1667393031,\"serial\":4906,\"has_update\":false,\"mac\":\"4022D882E91D\",\"cfg_changed_cnt\":8,\"actions_stats\":{\"skipped\":0},\"relays\":[{\"ison\":true,\"has_timer\":false,\"timer_started\":0,\"timer_duration\":0,\"timer_remaining\":0,\"overpower\":false,\"source\":\"http\"}],\"meters\":[{\"power\":186.84,\"overpower\":0.00,\"is_valid\":true,\"timestamp\":1667396631,\"counters\":[201.033, 185.369, 207.807],\"total\":189918}],\"temperature\":32.10,\"overtemperature\":false,\"tmp\":{\"tC\":32.10,\"tF\":89.78, \"is_valid\":true},\"update\":{\"status\":\"idle\",\"has_update\":false,\"new_version\":\"20221027-101131/v1.12.1-ga9117d3\",\"old_version\":\"20221027-101131/v1.12.1-ga9117d3\"},\"ram_total\":52072,\"ram_free\":40180,\"fs_size\":233681,\"fs_free\":166664,\"uptime\":87240}";
            //dynamic obj2 = JsonConvert.DeserializeObject<dynamic>(response3);
            //Power = obj2.meters[0].power;
            if (!isItPlus) { 
            var response = client.Execute(new RestRequest());
            dynamic obj = JsonConvert.DeserializeObject<dynamic>(response.Content);
            Power = obj.meters[0].power;
            }else{
                //string response3 = "{\"id\":0, \"source\":\"HTTP\", \"output\":true, \"apower\":106.4, \"voltage\":231.1, \"current\":0.544,\"aenergy\":{\"total\":980.185,\"by_minute\":[1071.560,65.489,40.436],\"minute_ts\":1686864691},\"temperature\":{\"tC\":40.1, \"tF\":104.1}}";
                var response = client.Execute(new RestRequest());
                dynamic obj = JsonConvert.DeserializeObject<dynamic>(response.Content);
                Power = obj.apower;

            }
        }




    }


}
