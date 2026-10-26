using BenchmarkDotNet.Attributes;
using Meraki.Api;
using Microsoft.Extensions.Logging.Abstractions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;
using System.Text;

namespace Benchmarks;

/// <summary>
/// JsonMissingMemberHandling.LogWarningOnErrorAndContinue, as it was (a strict pass that stops at the
/// first missing member, then a second pass ignoring them) against the single collecting pass,
/// on a synthetic 200-item response with and without missing members
/// </summary>
[MemoryDiagnoser]
public class MissingMemberDeserialization
{
	private const int ItemCount = 200;

	private static readonly JsonSerializerSettings ErrorSettings = new()
	{
		NullValueHandling = NullValueHandling.Ignore,
		MissingMemberHandling = MissingMemberHandling.Error,
		Converters = [new StringEnumConverter()]
	};

	private static readonly JsonSerializerSettings IgnoreSettings = new()
	{
		NullValueHandling = NullValueHandling.Ignore,
		MissingMemberHandling = MissingMemberHandling.Ignore,
		Converters = [new StringEnumConverter()]
	};

	private readonly CustomNewtonsoftJsonContentSerializer _serializer = new(
		new MerakiClientOptions
		{
			ApiKey = "0000000000000000000000000000000000000000",
			UserAgent = "Benchmarks/1.0",
			JsonMissingMemberHandling = JsonMissingMemberHandling.LogWarningOnErrorAndContinue,
			JsonMissingMembersAction = (_, _, _) => { }
		},
		NullLogger.Instance);

	private string _json = string.Empty;

	[Params(false, true)]
	public bool WithMissingMembers { get; set; }

	[GlobalSetup]
	public void Setup()
	{
		var builder = new StringBuilder("[");
		for (var i = 0; i < ItemCount; i++)
		{
			_ = builder
				.Append(i == 0 ? "" : ",")
				.Append("{\"id\":\"item-").Append(i).Append("\",\"name\":\"Item ").Append(i)
				.Append("\",\"enabled\":true,\"count\":").Append(i)
				.Append(",\"tags\":[\"a\",\"b\"],\"settings\":{\"mode\":\"auto\",\"level\":3}");
			if (WithMissingMembers && i % 50 == 49)
			{
				_ = builder.Append(",\"extra\":{\"inner\":1,\"other\":\"x\"}");
			}

			_ = builder.Append('}');
		}

		_json = builder.Append(']').ToString();
	}

	[Benchmark(Baseline = true)]
	public async Task<List<BenchmarkItem>?> Before()
	{
		using var content = new StringContent(_json);
		var sourceJson = await content.ReadAsStringAsync().ConfigureAwait(false);
		try
		{
			return JsonConvert.DeserializeObject<List<BenchmarkItem>>(sourceJson, ErrorSettings);
		}
		catch (JsonSerializationException)
		{
			return JsonConvert.DeserializeObject<List<BenchmarkItem>>(sourceJson, IgnoreSettings);
		}
	}

	[Benchmark]
	public async Task<List<BenchmarkItem>?> After()
	{
		using var content = new StringContent(_json);
		return await _serializer.FromHttpContentAsync<List<BenchmarkItem>>(content).ConfigureAwait(false);
	}

	/// <summary>
	/// A synthetic response item
	/// </summary>
	[DataContract]
	public class BenchmarkItem
	{
		[DataMember(Name = "id")]
		public string? Id { get; set; }

		[DataMember(Name = "name")]
		public string? Name { get; set; }

		[DataMember(Name = "enabled")]
		public bool? Enabled { get; set; }

		[DataMember(Name = "count")]
		public int? Count { get; set; }

		[DataMember(Name = "tags")]
		public List<string>? Tags { get; set; }

		[DataMember(Name = "settings")]
		public BenchmarkSettings? Settings { get; set; }
	}

	/// <summary>
	/// A synthetic nested object
	/// </summary>
	[DataContract]
	public class BenchmarkSettings
	{
		[DataMember(Name = "mode")]
		public string? Mode { get; set; }

		[DataMember(Name = "level")]
		public int? Level { get; set; }
	}
}
