using Meraki.Api.Exceptions;
using Meraki.Api.Mcp;

namespace Meraki.Api.Test.Mcp;

/// <summary>
/// Capability execution, payload-level errors and response envelope unwrapping.
/// </summary>
public partial class MerakiMcpClientTests
{
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

		_ = result.CapabilityId.Should().Be("getNetworkClients");
		_ = result.RawJson.Should().Be("""{"clients":[]}""");
		_ = result.Text.Should().Be("text form");

		_ = session.Calls[0].ToolName.Should().Be(MerakiMcpClient.ExecuteApiToolName);
		_ = session.Calls[0].Arguments["capability_id"].Should().Be("getNetworkClients");
		_ = session.Calls[0].Arguments.Should().ContainKey("parameters");
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

		_ = session.Calls[0].Arguments.Should().NotContainKey("parameters");
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

		_ = session.Calls[0].Arguments.Should().NotContainKey("parameters");
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

		_ = result.RawJson.Should().Be("""{"a":1}""");
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

		_ = result.RawJson.Should().BeEmpty();
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
		_ = exception.Which.CapabilityId.Should().Be(capabilityId);
		_ = exception.Which.Message.Should().Contain(nameof(MerakiClient));

		_ = session.Calls.Should().BeEmpty("the guard must refuse before any call reaches the server");
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

		_ = result.CapabilityId.Should().Be("updateNetworkSsid");
	}

	[Theory]
	[InlineData(null)]
	[InlineData("")]
	[InlineData("  ")]
	public async Task ExecuteApiAsync_WithoutACapabilityId_Throws(string? capabilityId)
	{
		using var client = Create(new FakeMerakiMcpSession());

		var act = async () => await client.ExecuteApiAsync(capabilityId!, cancellationToken: TestContext.Current.CancellationToken);

		_ = await act.Should().ThrowAsync<ArgumentException>();
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

		_ = await act.Should().ThrowAsync<MerakiMcpProtocolException>()
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

		_ = await act.Should().ThrowAsync<MerakiMcpProtocolException>().WithMessage("*no detail supplied*");
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

		_ = await act.Should().ThrowAsync<MerakiMcpProtocolException>()
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

		_ = await act.Should().ThrowAsync<MerakiMcpProtocolException>().WithMessage("*Query too long*");
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

		_ = await act.Should().ThrowAsync<MerakiMcpProtocolException>()
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

		_ = await act.Should().ThrowAsync<MerakiMcpProtocolException>().WithMessage("*no detail supplied*");
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

		_ = result.RawJson.Should().Contain("Q2QN");
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
		_ = result.RawJson.Should().Contain("\"type\":\"success\"");

		// ...but the payload is the data element alone, matching the REST shape.
		_ = result.DataJson.Should().Be("""{"items":[{"serial":"Q4AA-FWF6-VWK6","model":"MS120-8"}]}""");
		_ = result.Payload.Should().Be(result.DataJson);
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

		_ = result.Deserialize<DeviceStub>()!.Serial.Should().Be("Q4AA-FWF6-VWK6");
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

		_ = result.DataJson.Should().BeNull();
		_ = result.Payload.Should().Be(result.RawJson);
		_ = result.Deserialize<DeviceStub>()!.Serial.Should().Be("Q4AA-FWF6-VWK6");
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

		_ = result.Deserialize<List<DeviceStub>>()!.Should().HaveCount(2);
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
}
