using Meraki.Api.Exceptions;
using Meraki.Api.Mcp;

namespace Meraki.Api.Test.Mcp;

public class MerakiMcpClientTests
{
	private static MerakiMcpClientOptions Options(bool enforceReadOnly = true)
		=> new()
		{
			ApiKey = "key",
			EnforceReadOnlyCapabilityNames = enforceReadOnly
		};

	private static MerakiMcpClient Create(FakeMerakiMcpSession session, bool enforceReadOnly = true)
		=> new(Options(enforceReadOnly), null, _ => Task.FromResult<IMerakiMcpSession>(session));

	// ---------------------------------------------------------------- construction

	[Fact]
	public void Constructor_WithNullOptions_Throws()
	{
		var act = () => new MerakiMcpClient(null!);

		act.Should().Throw<ArgumentNullException>();
	}

	[Fact]
	public void Constructor_WithInvalidOptions_ThrowsImmediately()
	{
		var act = () => new MerakiMcpClient(new MerakiMcpClientOptions());

		act.Should().Throw<ConfigurationException>();
	}

	[Fact]
	public void Constructor_WithNullSessionFactory_Throws()
	{
		var act = () => new MerakiMcpClient(Options(), null, null!);

		act.Should().Throw<ArgumentNullException>();
	}

	// ---------------------------------------------------------------- read-only naming

	[Theory]
	[InlineData("getNetworkClients", true)]
	[InlineData("GETNetworkClients", true)]
	[InlineData("getOrganizationDevicesStatuses", true)]
	[InlineData("updateNetworkSsid", false)]
	[InlineData("createNetwork", false)]
	[InlineData("deleteNetwork", false)]
	[InlineData("rebootDevice", false)]
	[InlineData("", false)]
	[InlineData(null, false)]
	public void IsReadCapabilityName_ClassifiesCorrectly(string? capabilityId, bool expected)
		=> MerakiMcpClient.IsReadCapabilityName(capabilityId).Should().Be(expected);

	// ---------------------------------------------------------------- semantic search

	[Fact]
	public async Task SemanticSearchAsync_WithStructuredContent_ReturnsRankedCapabilities()
	{
		var session = new FakeMerakiMcpSession
		{
			OnCallTool = (_, _, _) => Task.FromResult(new MerakiMcpToolResponse(
				false,
				null,
				"""
				{
					"capabilities": [
						{ "capability_id": "getNetworkClients", "score": 0.93, "description": "List clients", "parameters": { "networkId": "string" } },
						{ "capability_id": "getNetworkEvents", "score": 0.71 }
					]
				}
				"""))
		};

		using var client = Create(session);

		var capabilities = await client.SemanticSearchAsync("which clients are on the network?", TestContext.Current.CancellationToken);

		capabilities.Should().HaveCount(2);
		capabilities[0].CapabilityId.Should().Be("getNetworkClients");
		capabilities[0].Score.Should().Be(0.93);
		capabilities[0].Description.Should().Be("List clients");
		capabilities[0].ParameterSchemaJson.Should().Contain("networkId");
		capabilities[0].IsReadOperation.Should().BeTrue();
		capabilities[1].Score.Should().Be(0.71);
		capabilities[1].Description.Should().BeNull();
		capabilities[1].ParameterSchemaJson.Should().BeNull();
	}

	[Fact]
	public async Task SemanticSearchAsync_PassesQueryToTheTool()
	{
		var session = new FakeMerakiMcpSession
		{
			OnCallTool = (_, _, _) => Task.FromResult(new MerakiMcpToolResponse(false, """[{"capability_id":"getNetworkClients"}]""", null))
		};

		using var client = Create(session);

		_ = await client.SemanticSearchAsync("wireless failures", TestContext.Current.CancellationToken);

		session.Calls.Should().ContainSingle();
		session.Calls[0].ToolName.Should().Be(MerakiMcpClient.SemanticSearchToolName);
		session.Calls[0].Arguments["query"].Should().Be("wireless failures");
	}

	[Fact]
	public async Task SemanticSearchAsync_WithTextContentOnly_ParsesIt()
	{
		var session = new FakeMerakiMcpSession
		{
			OnCallTool = (_, _, _) => Task.FromResult(new MerakiMcpToolResponse(false, """[{"capabilityId":"getDevice"}]""", null))
		};

		using var client = Create(session);

		var capabilities = await client.SemanticSearchAsync("device", TestContext.Current.CancellationToken);

		capabilities.Should().ContainSingle().Which.CapabilityId.Should().Be("getDevice");
	}

