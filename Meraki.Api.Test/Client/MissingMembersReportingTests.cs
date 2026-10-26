using Meraki.Api.Exceptions;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace Meraki.Api.Test.Client;

/// <summary>
/// Every member a response contains but the model lacks is reported in one pass
/// (<see href="https://github.com/panoramicdata/Meraki.Api/issues/457">issue 457</see>).
/// The models and JSON are synthetic. No credentials or network are needed.
/// </summary>
public class MissingMembersReportingTests
{
	// Unknown members at the top level, on a known nested object, inside an unknown member
	// (object, nested object and array) and on a later array item, each followed by known members
	private const string JsonWithMissingMembers =
		"{\"name\":\"alpha\",\"extraTop\":1,"
		+ "\"settings\":{\"mode\":\"auto\",\"extraNested\":true,\"level\":3},"
		+ "\"unknownObject\":{\"inner\":\"x\",\"deeper\":{\"leaf\":1},\"list\":[{\"a\":1}]},"
		+ "\"items\":[{\"id\":\"1\",\"value\":10},{\"id\":\"2\",\"extraOnItem\":\"y\",\"value\":20},{\"id\":\"3\",\"value\":30}],"
		+ "\"tail\":\"end\"}";

	private const string JsonWithoutMissingMembers =
		"{\"name\":\"alpha\",\"settings\":{\"mode\":\"auto\",\"level\":3},"
		+ "\"items\":[{\"id\":\"1\",\"value\":10},{\"id\":\"2\",\"value\":20}],\"tail\":\"end\"}";

	private static readonly JsonMissingMember[] ExpectedMissingMembers =
	[
		new(nameof(TestRoot), "extraTop", "extraTop"),
		new(nameof(TestSettings), "extraNested", "settings.extraNested"),
		new(nameof(TestRoot), "unknownObject", "unknownObject"),
		new(nameof(TestRoot), "inner", "unknownObject.inner"),
		new(nameof(TestRoot), "deeper", "unknownObject.deeper"),
		new(nameof(TestRoot), "leaf", "unknownObject.deeper.leaf"),
		new(nameof(TestRoot), "list", "unknownObject.list"),
		new(nameof(TestRoot), "a", "unknownObject.list[0].a"),
		new(nameof(TestItem), "extraOnItem", "items[1].extraOnItem"),
	];

	private readonly List<(Type Type, IReadOnlyList<JsonMissingMember> Members, string Json)> _membersCalls = [];
	private readonly List<(Type Type, JsonSerializationException Exception, string Json)> _memberCalls = [];
	private readonly ListLogger _logger = new();

	private CustomNewtonsoftJsonContentSerializer CreateSerializer(JsonMissingMemberHandling handling) => new(
		new MerakiClientOptions
		{
			ApiKey = "0000000000000000000000000000000000000000",
			UserAgent = "Meraki.Api.Test/1.0",
			JsonMissingMemberHandling = handling,
			JsonMissingMemberAction = (type, exception, json) => _memberCalls.Add((type, exception, json)),
			JsonMissingMembersAction = (type, members, json) => _membersCalls.Add((type, members, json))
		},
		_logger);

	private static async Task<T?> DeserializeAsync<T>(CustomNewtonsoftJsonContentSerializer serializer, string json)
	{
		using var content = new StringContent(json);
		return await serializer.FromHttpContentAsync<T>(content, TestContext.Current.CancellationToken);
	}

	private static void ShouldBeFullyBound(TestRoot? root)
	{
		_ = root.Should().NotBeNull();
		_ = root!.Name.Should().Be("alpha");
		_ = root.Settings.Should().NotBeNull();
		_ = root.Settings!.Mode.Should().Be("auto");
		_ = root.Settings.Level.Should().Be(3);
		_ = root.Items.Should().NotBeNull();
		_ = root.Items!.Select(i => (i.Id, i.Value)).Should().Equal(("1", 10), ("2", 20), ("3", 30));
		_ = root.Tail.Should().Be("end");
	}

