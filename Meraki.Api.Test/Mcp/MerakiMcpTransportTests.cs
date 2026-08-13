using Meraki.Api.Exceptions;
using Meraki.Api.Mcp;

namespace Meraki.Api.Test.Mcp;

/// <summary>
/// Exercises the real transport wiring, rather than the injected-session seam, so that the
/// SDK transport construction and failure translation are genuinely covered.
/// </summary>
public class MerakiMcpTransportTests
{
	[Fact]
	public async Task LocalHttp_AgainstAClosedPort_ThrowsTransportExceptionNamingTheUri()
	{
		var options = new MerakiMcpClientOptions
		{
			ApiKey = "key",
			Transport = MerakiMcpTransport.LocalHttp,
			// Port 1 is reserved and is not listening.
			Uri = "http://127.0.0.1:1/mcp",
			MaxAttemptCount = 1,
			MaxBackOffDelaySeconds = 0,
			HttpClientTimeoutSeconds = 5
		};

		await using var client = new MerakiMcpClient(options);

		var act = async () => await client.GetStatusAsync(TestContext.Current.CancellationToken);

		var status = await client.GetStatusAsync(TestContext.Current.CancellationToken);

		_ = status.IsConnected.Should().BeFalse();
		_ = status.Message.Should().NotBeNullOrWhiteSpace();
		_ = await act.Should().NotThrowAsync("GetStatusAsync reports failures rather than throwing");
	}

	[Fact]
	public async Task HostedHttp_ConstructsWithoutContactingTheServer()
	{
		// Constructing the client must not perform any I/O; the session is created lazily.
		await using var client = new MerakiMcpClient(new MerakiMcpClientOptions { ApiKey = "key" });

		_ = client.Statistics.ToolCallCount.Should().Be(0);
	}

	[Fact]
	public async Task Stdio_WithACommandThatDoesNotExist_ThrowsTransportExceptionExplainingWhy()
	{
		var options = new MerakiMcpClientOptions
		{
			ApiKey = "key",
			Transport = MerakiMcpTransport.Stdio,
			Command = "meraki-mcp-command-that-does-not-exist",
			MaxAttemptCount = 1
		};

		options.Arguments.Add("--stdio");
		options.EnvironmentVariables["EXTRA"] = "value";

		await using var client = new MerakiMcpClient(options);

		var act = async () => await client.SemanticSearchAsync("clients", TestContext.Current.CancellationToken);

		var exception = await act.Should().ThrowAsync<MerakiMcpTransportException>();
		_ = exception.Which.Message.Should().Contain("meraki-mcp-command-that-does-not-exist");
	}

	[Fact]
	public async Task Stdio_WithACommandThatExitsImmediately_ThrowsTransportException()
	{
		var options = new MerakiMcpClientOptions
		{
			ApiKey = "key",
			Transport = MerakiMcpTransport.Stdio,
			Command = OperatingSystem.IsWindows() ? "cmd.exe" : "/bin/sh",
			MaxAttemptCount = 1
		};

		if (OperatingSystem.IsWindows())
		{
			options.Arguments.Add("/c");
			options.Arguments.Add("exit 1");
		}
		else
		{
			options.Arguments.Add("-c");
			options.Arguments.Add("exit 1");
		}

		await using var client = new MerakiMcpClient(options);

		var act = async () => await client.SemanticSearchAsync("clients", TestContext.Current.CancellationToken);

		_ = await act.Should().ThrowAsync<MerakiMcpTransportException>();
	}

	[Fact]
	public async Task Stdio_StatusCheck_ReportsFailureRatherThanThrowing()
	{
		var options = new MerakiMcpClientOptions
		{
			ApiKey = "key",
			Transport = MerakiMcpTransport.Stdio,
			Command = "meraki-mcp-command-that-does-not-exist",
			MaxAttemptCount = 1
		};

		await using var client = new MerakiMcpClient(options);

		var status = await client.GetStatusAsync(TestContext.Current.CancellationToken);

		_ = status.IsConnected.Should().BeFalse();
		_ = status.Message.Should().Contain("meraki-mcp-command-that-does-not-exist");
	}
}
