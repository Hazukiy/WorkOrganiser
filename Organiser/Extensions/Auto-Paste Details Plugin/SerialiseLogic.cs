using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Organiser.Models;

namespace Organiser.Extensions.Auto_Paste_Details_Plugin
{
    public class SerialiseLogic
    {
        public static SerialiseLogic _instance;

        public static SerialiseLogic Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SerialiseLogic();
                }

                return _instance;
            }
        }


        public string ConvertToJSON(ConnectionDetails conDetails)
        {
            var details = new SerialisedConnectionDetails()
            {
                Host = conDetails.Host,
                Port = conDetails.Port,
                Username = conDetails.Username,
                Password = conDetails.Password
            };

            return JsonConvert.SerializeObject(details);
        }
    }
}