	[Theory]
	[InlineData("""{"results":[{"id":"getNetworkClients"}]}""")]
	[InlineData("""{"data":[{"operationId":"getNetworkClients"}]}""")]
	[InlineData("""{"items":[{"capability":"getNetworkClients"}]}""")]
	[InlineData("""{"matches":[{"capability_id":"getNetworkClients"}]}""")]
	[InlineData("""{"somethingCiscoRenamed":[{"capability_id":"getNetworkClients"}]}""")]
	public async Task SemanticSearchAsync_ToleratesWrapperAndFieldNameVariations(string json)
	{
		var session = new FakeMerakiMcpSession
		{
			OnCallTool = (_, _, _) => Task.FromResult(new MerakiMcpToolResponse(false, null, json))
		};

		using var client = Create(session);

		var capabilities = await client.SemanticSearchAsync("clients", TestContext.Current.CancellationToken);

		capabilities.Should().ContainSingle().Which.CapabilityId.Should().Be("getNetworkClients");
	}

	[Fact]
	public async Task SemanticSearchAsync_SkipsEntriesWithoutACapabilityId()
	{
		var session = new FakeMerakiMcpSession
		{
			OnCallTool = (_, _, _) => Task.FromResult(new MerakiMcpToolResponse(
				false,
				null,
				"""[{"description":"no id here"},{"capability_id":"getNetworkClients"}]"""))
		};

		using var client = Create(session);

		var capabilities = await client.SemanticSearchAsync("clients", TestContext.Current.CancellationToken);

		capabilities.Should().ContainSingle().Which.CapabilityId.Should().Be("getNetworkClients");
	}

	[Theory]
	[InlineData(null, null)]
	[InlineData("", null)]
	[InlineData("   ", null)]
	public async Task SemanticSearchAsync_WithNoContent_ThrowsProtocolException(string? text, string? structuredJson)
	{
		var session = new FakeMerakiMcpSession
		{
			OnCallTool = (_, _, _) => Task.FromResult(new MerakiMcpToolResponse(false, text, structuredJson))
		};

		using var client = Create(session);

		var act = async () => await client.SemanticSearchAsync("clients", TestContext.Current.CancellationToken);

		await act.Should().ThrowAsync<MerakiMcpProtocolException>().WithMessage("*no content*");
	}

	[Fact]
	public async Task SemanticSearchAsync_WithUnparseableJson_ThrowsProtocolException()
	{
		var session = new FakeMerakiMcpSession
		{
			OnCallTool = (_, _, _) => Task.FromResult(new MerakiMcpToolResponse(false, "this is not json", null))
		};

		using var client = Create(session);

		var act = async () => await client.SemanticSearchAsync("clients", TestContext.Current.CancellationToken);

		await act.Should().ThrowAsync<MerakiMcpProtocolException>().WithMessage("*parse*");
	}

	[Fact]
	public async Task SemanticSearchAsync_WithNoArrayAnywhere_ThrowsProtocolException()
	{
		var session = new FakeMerakiMcpSession
		{
			OnCallTool = (_, _, _) => Task.FromResult(new MerakiMcpToolResponse(false, null, """{"message":"nothing useful"}"""))
		};

		using var client = Create(session);

		var act = async () => await client.SemanticSearchAsync("clients", TestContext.Current.CancellationToken);

		await act.Should().ThrowAsync<MerakiMcpProtocolException>().WithMessage("*capability array*");
	}

	[Fact]
	public async Task SemanticSearchAsync_WithEmptyCapabilityArray_ThrowsProtocolException()
	{
		var session = new FakeMerakiMcpSession
		{
			OnCallTool = (_, _, _) => Task.FromResult(new MerakiMcpToolResponse(false, null, """{"capabilities":[]}"""))
		};

		using var client = Create(session);

		var act = async () => await client.SemanticSearchAsync("clients", TestContext.Current.CancellationToken);

		await act.Should().ThrowAsync<MerakiMcpProtocolException>().WithMessage("*no recognisable capabilities*");
	}

	[Fact]
	public async Task SemanticSearchAsync_WhenServerFlagsAnError_ThrowsProtocolException()
	{
		var session = new FakeMerakiMcpSession
		{
			OnCallTool = (_, _, _) => Task.FromResult(new MerakiMcpToolResponse(true, "quota exceeded", null))
		};

		using var client = Create(session);

		var act = async () => await client.SemanticSearchAsync("clients", TestContext.Current.CancellationToken);

		await act.Should().ThrowAsync<MerakiMcpProtocolException>().WithMessage("*quota exceeded*");
	}

