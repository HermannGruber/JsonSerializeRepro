using Foo.Bar;
using System;
using System.Collections.Generic;
using System.Text.Json;

namespace JsonSerialize
{
    class Program
    {
        static void Main(string[] args)
        {
            var objectToSerialize =
                new Master
                {
                    Slaves = new List<Slave>
                    {
                        new Slave
                        {
                            Bar = "779-20~1234",
                            BarBarBar = "2021.2",
                            BarBar = false
                        },
                        new Slave
                        {
                            Bar = "779-20~2345",
                            BarBarBar = "2021.2",
                            BarBar = false
                        }
                    }
                };

            var jsonoptions = new JsonSerializerOptions
            {
                WriteIndented = true,
                IgnoreNullValues = true 
            };

            var json = System.Text.Json.JsonSerializer.Serialize<Master>(objectToSerialize, jsonoptions);
            Console.WriteLine(nameof(JsonSerializer));
            Console.WriteLine(json);

            var jsonOptions2 = new Newtonsoft.Json.JsonSerializerSettings
            {
                Formatting = Newtonsoft.Json.Formatting.Indented,
                DefaultValueHandling = Newtonsoft.Json.DefaultValueHandling.Ignore
            };
            var json2 = Newtonsoft.Json.JsonConvert.SerializeObject(objectToSerialize, jsonOptions2);
            Console.WriteLine(nameof(Newtonsoft.Json.JsonConvert));
            Console.WriteLine(json2);
        }
    }
}