	private static string StrictErrorMessage<T>(string json)
	{
		var act = () => JsonConvert.DeserializeObject<T>(json, new JsonSerializerSettings { MissingMemberHandling = MissingMemberHandling.Error });
		return act.Should().Throw<JsonSerializationException>().Which.Message;
	}

	[Fact]
	public async Task LogWarning_ReportsEveryMissingMemberInOneCall()
	{
		_ = await DeserializeAsync<TestRoot>(CreateSerializer(JsonMissingMemberHandling.LogWarningOnErrorAndContinue), JsonWithMissingMembers);

		var call = _membersCalls.Should().ContainSingle().Subject;
		_ = call.Type.Should().Be<TestRoot>();
		_ = call.Json.Should().Be(JsonWithMissingMembers);
		_ = call.Members.Should().Equal(ExpectedMissingMembers);
	}

	[Fact]
	public async Task LogWarning_HandledMissingMembers_LeaveTheRestOfTheObjectBound()
	{
		var root = await DeserializeAsync<TestRoot>(CreateSerializer(JsonMissingMemberHandling.LogWarningOnErrorAndContinue), JsonWithMissingMembers);

		ShouldBeFullyBound(root);

		// The same as reading with missing members ignored
		_ = root.Should().BeEquivalentTo(JsonConvert.DeserializeObject<TestRoot>(JsonWithMissingMembers));
	}

	[Fact]
	public async Task LogWarning_MissingMemberOnLaterItemOfRootArray_IsReportedAndItemsBound()
	{
		const string json = "[{\"id\":\"1\",\"value\":10},{\"id\":\"2\",\"value\":20},{\"id\":\"3\",\"extra\":{\"x\":1},\"value\":30}]";

		var items = await DeserializeAsync<List<TestItem>>(CreateSerializer(JsonMissingMemberHandling.LogWarningOnErrorAndContinue), json);

		_ = items!.Select(i => (i.Id, i.Value)).Should().Equal(("1", 10), ("2", 20), ("3", 30));
		_ = _membersCalls.Should().ContainSingle().Subject.Members.Should().Equal(
			new JsonMissingMember(nameof(TestItem), "extra", "[2].extra"),
			new JsonMissingMember(nameof(TestItem), "x", "[2].extra.x"));
	}

	[Fact]
	public async Task LogWarning_LegacyActionIsCalledOnceWithTheFirstMemberAsBefore()
	{
		_ = await DeserializeAsync<TestRoot>(CreateSerializer(JsonMissingMemberHandling.LogWarningOnErrorAndContinue), JsonWithMissingMembers);

		var call = _memberCalls.Should().ContainSingle().Subject;
		_ = call.Type.Should().Be<TestRoot>();
		_ = call.Json.Should().Be(JsonWithMissingMembers);
		_ = call.Exception.Message.Should().Be(StrictErrorMessage<TestRoot>(JsonWithMissingMembers));
		_ = call.Exception.Path.Should().Be("extraTop");
	}

	[Fact]
	public async Task LogWarning_LogsOneWarningNamingEveryMember()
	{
		_ = await DeserializeAsync<TestRoot>(CreateSerializer(JsonMissingMemberHandling.LogWarningOnErrorAndContinue), JsonWithMissingMembers);

		var warning = _logger.Entries.Should().ContainSingle(e => e.Level == LogLevel.Warning).Subject;
		_ = warning.Message.Should().StartWith("JsonSerializationException: " + StrictErrorMessage<TestRoot>(JsonWithMissingMembers));
		foreach (var member in ExpectedMissingMembers.Skip(1))
		{
			_ = warning.Message.Should().Contain($"'{member.Path}' on {member.DeclaringType}");
		}
	}

