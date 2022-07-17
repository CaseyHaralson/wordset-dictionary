using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace Editor
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var dictionaryFolderPath = "../../../../../data/";

            string filename = "a.json";


            using FileStream openStream = File.OpenRead(dictionaryFolderPath + filename);
            using StreamReader sr = new StreamReader(openStream);
            var text = sr.ReadToEnd();
            var test = JsonConvert.DeserializeObject<dynamic>(text);


            var sw = new StreamWriter(filename.Replace("json", "txt"));
            foreach (var item in (Newtonsoft.Json.Linq.JObject)test)
            {
                sw.WriteLine(item.Key);
            }


            var d = "";
        }
    }
}
