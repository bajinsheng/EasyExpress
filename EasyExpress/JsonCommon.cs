using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace EasyExpress
{
    class JsonCommon
    {
        public static information SelectDictionary(Stream streamResult)
        {
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(information));
            return (information)serializer.ReadObject(streamResult);//Deserialize<Dictionary<string, object>>(json);
        }
    }
}