	[Theory]
	[InlineData(null)]
	[InlineData("")]
	[InlineData("  ")]
	public async Task SemanticSearchAsync_WithoutAQuery_Throws(string? query)
	{
		using var client = Create(new FakeMerakiMcpSession());

		var act = async () => await client.SemanticSearchAsync(query!, TestContext.Current.CancellationToken);

		await act.Should().ThrowAsync<ArgumentException>();
	}

	// ---------------------------------------------------------------- execute api

	[Fact]
	public async Task ExecuteApiAsync_WithReadCapability_ReturnsResult()
	{
		var session = new FakeMerakiMcpSession
		{
			OnCallTool = (_, _, _) => Task.FromResult(new MerakiMcpToolResponse(false, "text form", """{"clients":[]}"""))
		};

		using var client = Create(session);

		var result = await client.ExecuteApiAsync(
			"getNetworkClients",
			new Dictionary<string, object?> { ["networkId"] = "N_1" },
			TestContext.Current.CancellationToken);

		result.CapabilityId.Should().Be("getNetworkClients");
		result.RawJson.Should().Be("""{"clients":[]}""");
		result.Text.Should().Be("text form");

		session.Calls[0].ToolName.Should().Be(MerakiMcpClient.ExecuteApiToolName);
		session.Calls[0].Arguments["capability_id"].Should().Be("getNetworkClients");
		session.Calls[0].Arguments.Should().ContainKey("parameters");
	}

	[Fact]
	public async Task ExecuteApiAsync_WithoutParameters_OmitsTheParametersArgument()
	{
		var session = new FakeMerakiMcpSession
		{
			OnCallTool = (_, _, _) => Task.FromResult(new MerakiMcpToolResponse(false, null, "{}"))
		};

		using var client = Create(session);

		_ = await client.ExecuteApiAsync("getOrganizations", cancellationToken: TestContext.Current.CancellationToken);

		session.Calls[0].Arguments.Should().NotContainKey("parameters");
	}

	[Fact]
	public async Task ExecuteApiAsync_WithEmptyParameters_OmitsTheParametersArgument()
	{
		var session = new FakeMerakiMcpSession
		{
			OnCallTool = (_, _, _) => Task.FromResult(new MerakiMcpToolResponse(false, null, "{}"))
		};

		using var client = Create(session);

		_ = await client.ExecuteApiAsync("getOrganizations", new Dictionary<string, object?>(), TestContext.Current.CancellationToken);

		session.Calls[0].Arguments.Should().NotContainKey("parameters");
	}

	[Fact]
	public async Task ExecuteApiAsync_WithTextOnly_UsesTextAsRawJson()
	{
		var session = new FakeMerakiMcpSession
		{
			OnCallTool = (_, _, _) => Task.FromResult(new MerakiMcpToolResponse(false, """{"a":1}""", null))
		};

		using var client = Create(session);

		var result = await client.ExecuteApiAsync("getOrganizations", cancellationToken: TestContext.Current.CancellationToken);

		result.RawJson.Should().Be("""{"a":1}""");
	}

	[Fact]
	public async Task ExecuteApiAsync_WithNoContentAtAll_ReturnsEmptyRawJson()
	{
		var session = new FakeMerakiMcpSession
		{
			OnCallTool = (_, _, _) => Task.FromResult(new MerakiMcpToolResponse(false, null, null))
		};

		using var client = Create(session);

		var result = await client.ExecuteApiAsync("getOrganizations", cancellationToken: TestContext.Current.CancellationToken);

		result.RawJson.Should().BeEmpty();
	}

	[Theory]
	[InlineData("updateNetworkSsid")]
	[InlineData("createNetwork")]
	[InlineData("deleteDevice")]
	[InlineData("rebootDevice")]
	[InlineData("claimNetworkDevices")]
	public async Task ExecuteApiAsync_WithMutatingCapability_IsRefusedAndPointsAtTheRestClient(string capabilityId)
	{
		var session = new FakeMerakiMcpSession();
		using var client = Create(session);

		var act = async () => await client.ExecuteApiAsync(capabilityId, cancellationToken: TestContext.Current.CancellationToken);

		var exception = await act.Should().ThrowAsync<MerakiMcpReadOnlyViolationException>();
		exception.Which.CapabilityId.Should().Be(capabilityId);
		exception.Which.Message.Should().Contain(nameof(MerakiClient));

		session.Calls.Should().BeEmpty("the guard must refuse before any call reaches the server");
	}

