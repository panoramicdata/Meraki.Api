using Meraki.Api.Exceptions;
using Meraki.Api.Mcp;

namespace Meraki.Api.Test.Mcp;

/// <summary>
/// Tool catalogue drift, status reporting, session lifecycle, statistics and disposal.
/// </summary>
public partial class MerakiMcpClientTests
{
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
		_ = exception.Which.ToolName.Should().Be(MerakiMcpClient.SemanticSearchToolName);
		_ = exception.Which.AvailableToolNames.Should().Contain("something_else");
		_ = exception.Which.Message.Should().Contain("something_else").And.Contain("beta");
	}

	[Fact]
	public async Task ExecuteApiAsync_WhenToolIsMissing_ThrowsWithNoneAdvertised()
	{
		var session = new FakeMerakiMcpSession();
		session.ToolNames.Clear();

		using var client = Create(session);

		var act = async () => await client.ExecuteApiAsync("getOrganizations", cancellationToken: TestContext.Current.CancellationToken);

		_ = await act.Should().ThrowAsync<MerakiMcpToolNotFoundException>().WithMessage("*none*");
	}

	// ---------------------------------------------------------------- status

	[Fact]
	public async Task GetStatusAsync_WhenBothToolsAdvertised_IsConnected()
	{
		using var client = Create(new FakeMerakiMcpSession());

		var status = await client.GetStatusAsync(TestContext.Current.CancellationToken);

		_ = status.IsConnected.Should().BeTrue();
		_ = status.Message.Should().BeNull();
		_ = status.AvailableToolNames.Should().Contain(MerakiMcpClient.SemanticSearchToolName);
		_ = status.ToString().Should().Contain("Connected");
	}

	[Fact]
	public async Task GetStatusAsync_WhenAToolIsMissing_IsDisconnectedAndSaysWhich()
	{
		var session = new FakeMerakiMcpSession();
		_ = session.ToolNames.Remove(MerakiMcpClient.ExecuteApiToolName);

		using var client = Create(session);

		var status = await client.GetStatusAsync(TestContext.Current.CancellationToken);

		_ = status.IsConnected.Should().BeFalse();
		_ = status.Message.Should().Contain(MerakiMcpClient.ExecuteApiToolName);
	}

	[Fact]
	public async Task GetStatusAsync_WhenNoToolsAdvertised_SaysNone()
	{
		var session = new FakeMerakiMcpSession();
		session.ToolNames.Clear();

		using var client = Create(session);

		var status = await client.GetStatusAsync(TestContext.Current.CancellationToken);

		_ = status.IsConnected.Should().BeFalse();
		_ = status.Message.Should().Contain("none");
	}

	[Fact]
	public async Task GetStatusAsync_WhenTheServerIsUnreachable_IsDisconnectedAndDoesNotThrow()
	{
		var client = new MerakiMcpClient(
			Options(),
			null,
			_ => throw new HttpRequestException("no route to host"));

		var status = await client.GetStatusAsync(TestContext.Current.CancellationToken);

		_ = status.IsConnected.Should().BeFalse();
		_ = status.Message.Should().Contain("no route to host");
		_ = status.ToString().Should().Contain("Disconnected");

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

		_ = status.ToString().Should().NotContain("super-secret-key");

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

		_ = session.ListToolNamesCallCount.Should().Be(1);
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

		_ = await Task.WhenAll(tasks);

		_ = sessionCreationCount.Should().Be(1);
		_ = session.Calls.Should().HaveCount(16);
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

		_ = await act.Should().ThrowAsync<OperationCanceledException>();
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

		_ = await act.Should().ThrowAsync<MerakiMcpProtocolException>().WithMessage("*the SDK exploded*");
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

		_ = await act.Should().ThrowAsync<MerakiMcpAuthenticationException>();
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

		_ = await act.Should().ThrowAsync<MerakiMcpAuthorizationException>();
	}

	[Fact]
	public void Translate_PreservesOperationCanceledException()
	{
		var original = new OperationCanceledException("stopped");

		_ = MerakiMcpClient.Translate(new InvalidOperationException("wrapper", original), "testing")
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

		_ = client.Statistics.ToolCallCount.Should().Be(2);
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

		_ = session.DisposeCount.Should().Be(1);
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

		_ = session.DisposeCount.Should().Be(1);
	}

	[Fact]
	public void Dispose_IsIdempotent()
	{
		var session = new FakeMerakiMcpSession();
		var client = Create(session);

		client.Dispose();
		client.Dispose();

		_ = session.DisposeCount.Should().Be(0, "no session was ever established");
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

		_ = session.DisposeCount.Should().Be(1);
	}

	[Fact]
	public async Task Dispose_AfterDisposeAsync_IsSafe()
	{
		var session = new FakeMerakiMcpSession();
		var client = Create(session);

		await client.DisposeAsync();
		client.Dispose();

		_ = session.DisposeCount.Should().Be(0);
	}

	[Fact]
	public async Task AfterDisposal_AllOperationsThrowObjectDisposedException()
	{
		var client = Create(new FakeMerakiMcpSession());
		client.Dispose();

		var search = async () => await client.SemanticSearchAsync("clients", TestContext.Current.CancellationToken);
		var execute = async () => await client.ExecuteApiAsync("getOrganizations", cancellationToken: TestContext.Current.CancellationToken);
		var status = async () => await client.GetStatusAsync(TestContext.Current.CancellationToken);

		_ = await search.Should().ThrowAsync<ObjectDisposedException>();
		_ = await execute.Should().ThrowAsync<ObjectDisposedException>();
		_ = await status.Should().ThrowAsync<ObjectDisposedException>();
	}
}
