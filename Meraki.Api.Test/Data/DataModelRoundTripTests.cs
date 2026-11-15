using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Reflection;
using System.Runtime.Serialization;

namespace Meraki.Api.Test.Data;

public class DataModelRoundTripTests
{
	private static readonly JsonSerializerSettings _settings = new()
	{
		Converters = [new StringEnumConverter()],
		NullValueHandling = NullValueHandling.Ignore
	};

	private static readonly Type[] _modelTypes =
	[
		.. typeof(MerakiClient).Assembly.GetTypes()
			.Where(t => t is { IsClass: true, IsAbstract: false, IsPublic: true } && t.Namespace == "Meraki.Api.Data")
			.Where(t => !SampleValueFactory.Unconstructable.Contains(t.Name))
			.Where(t => t.GetConstructor(Type.EmptyTypes) is not null && t.GetCustomAttribute<DataContractAttribute>() is not null)
	];

	[Fact]
	public void ModelTypes_AreDiscovered()
		=> _modelTypes.Length.Should().BeGreaterThan(1000);

	[Fact]
	public void EveryModel_RoundTripsThroughJson()
	{
		var failing = _modelTypes
			.Where(type => CheckRoundTrip(type) is not null)
			.Select(type => type.Name)
			.ToHashSet();

		failing.Should().BeEquivalentTo(KnownRoundTripDefects.Names);
	}

	private static string? CheckRoundTrip(Type type)
	{
		try
		{
			var instance = SampleValueFactory.Populate(type)!;
			var json = JsonConvert.SerializeObject(instance, _settings);
			var copy = JsonConvert.DeserializeObject(json, type, _settings);

			return JsonConvert.SerializeObject(copy, _settings) == json ? null : $"{type.Name}: round trip changed the JSON";
		}
		catch (Exception ex) when (ex is JsonException or InvalidCastException or ArgumentException or InvalidOperationException)
		{
			return $"{type.Name}: {ex.Message}";
		}
	}
}
