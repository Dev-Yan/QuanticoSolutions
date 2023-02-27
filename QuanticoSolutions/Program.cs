using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Xml.Linq;
using Newtonsoft.Json.Linq;

class MainClass
{

    static void Main()
    {

        WebRequest request = WebRequest.Create("https://coderbyte.com/api/challenges/json/json-cleaning");
        WebResponse response = request.GetResponse();

        Stream dataStream = response.GetResponseStream();
        StreamReader reader = new StreamReader(dataStream);
        string responseFromServer = reader.ReadToEnd();
        JObject json = JObject.Parse(responseFromServer);
        CleanJson(json);

        Console.WriteLine(json.ToString());

        response.Close();
    }

    static void CleanJson(JObject json)
    {
        foreach (var property in json.Properties().ToList())
        {
            if (property.Value.Type == JTokenType.String)
            {
                string value = property.Value.ToString();
                if (value == "N/A" || value == "-" || string.IsNullOrWhiteSpace(value))
                {
                    property.Remove();
                }
            }
            else if (property.Value.Type == JTokenType.Array)
            {
                JArray array = (JArray)property.Value;
                for (int i = array.Count - 1; i >= 0; i--)
                {
                    if (array[i].Type == JTokenType.String)
                    {
                        string value = array[i].ToString();
                        if (value == "N/A" || value == "-")
                        {
                            array.RemoveAt(i);
                        }
                    }
                }
            }
            else if (property.Value.Type == JTokenType.Object)
            {
                CleanJson((JObject)property.Value);
            }
        }
    }
}