	[Theory]
	[InlineData(JsonMissingMemberHandling.LogWarningOnErrorAndContinue)]
	[InlineData(JsonMissingMemberHandling.ThrowOnError)]
	public async Task NoMissingMembers_NoCallsNoWarningAndOnePass(JsonMissingMemberHandling handling)
	{
		TestRoot.ResetConstructionCount();

		var root = await DeserializeAsync<TestRoot>(CreateSerializer(handling), JsonWithoutMissingMembers);

		_ = root!.Name.Should().Be("alpha");
		_ = TestRoot.ConstructionCount.Should().Be(1);
		_ = _membersCalls.Should().BeEmpty();
		_ = _memberCalls.Should().BeEmpty();
		_ = _logger.Entries.Should().BeEmpty();
	}

	[Fact]
	public async Task LogWarning_WithMissingMembers_IsStillOnePass()
	{
		TestRoot.ResetConstructionCount();

		_ = await DeserializeAsync<TestRoot>(CreateSerializer(JsonMissingMemberHandling.LogWarningOnErrorAndContinue), JsonWithMissingMembers);

		_ = TestRoot.ConstructionCount.Should().Be(1);
	}

	[Fact]
	public async Task ThrowOnError_CallsBothActionsThenThrowsOnceWithEveryMember()
	{
		var serializer = CreateSerializer(JsonMissingMemberHandling.ThrowOnError);

		var act = () => DeserializeAsync<TestRoot>(serializer, JsonWithMissingMembers);

		var exception = (await act.Should().ThrowAsync<JsonMissingMembersException>()).Which;
		_ = exception.Should().BeAssignableTo<JsonSerializationException>();
		_ = exception.MissingMembers.Should().Equal(ExpectedMissingMembers);
		_ = exception.InnerException.Should().BeOfType<JsonSerializationException>()
			.Which.Message.Should().Be(StrictErrorMessage<TestRoot>(JsonWithMissingMembers));
		_ = exception.Message.Should().StartWith(StrictErrorMessage<TestRoot>(JsonWithMissingMembers));
		_ = exception.Path.Should().Be("extraTop");
		_ = _membersCalls.Should().ContainSingle().Subject.Members.Should().Equal(ExpectedMissingMembers);
		_ = _memberCalls.Should().ContainSingle().Subject.Exception.Should().BeSameAs(exception.InnerException);
		_ = _logger.Entries.Should().NotContain(e => e.Level == LogLevel.Warning);
	}

	[Fact]
	public async Task ThrowOnError_OneMissingMember_KeepsNewtonsoftsMessage()
	{
		const string json = "{\"name\":\"alpha\",\"extraTop\":1}";

		var act = () => DeserializeAsync<TestRoot>(CreateSerializer(JsonMissingMemberHandling.ThrowOnError), json);

		_ = (await act.Should().ThrowAsync<JsonMissingMembersException>())
			.Which.Message.Should().Be(StrictErrorMessage<TestRoot>(json));
	}

	[Fact]
	public async Task Ignore_IsUnchanged()
	{
		var root = await DeserializeAsync<TestRoot>(CreateSerializer(JsonMissingMemberHandling.Ignore), JsonWithMissingMembers);

		ShouldBeFullyBound(root);
		_ = _membersCalls.Should().BeEmpty();
		_ = _memberCalls.Should().BeEmpty();
		_ = _logger.Entries.Should().BeEmpty();
	}

	[Theory]
	[InlineData(JsonMissingMemberHandling.LogWarningOnErrorAndContinue)]
	[InlineData(JsonMissingMemberHandling.ThrowOnError)]
	public async Task TypeConversionError_ThrowsAsBefore(JsonMissingMemberHandling handling)
	{
		// A string where an object is declared fails in the serializer, not the reader
		const string json = "{\"name\":\"alpha\",\"settings\":\"not an object\"}";
		var expected = StrictErrorMessage<TestRoot>(json);

		var act = () => DeserializeAsync<TestRoot>(CreateSerializer(handling), json);

		var exception = (await act.Should().ThrowAsync<JsonSerializationException>()).Which;
		_ = exception.Should().NotBeOfType<JsonMissingMembersException>();
		_ = exception.Message.Should().Be(expected);

		// As before, the legacy action sees the failure; there are no missing members to report
		_ = _memberCalls.Should().ContainSingle().Subject.Exception.Should().BeSameAs(exception);
		_ = _membersCalls.Should().BeEmpty();
	}