	[Fact]
	public async Task ExecuteApiAsync_WithEnforcementDisabled_AllowsANonGetCapability()
	{
		var session = new FakeMerakiMcpSession
		{
			OnCallTool = (_, _, _) => Task.FromResult(new MerakiMcpToolResponse(false, null, "{}"))
		};

		using var client = Create(session, enforceReadOnly: false);

		var result = await client.ExecuteApiAsync("updateNetworkSsid", cancellationToken: TestContext.Current.CancellationToken);

		result.CapabilityId.Should().Be("updateNetworkSsid");
	}

	[Theory]
	[InlineData(null)]
	[InlineData("")]
	[InlineData("  ")]
	public async Task ExecuteApiAsync_WithoutACapabilityId_Throws(string? capabilityId)
	{
		using var client = Create(new FakeMerakiMcpSession());

		var act = async () => await client.ExecuteApiAsync(capabilityId!, cancellationToken: TestContext.Current.CancellationToken);

		await act.Should().ThrowAsync<ArgumentException>();
	}

	[Fact]
	public async Task ExecuteApiAsync_WhenServerFlagsAnError_ThrowsProtocolExceptionNamingTheCapability()
	{
		var session = new FakeMerakiMcpSession
		{
			OnCallTool = (_, _, _) => Task.FromResult(new MerakiMcpToolResponse(true, "unknown capability_id", null))
		};

		using var client = Create(session);

		var act = async () => await client.ExecuteApiAsync("getNoSuchThing", cancellationToken: TestContext.Current.CancellationToken);

		await act.Should().ThrowAsync<MerakiMcpProtocolException>()
			.WithMessage("*getNoSuchThing*unknown capability_id*");
	}

	[Fact]
	public async Task ExecuteApiAsync_WhenServerFlagsAnErrorWithoutDetail_StillExplains()
	{
		var session = new FakeMerakiMcpSession
		{
			OnCallTool = (_, _, _) => Task.FromResult(new MerakiMcpToolResponse(true, null, null))
		};

		using var client = Create(session);

		var act = async () => await client.ExecuteApiAsync("getOrganizations", cancellationToken: TestContext.Current.CancellationToken);

		await act.Should().ThrowAsync<MerakiMcpProtocolException>().WithMessage("*no detail supplied*");
	}

	// ---------------------------------------------------------------- payload-level errors
	//
	// The hosted server reports some failures, notably missing required parameters, in the payload of
	// an otherwise successful tool result, without setting the MCP error flag. Observed against the
	// live server; these tests use the exact envelope it returned.

	[Fact]
	public async Task ExecuteApiAsync_WithAPayloadErrorEnvelope_ThrowsRatherThanReturningTheErrorAsData()
	{
		var session = new FakeMerakiMcpSession
		{
			OnCallTool = (_, _, _) => Task.FromResult(new MerakiMcpToolResponse(
				false,
				null,
				"""
				{"result":{"type":"error","error":"Missing required parameters","recovery_suggestion":"Provide values for: organizationId","capability_id":"getOrganizationSwitchPortsClientsOverviewByDevice"}}
				"""))
		};

		using var client = Create(session);

		var act = async () => await client.ExecuteApiAsync("getOrganizationSwitchPortsClientsOverviewByDevice", cancellationToken: TestContext.Current.CancellationToken);

		await act.Should().ThrowAsync<MerakiMcpProtocolException>()
			.WithMessage("*Missing required parameters*Provide values for: organizationId*");
	}

	[Fact]
	public async Task SemanticSearchAsync_WithAPayloadErrorEnvelope_ReportsTheServerError()
	{
		var session = new FakeMerakiMcpSession
		{
			OnCallTool = (_, _, _) => Task.FromResult(new MerakiMcpToolResponse(
				false,
				null,
				"""{"result":{"type":"error","error":"Query too long"}}"""))
		};

		using var client = Create(session);

		var act = async () => await client.SemanticSearchAsync("clients", TestContext.Current.CancellationToken);

		await act.Should().ThrowAsync<MerakiMcpProtocolException>().WithMessage("*Query too long*");
	}

