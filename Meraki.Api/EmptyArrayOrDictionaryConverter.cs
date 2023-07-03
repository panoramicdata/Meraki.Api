// this a modified version of this SO-answer: https://stackoverflow.com/a/45505097/14072498
public class EmptyArrayOrDictionaryConverter : JsonConverter
{
	public override bool CanConvert(Type objectType) => objectType.IsAssignableFrom(typeof(Dictionary<string, object>));

	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
	{
		var token = JToken.Load(reader);
		return token.Type switch
		{
			JTokenType.Object => token.ToObject(objectType, serializer),
			JTokenType.Array when !token.HasValues => Activator.CreateInstance(objectType),
			_ => throw new JsonSerializationException("Object or empty array expected")
		};
	}

	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) => serializer.Serialize(writer, value);
}