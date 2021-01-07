using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using System.Net.Http.Json;
using System.IO;
using System.Threading.Tasks;

namespace ASteroid.Models
{
    public class DataSnatcher
    {

        HttpClient client = new HttpClient();

        const String API_URL = "https://api.nasa.gov/neo/rest/v1/neo/browse?api_key=kTlB1068LXF3IZeIHqWRPhMeFSNgvZVKyPOCRoRd&fbclid=IwAR1AajND0QfAHggvOj60oLoRVcQ5BWZnL3amceYZyQmulvz2DiJrFZ4Ii8Q";
        public async Task<ConvertedObject> SnatchData()
        {
            return await client.GetFromJsonAsync<ConvertedObject>(API_URL).ConfigureAwait(false);
        }

    }
}
