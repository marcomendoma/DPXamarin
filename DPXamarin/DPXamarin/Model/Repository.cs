using System.Collections.Generic;
using System.Threading.Tasks;

namespace DPXamarin.Model
{
    public class Repository
    {
        public async Task<List<Comic>> GetComics() {
            List<Comic> Comics;

            var URLWebAPI = "http://gateway.marvel.com:80/v1/public/comics?apikey=a2cfff2c08621b9d7a829ca6c4cb0828";

            using (var Client = new System.Net.Http.HttpClient()) {
                var JSON = await Client.GetStringAsync(URLWebAPI);
                Comics = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Comic>>(JSON);
            }

            return Comics;
        }
    }
}
