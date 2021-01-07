using System;
using System.Collections.Generic;
using System.Text;


namespace ASteroid.Models
{

    public class ConvertedObject
    {
        const String API_URL = "https://api.nasa.gov/neo/rest/v1/neo/browse?api_key=kTlB1068LXF3IZeIHqWRPhMeFSNgvZVKyPOCRoRd&fbclid=IwAR1AajND0QfAHggvOj60oLoRVcQ5BWZnL3amceYZyQmulvz2DiJrFZ4Ii8Q";
        //public string ID { get; set; }
        //public string NeoRefID { get; set; }
        //public string Name { get; set; }
        //public string NameLimited { get; set; }
        //public string Designation { get; set; }
        //public string Url { get; set; }
        //public EstimatedDiameter ED { get; set; }
        //public bool IsHazardous { get; set; }
        //public bool IsSentryObj { get; set; }

        public Links links { get; set; }

        public IList<Asteroidy> near_earth_objects { get; set; }
    }

    public class Links
    {
        public string next { get; set; }
        public string self { get; set; }
    }

    public class Asteroidy
    {
        public string id { get; set; }
        public string name { get; set; }

    }

}