	[Fact]
	public async Task ExecuteApiAsync_WithABareTopLevelErrorObject_AlsoThrows()
	{
		var session = new FakeMerakiMcpSession
		{
			OnCallTool = (_, _, _) => Task.FromResult(new MerakiMcpToolResponse(
				false,
				null,
				"""{"type":"error","error":"Unknown capability","recoverySuggestion":"Run semantic_search first"}"""))
		};

		using var client = Create(session);

		var act = async () => await client.ExecuteApiAsync("getNoSuchThing", cancellationToken: TestContext.Current.CancellationToken);

		await act.Should().ThrowAsync<MerakiMcpProtocolException>()
			.WithMessage("*Unknown capability*Run semantic_search first*");
	}

	[Fact]
	public async Task ExecuteApiAsync_WithAnErrorEnvelopeLackingDetail_StillThrows()
	{
		var session = new FakeMerakiMcpSession
		{
			OnCallTool = (_, _, _) => Task.FromResult(new MerakiMcpToolResponse(false, null, """{"result":{"type":"error"}}"""))
		};

		using var client = Create(session);

		var act = async () => await client.ExecuteApiAsync("getOrganizations", cancellationToken: TestContext.Current.CancellationToken);

		await act.Should().ThrowAsync<MerakiMcpProtocolException>().WithMessage("*no detail supplied*");
	}

	[Theory]
	[InlineData(null)]
	[InlineData("")]
	[InlineData("not json at all")]
	[InlineData("[1,2,3]")]
	[InlineData("""{"result":{"type":"success"}}""")]
	[InlineData("""{"clients":[]}""")]
	public void TryReadPayloadError_DoesNotFalselyFlagNonErrors(string? json)
		=> MerakiMcpClient.TryReadPayloadError(json, out _).Should().BeFalse();

	[Fact]
	public async Task ExecuteApiAsync_WithGenuineDataThatHappensToContainATypeField_IsNotTreatedAsAnError()
	{
		var session = new FakeMerakiMcpSession
		{
			OnCallTool = (_, _, _) => Task.FromResult(new MerakiMcpToolResponse(
				false,
				null,
				"""{"type":"switch","serial":"Q2QN-XXXX-XXXX"}"""))
		};

		using var client = Create(session);

		var result = await client.ExecuteApiAsync("getDevice", cancellationToken: TestContext.Current.CancellationToken);

		result.RawJson.Should().Contain("Q2QN");
	}

	// ---------------------------------------------------------------- envelope unwrapping
	//
	// Successful responses are wrapped as {"result":{"type":"success","capability_id":...,"data":...}}.
	// Observed against the live server; the envelope below is the shape it actually returned.

	[Fact]
	public async Task ExecuteApiAsync_UnwrapsTheDataElementFromTheSuccessEnvelope()
	{
		var session = new FakeMerakiMcpSession
		{
			OnCallTool = (_, _, _) => Task.FromResult(new MerakiMcpToolResponse(
				false,
				null,
				"""
				{"result":{"type":"success","capability_id":"getOrganizationSwitchPortsClientsOverviewByDevice","product":"switch","data":{"items":[{"serial":"Q4AA-FWF6-VWK6","model":"MS120-8"}]}}}
				"""))
		};

		using var client = Create(session);

		var result = await client.ExecuteApiAsync("getOrganizationSwitchPortsClientsOverviewByDevice", cancellationToken: TestContext.Current.CancellationToken);

		// The envelope is preserved for anyone who wants it...
		result.RawJson.Should().Contain("\"type\":\"success\"");

		// ...but the payload is the data element alone, matching the REST shape.
		result.DataJson.Should().Be("""{"items":[{"serial":"Q4AA-FWF6-VWK6","model":"MS120-8"}]}""");
		result.Payload.Should().Be(result.DataJson);
	}

	[Fact]
	public async Task ExecuteApiAsync_DeserializesTheUnwrappedPayload()
	{
		var session = new FakeMerakiMcpSession
		{
			OnCallTool = (_, _, _) => Task.FromResult(new MerakiMcpToolResponse(
				false,
				null,
				"""{"result":{"type":"success","data":{"serial":"Q4AA-FWF6-VWK6"}}}"""))
		};

		using var client = Create(session);

		var result = await client.ExecuteApiAsync("getDevice", cancellationToken: TestContext.Current.CancellationToken);

		result.Deserialize<DeviceStub>()!.Serial.Should().Be("Q4AA-FWF6-VWK6");
	}