	[Theory]
	[InlineData(JsonMissingMemberHandling.LogWarningOnErrorAndContinue)]
	[InlineData(JsonMissingMemberHandling.ThrowOnError)]
	public async Task TypeConversionErrorAfterMissingMembers_ReportsThemAndThrowsTheConversionError(JsonMissingMemberHandling handling)
	{
		const string json = "{\"name\":\"alpha\",\"extraTop\":1,\"settings\":\"not an object\"}";

		var act = () => DeserializeAsync<TestRoot>(CreateSerializer(handling), json);

		var exception = (await act.Should().ThrowAsync<JsonSerializationException>()).Which;
		_ = exception.Should().NotBeOfType<JsonMissingMembersException>();
		_ = exception.Message.Should().StartWith("Error converting value \"not an object\"");
		_ = _membersCalls.Should().ContainSingle().Subject.Members.Should().Equal(new JsonMissingMember(nameof(TestRoot), "extraTop", "extraTop"));
		_ = _memberCalls.Should().ContainSingle().Subject.Exception.Path.Should().Be("extraTop");
	}

	[Theory]
	[InlineData(JsonMissingMemberHandling.LogWarningOnErrorAndContinue)]
	[InlineData(JsonMissingMemberHandling.ThrowOnError)]
	public async Task ReaderError_ThrowsAsBefore(JsonMissingMemberHandling handling)
	{
		// A non-numeric string where an int is declared fails in the reader
		const string json = "{\"name\":\"alpha\",\"settings\":{\"level\":\"three\"}}";

		var act = () => DeserializeAsync<TestRoot>(CreateSerializer(handling), json);

		_ = (await act.Should().ThrowAsync<JsonReaderException>())
			.Which.Message.Should().StartWith("Could not convert string to integer: three.");
		_ = _membersCalls.Should().BeEmpty();
		_ = _memberCalls.Should().BeEmpty();
	}

	[Theory]
	[InlineData(JsonMissingMemberHandling.LogWarningOnErrorAndContinue)]
	[InlineData(JsonMissingMemberHandling.ThrowOnError)]
	public async Task InvalidJson_ThrowsAsBefore(JsonMissingMemberHandling handling)
	{
		const string json = "{\"name\":\"alpha\",";

		var act = () => DeserializeAsync<TestRoot>(CreateSerializer(handling), json);

		_ = await act.Should().ThrowAsync<JsonException>();
		_ = _membersCalls.Should().BeEmpty();
	}

	[DataContract]
	private sealed class TestRoot
	{
		private static int _constructionCount;

		public TestRoot() => Interlocked.Increment(ref _constructionCount);

		public static int ConstructionCount => Volatile.Read(ref _constructionCount);

		public static void ResetConstructionCount() => Volatile.Write(ref _constructionCount, 0);

		[DataMember(Name = "name")]
		public string? Name { get; set; }

		[DataMember(Name = "settings")]
		public TestSettings? Settings { get; set; }

		[DataMember(Name = "items")]
		public List<TestItem>? Items { get; set; }

		[DataMember(Name = "tail")]
		public string? Tail { get; set; }
	}

	[DataContract]
	private sealed class TestSettings
	{
		[DataMember(Name = "mode")]
		public string? Mode { get; set; }

		[DataMember(Name = "level")]
		public int? Level { get; set; }
	}

	[DataContract]
	private sealed class TestItem
	{
		[DataMember(Name = "id")]
		public string? Id { get; set; }

		[DataMember(Name = "value")]
		public int? Value { get; set; }
	}

	private sealed class ListLogger : ILogger
	{
		public List<(LogLevel Level, string Message)> Entries { get; } = [];

		public IDisposable? BeginScope<TState>(TState state) where TState : notnull => null;

		public bool IsEnabled(LogLevel logLevel) => true;

		public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception? exception, Func<TState, Exception?, string> formatter)
			=> Entries.Add((logLevel, formatter(state, exception)));
	}
}
