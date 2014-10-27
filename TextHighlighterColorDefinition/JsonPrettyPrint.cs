using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextHighlighterColorDefinition
{
    public class JsonPrettyPrint
    {
        public static string Format(string json) {

            try {
                var jo = JObject.Parse(json);
                var jsonString = JsonConvert.SerializeObject(jo, Formatting.Indented, new JsonConverter[] {new StringEnumConverter()});
                return jsonString;
            }
            catch(JsonReaderException jrex) {
                try{
                    var jo = JArray.Parse(json);
                    var jsonString = JsonConvert.SerializeObject(jo, Formatting.Indented, new JsonConverter[] {new StringEnumConverter()});
                    return jsonString;
                }
                catch(System.Exception ex) {
                    // fail again
                }
            }
            catch(System.Exception ex) {
                
            }
            return null;
        }
    }
}