	[Fact]
	public async Task ExecuteApiAsync_WithNoEnvelope_LeavesTheRawJsonAsThePayload()
	{
		var session = new FakeMerakiMcpSession
		{
			OnCallTool = (_, _, _) => Task.FromResult(new MerakiMcpToolResponse(false, null, """{"serial":"Q4AA-FWF6-VWK6"}"""))
		};

		using var client = Create(session);

		var result = await client.ExecuteApiAsync("getDevice", cancellationToken: TestContext.Current.CancellationToken);

		result.DataJson.Should().BeNull();
		result.Payload.Should().Be(result.RawJson);
		result.Deserialize<DeviceStub>()!.Serial.Should().Be("Q4AA-FWF6-VWK6");
	}

	[Fact]
	public async Task ExecuteApiAsync_UnwrapsAnArrayDataElement()
	{
		var session = new FakeMerakiMcpSession
		{
			OnCallTool = (_, _, _) => Task.FromResult(new MerakiMcpToolResponse(
				false,
				null,
				"""{"result":{"type":"success","data":[{"serial":"A"},{"serial":"B"}]}}"""))
		};

		using var client = Create(session);

		var result = await client.ExecuteApiAsync("getOrganizationDevices", cancellationToken: TestContext.Current.CancellationToken);

		result.Deserialize<List<DeviceStub>>()!.Should().HaveCount(2);
	}

	[Theory]
	[InlineData(null)]
	[InlineData("")]
	[InlineData("not json")]
	[InlineData("[1,2,3]")]
	[InlineData("""{"result":"a string, not an object"}""")]
	[InlineData("""{"result":{"type":"success"}}""")]
	[InlineData("""{"result":{"type":"success","data":null}}""")]
	public void TryUnwrapData_ReturnsFalseWhenThereIsNoDataElement(string? json)
		=> MerakiMcpClient.TryUnwrapData(json, out _).Should().BeFalse();

	private sealed class DeviceStub
	{
		public string Serial { get; set; } = string.Empty;
	}

	// ---------------------------------------------------------------- tool catalogue drift

	[Fact]
	public async Task SemanticSearchAsync_WhenToolIsMissing_ThrowsNamingTheToolAndWhatWasAdvertised()
	{
		var session = new FakeMerakiMcpSession();
		session.ToolNames.Clear();
		session.ToolNames.Add("something_else");

		using var client = Create(session);

		var act = async () => await client.SemanticSearchAsync("clients", TestContext.Current.CancellationToken);

		var exception = await act.Should().ThrowAsync<MerakiMcpToolNotFoundException>();
		exception.Which.ToolName.Should().Be(MerakiMcpClient.SemanticSearchToolName);
		exception.Which.AvailableToolNames.Should().Contain("something_else");
		exception.Which.Message.Should().Contain("something_else").And.Contain("beta");
	}

	[Fact]
	public async Task ExecuteApiAsync_WhenToolIsMissing_ThrowsWithNoneAdvertised()
	{
		var session = new FakeMerakiMcpSession();
		session.ToolNames.Clear();

		using var client = Create(session);

		var act = async () => await client.ExecuteApiAsync("getOrganizations", cancellationToken: TestContext.Current.CancellationToken);

		await act.Should().ThrowAsync<MerakiMcpToolNotFoundException>().WithMessage("*none*");
	}

	// ---------------------------------------------------------------- status

	[Fact]
	public async Task GetStatusAsync_WhenBothToolsAdvertised_IsConnected()
	{
		using var client = Create(new FakeMerakiMcpSession());

		var status = await client.GetStatusAsync(TestContext.Current.CancellationToken);

		status.IsConnected.Should().BeTrue();
		status.Message.Should().BeNull();
		status.AvailableToolNames.Should().Contain(MerakiMcpClient.SemanticSearchToolName);
		status.ToString().Should().Contain("Connected");
	}

	[Fact]
	public async Task GetStatusAsync_WhenAToolIsMissing_IsDisconnectedAndSaysWhich()
	{
		var session = new FakeMerakiMcpSession();
		session.ToolNames.Remove(MerakiMcpClient.ExecuteApiToolName);

		using var client = Create(session);

		var status = await client.GetStatusAsync(TestContext.Current.CancellationToken);

		status.IsConnected.Should().BeFalse();
		status.Message.Should().Contain(MerakiMcpClient.ExecuteApiToolName);
	}

