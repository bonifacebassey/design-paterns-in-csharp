using System.Text;
using System.Runtime.Serialization.Json;
using System.IO;
using System.Globalization;

namespace Fischer.DataSuite.Export
{
    public class JsonConverter
    {
        public static string Serialize<T>(T source)
        {
            using (var ms = new MemoryStream()) {
                var serializer = new DataContractJsonSerializer(typeof(T), settings);
                serializer.WriteObject(ms, source);
                return Encoding.UTF8.GetString(ms.ToArray());
            }
        }

        public static T Deserialize<T>(string jsonString)
        {
            using (var ms = new MemoryStream(Encoding.UTF8.GetBytes(jsonString))) {
                var serializer = new DataContractJsonSerializer(typeof(T));
                return (T)serializer.ReadObject(ms);
            }
        }

        private static readonly DataContractJsonSerializerSettings settings = new() {
            UseSimpleDictionaryFormat = true,
            DateTimeFormat = new System.Runtime.Serialization.DateTimeFormat("s") { DateTimeStyles = DateTimeStyles.AssumeUniversal | DateTimeStyles.AllowWhiteSpaces }
        };
    }
}
