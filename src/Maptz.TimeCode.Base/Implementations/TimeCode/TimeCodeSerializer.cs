using System;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Maptz
{

    //See http://blog.maskalik.com/asp-net/json-net-implement-custom-serialization/
    public class TimeCodeSerializer : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var name = (TimeCode)value;
            writer.WriteStartObject();
            writer.WritePropertyName("totalFrames");
            serializer.Serialize(writer, name.TotalFrames);
            writer.WritePropertyName("frameRate");
            serializer.Serialize(writer, name.FrameRate);
            writer.WriteEndObject();
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            JObject jsonObject = JObject.Load(reader);
            var properties = jsonObject.Properties().ToList();
            var totalFrames = jsonObject.Property("totalFrames").Value<long>();
            var frameRate = jsonObject.Property("frameRate").Value<SmpteFrameRate>();
            return TimeCode.FromFrames(totalFrames, frameRate);
        }

        public override bool CanConvert(Type objectType)
        {
            return true;
        }
    }
}