	[Fact]
	public async Task GetStatusAsync_WhenNoToolsAdvertised_SaysNone()
	{
		var session = new FakeMerakiMcpSession();
		session.ToolNames.Clear();

		using var client = Create(session);

		var status = await client.GetStatusAsync(TestContext.Current.CancellationToken);

		status.IsConnected.Should().BeFalse();
		status.Message.Should().Contain("none");
	}

	[Fact]
	public async Task GetStatusAsync_WhenTheServerIsUnreachable_IsDisconnectedAndDoesNotThrow()
	{
		var client = new MerakiMcpClient(
			Options(),
			null,
			_ => throw new HttpRequestException("no route to host"));

		var status = await client.GetStatusAsync(TestContext.Current.CancellationToken);

		status.IsConnected.Should().BeFalse();
		status.Message.Should().Contain("no route to host");
		status.ToString().Should().Contain("Disconnected");

		await client.DisposeAsync();
	}

	[Fact]
	public async Task GetStatusAsync_NeverRevealsTheApiKey()
	{
		var options = new MerakiMcpClientOptions { ApiKey = "super-secret-key" };

		var client = new MerakiMcpClient(
			options,
			null,
			_ => throw new HttpRequestException("connection refused"));

		var status = await client.GetStatusAsync(TestContext.Current.CancellationToken);

		status.ToString().Should().NotContain("super-secret-key");

		await client.DisposeAsync();
	}

	// ---------------------------------------------------------------- session lifecycle

	[Fact]
	public async Task ToolCatalogue_IsFetchedOnceAndReused()
	{
		var session = new FakeMerakiMcpSession
		{
			OnCallTool = (_, _, _) => Task.FromResult(new MerakiMcpToolResponse(false, null, "{}"))
		};

		using var client = Create(session);

		_ = await client.ExecuteApiAsync("getOrganizations", cancellationToken: TestContext.Current.CancellationToken);
		_ = await client.ExecuteApiAsync("getNetworks", cancellationToken: TestContext.Current.CancellationToken);

		session.ListToolNamesCallCount.Should().Be(1);
	}

	[Fact]
	public async Task ConcurrentCalls_CreateOnlyOneSession()
	{
		var sessionCreationCount = 0;
		var session = new FakeMerakiMcpSession
		{
			OnCallTool = async (_, _, ct) =>
			{
				await Task.Delay(5, ct);
				return new MerakiMcpToolResponse(false, null, "{}");
			}
		};

		using var client = new MerakiMcpClient(
			Options(),
			null,
			async ct =>
			{
				_ = Interlocked.Increment(ref sessionCreationCount);
				await Task.Delay(10, ct);
				return session;
			});

		var tasks = Enumerable
			.Range(0, 16)
			.Select(_ => client.ExecuteApiAsync("getOrganizations", cancellationToken: TestContext.Current.CancellationToken))
			.ToList();

		await Task.WhenAll(tasks);

		sessionCreationCount.Should().Be(1);
		session.Calls.Should().HaveCount(16);
	}

	[Fact]
	public async Task Cancellation_IsHonoured()
	{
		var session = new FakeMerakiMcpSession
		{
			OnCallTool = async (_, _, ct) =>
			{
				await Task.Delay(Timeout.Infinite, ct);
				return new MerakiMcpToolResponse(false, null, "{}");
			}
		};

		using var client = Create(session);
		using var cancellationTokenSource = new CancellationTokenSource();

		var task = client.ExecuteApiAsync("getOrganizations", cancellationToken: cancellationTokenSource.Token);
		await cancellationTokenSource.CancelAsync();

		var act = async () => await task;

		await act.Should().ThrowAsync<OperationCanceledException>();
	}

	[Fact]
	public async Task SessionFailure_ThatIsNotAMerakiException_IsWrappedAsProtocolException()
	{
		var session = new FakeMerakiMcpSession
		{
			OnCallTool = (_, _, _) => throw new InvalidOperationException("the SDK exploded")
		};

		using var client = Create(session);

		var act = async () => await client.ExecuteApiAsync("getOrganizations", cancellationToken: TestContext.Current.CancellationToken);

		await act.Should().ThrowAsync<MerakiMcpProtocolException>().WithMessage("*the SDK exploded*");
	}

	[Fact]
	public async Task SessionFailure_ThatIsAMerakiException_IsPreserved()
	{
		var session = new FakeMerakiMcpSession
		{
			OnListToolNames = _ => throw new MerakiMcpAuthenticationException()
		};

		using var client = Create(session);

		var act = async () => await client.ExecuteApiAsync("getOrganizations", cancellationToken: TestContext.Current.CancellationToken);

		await act.Should().ThrowAsync<MerakiMcpAuthenticationException>();
	}

	[Fact]
	public async Task SessionFailure_NestedMerakiException_IsUnwrapped()
	{
		var session = new FakeMerakiMcpSession
		{
			OnCallTool = (_, _, _) => throw new InvalidOperationException(
				"wrapper",
				new MerakiMcpAuthorizationException())
		};

		using var client = Create(session);

		var act = async () => await client.ExecuteApiAsync("getOrganizations", cancellationToken: TestContext.Current.CancellationToken);

		await act.Should().ThrowAsync<MerakiMcpAuthorizationException>();
	}

	[Fact]
	public void Translate_PreservesOperationCanceledException()
	{
		var original = new OperationCanceledException("stopped");

		MerakiMcpClient.Translate(new InvalidOperationException("wrapper", original), "testing")
			.Should().BeSameAs(original);
	}

	// ---------------------------------------------------------------- statistics

	[Fact]
	public async Task Statistics_CountToolCalls()
	{
		var session = new FakeMerakiMcpSession
		{
			OnCallTool = (_, _, _) => Task.FromResult(new MerakiMcpToolResponse(false, null, "{}"))
		};

		using var client = Create(session);

		_ = await client.ExecuteApiAsync("getOrganizations", cancellationToken: TestContext.Current.CancellationToken);
		_ = await client.ExecuteApiAsync("getNetworks", cancellationToken: TestContext.Current.CancellationToken);

		client.Statistics.ToolCallCount.Should().Be(2);
	}

	// ---------------------------------------------------------------- disposal

	[Fact]
	public async Task Dispose_DisposesTheSession()
	{
		var session = new FakeMerakiMcpSession
		{
			OnCallTool = (_, _, _) => Task.FromResult(new MerakiMcpToolResponse(false, null, "{}"))
		};

		var client = Create(session);
		_ = await client.ExecuteApiAsync("getOrganizations", cancellationToken: TestContext.Current.CancellationToken);

		client.Dispose();

		session.DisposeCount.Should().Be(1);
	}

	[Fact]
	public async Task DisposeAsync_DisposesTheSession()
	{
		var session = new FakeMerakiMcpSession
		{
			OnCallTool = (_, _, _) => Task.FromResult(new MerakiMcpToolResponse(false, null, "{}"))
		};

		var client = Create(session);
		_ = await client.ExecuteApiAsync("getOrganizations", cancellationToken: TestContext.Current.CancellationToken);

		await client.DisposeAsync();

		session.DisposeCount.Should().Be(1);
	}

	[Fact]
	public void Dispose_IsIdempotent()
	{
		var session = new FakeMerakiMcpSession();
		var client = Create(session);

		client.Dispose();
		client.Dispose();

		session.DisposeCount.Should().Be(0, "no session was ever established");
	}

	[Fact]
	public async Task DisposeAsync_AfterDispose_IsSafe()
	{
		var session = new FakeMerakiMcpSession
		{
			OnCallTool = (_, _, _) => Task.FromResult(new MerakiMcpToolResponse(false, null, "{}"))
		};

		var client = Create(session);
		_ = await client.ExecuteApiAsync("getOrganizations", cancellationToken: TestContext.Current.CancellationToken);

		client.Dispose();
		await client.DisposeAsync();

		session.DisposeCount.Should().Be(1);
	}

	[Fact]
	public async Task Dispose_AfterDisposeAsync_IsSafe()
	{
		var session = new FakeMerakiMcpSession();
		var client = Create(session);

		await client.DisposeAsync();
		client.Dispose();

		session.DisposeCount.Should().Be(0);
	}

	[Fact]
	public async Task AfterDisposal_AllOperationsThrowObjectDisposedException()
	{
		var client = Create(new FakeMerakiMcpSession());
		client.Dispose();

		var search = async () => await client.SemanticSearchAsync("clients", TestContext.Current.CancellationToken);
		var execute = async () => await client.ExecuteApiAsync("getOrganizations", cancellationToken: TestContext.Current.CancellationToken);
		var status = async () => await client.GetStatusAsync(TestContext.Current.CancellationToken);

		await search.Should().ThrowAsync<ObjectDisposedException>();
		await execute.Should().ThrowAsync<ObjectDisposedException>();
		await status.Should().ThrowAsync<ObjectDisposedException>();
	}
}
