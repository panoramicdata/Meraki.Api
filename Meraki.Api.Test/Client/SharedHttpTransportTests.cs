using Microsoft.Extensions.Logging.Abstractions;
using System.Collections.Concurrent;
using System.Diagnostics.Metrics;
using System.Net;
using System.Net.Sockets;

namespace Meraki.Api.Test.Client;

/// <summary>
/// Every <see cref="MerakiClient"/> sends through one shared transport. These tests prove that sharing it
/// cannot carry one client's credential, cookies or lifetime over to another client.
/// They use real sockets against a local listener, with made-up keys: no network or credentials are needed.
/// </summary>
[Collection(nameof(SharedHttpTransportTests))]
public sealed class SharedHttpTransportTests : IDisposable
{
	private const string KeyA = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
	private const string KeyB = "bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb";
	private const string KeyHeader = "X-Cisco-Meraki-API-Key";

	private readonly RecordingServer _server = new();
	private readonly SocketsHttpHandler _transport = SharedHttpTransport.Create();

	public void Dispose()
	{
		_transport.Dispose();
		_server.Dispose();
	}

	private static MerakiClientOptions Options(string apiKey, int maxAttemptCount = 1) => new()
	{
		ApiKey = apiKey,
		UserAgent = "Meraki.Api.Test/1.0",
		MaxAttemptCount = maxAttemptCount,
		MaxBackOffDelaySeconds = 1
	};

	/// <summary>
	/// A client's own authenticating handler over a lease on the test transport: the same chain a
	/// <see cref="MerakiClient"/> builds, pointed at the local listener.
	/// </summary>
	private HttpClient CreateClient(string apiKey, int maxAttemptCount = 1)
	{
		var options = Options(apiKey, maxAttemptCount);
		var handler = new AuthenticatedBackingOffHttpClientHandler(
			options,
			new MerakiClient(options),
			NullLogger.Instance,
			SharedHttpTransport.Lease(_transport));
		return new HttpClient(handler) { BaseAddress = _server.BaseAddress };
	}

	[Fact]
	public void TheProcessWideTransport_KeepsNoCookiesAndNoCredentials()
	{
		var transport = SharedHttpTransport.Instance;

		_ = transport.UseCookies.Should().BeFalse();
		_ = transport.Credentials.Should().BeNull();
		_ = transport.PreAuthenticate.Should().BeFalse();
		_ = transport.PooledConnectionLifetime.Should().Be(SharedHttpTransport.PooledConnectionLifetime);
	}

	[Fact]
	public void EveryClient_GetsItsOwnHandle_OnTheSameTransport()
	{
		var first = (SharedHttpTransport.TransportLease)SharedHttpTransport.Lease();
		var second = (SharedHttpTransport.TransportLease)SharedHttpTransport.Lease();

		_ = first.Should().NotBeSameAs(second);
		_ = first.Transport.Should().BeSameAs(SharedHttpTransport.Instance);
		_ = second.Transport.Should().BeSameAs(SharedHttpTransport.Instance);
	}

	[Fact]
	public async Task TwoClientsWithDifferentKeys_EachSendOnlyTheirOwnKey_WhenInterleaved()
	{
		using var clientA = CreateClient(KeyA);
		using var clientB = CreateClient(KeyB);

		// The path says whose request it is, so the listener can check the key that arrived with it
		var calls = Enumerable
			.Range(0, 200)
			.Select(index => index % 2 == 0
				? clientA.GetAsync(new Uri($"a/{index}", UriKind.Relative), TestContext.Current.CancellationToken)
				: clientB.GetAsync(new Uri($"b/{index}", UriKind.Relative), TestContext.Current.CancellationToken));
		foreach (var response in await Task.WhenAll(calls))
		{
			response.Dispose();
		}

		_ = _server.Requests.Should().HaveCount(200);
		foreach (var request in _server.Requests)
		{
			var expectedKey = request.Path.StartsWith("/a/", StringComparison.Ordinal) ? KeyA : KeyB;
			_ = request.Headers.GetValues(KeyHeader).Should().Equal(expectedKey);
		}
	}

	[Fact]
	public async Task AReplacedKey_IsNeverSentAgain()
	{
		using (var oldClient = CreateClient(KeyA))
		{
			using var first = await oldClient.GetAsync(new Uri("old", UriKind.Relative), TestContext.Current.CancellationToken);
		}

		using var newClient = CreateClient(KeyB);
		for (var index = 0; index < 20; index++)
		{
			using var response = await newClient.GetAsync(new Uri($"new/{index}", UriKind.Relative), TestContext.Current.CancellationToken);
		}

		_ = _server.Requests
			.Where(request => request.Path.StartsWith("/new/", StringComparison.Ordinal))
			.Should().HaveCount(20)
			.And.OnlyContain(request => request.Headers.GetValues(KeyHeader)!.Single() == KeyB);
	}

	[Fact]
	public async Task ARejectedKey_DoesNotAffectAnotherClient()
	{
		_server.Respond = request => request.Headers[KeyHeader] == KeyA ? HttpStatusCode.Unauthorized : HttpStatusCode.OK;
		using var clientA = CreateClient(KeyA);
		using var clientB = CreateClient(KeyB);

		using var rejected = await clientA.GetAsync(new Uri("a", UriKind.Relative), TestContext.Current.CancellationToken);
		using var accepted = await clientB.GetAsync(new Uri("b", UriKind.Relative), TestContext.Current.CancellationToken);

		_ = rejected.StatusCode.Should().Be(HttpStatusCode.Unauthorized);
		_ = accepted.StatusCode.Should().Be(HttpStatusCode.OK);
		_ = _server.Requests.Should().HaveCount(2);
	}

	[Fact]
	public async Task ARetriedRequest_CarriesItsOwnKeyOnce_AndEachClientGetsItsOwnAnswer()
	{
		// Client A is told to back off once, so its request is sent twice while client B's goes through
		var attemptsByA = 0;
		_server.Respond = request => request.Headers[KeyHeader] == KeyA && Interlocked.Increment(ref attemptsByA) == 1
			? HttpStatusCode.TooManyRequests
			: HttpStatusCode.OK;
		using var clientA = CreateClient(KeyA, maxAttemptCount: 3);
		using var clientB = CreateClient(KeyB);

		var callA = clientA.GetStringAsync(new Uri("a/retried", UriKind.Relative), TestContext.Current.CancellationToken);
		var callB = clientB.GetStringAsync(new Uri("b/1", UriKind.Relative), TestContext.Current.CancellationToken);

		// The listener echoes the path it was asked for, so each caller can be shown to have its own answer
		_ = (await callA).Should().Be("/a/retried");
		_ = (await callB).Should().Be("/b/1");
		_ = _server.Requests.Where(request => request.Path == "/a/retried").Should().HaveCount(2)
			.And.OnlyContain(request => request.Headers.GetValues(KeyHeader)!.SequenceEqual(new[] { KeyA }));
		_ = _server.Requests.Where(request => request.Path == "/b/1").Should().ContainSingle()
			.Which.Headers.GetValues(KeyHeader).Should().Equal(KeyB);
	}

	[Fact]
	public async Task ACookieSetForOneClient_IsNeverSentByAnyClient()
	{
		_server.SetCookie = "who=a";
		using var clientA = CreateClient(KeyA);
		using var clientB = CreateClient(KeyB);

		using var first = await clientA.GetAsync(new Uri("a/1", UriKind.Relative), TestContext.Current.CancellationToken);
		using var second = await clientA.GetAsync(new Uri("a/2", UriKind.Relative), TestContext.Current.CancellationToken);
		using var third = await clientB.GetAsync(new Uri("b/1", UriKind.Relative), TestContext.Current.CancellationToken);

		_ = first.Headers.Contains("Set-Cookie").Should().BeTrue("the listener must really have offered a cookie");
		_ = _server.Requests.Should().HaveCount(3).And.OnlyContain(request => request.Headers["Cookie"] == null);
	}

	[Fact]
	public async Task DisposingOneClient_LeavesTheTransportOpenForTheOthers()
	{
		var clientA = CreateClient(KeyA);
		using var clientB = CreateClient(KeyB);
		using var before = await clientA.GetAsync(new Uri("a", UriKind.Relative), TestContext.Current.CancellationToken);

		clientA.Dispose();

		using var after = await clientB.GetAsync(new Uri("b", UriKind.Relative), TestContext.Current.CancellationToken);
		_ = after.StatusCode.Should().Be(HttpStatusCode.OK);
	}

	[Fact]
	public async Task DisposingAMerakiClient_LeavesTheProcessWideTransportUsable()
	{
		new MerakiClient(Options(KeyA)).Dispose();

		// A disposed transport throws ObjectDisposedException on its next send
		using var probe = new HttpClient(SharedHttpTransport.Lease());
		using var response = await probe.GetAsync(new Uri(_server.BaseAddress, "probe"), TestContext.Current.CancellationToken);

		_ = response.StatusCode.Should().Be(HttpStatusCode.OK);
	}

	[Fact]
	public async Task ManyClients_PublishNoMoreConnectionInstruments_ThanOneTransport()
	{
		// .NET 11 publishes a new "http.client.open_connections" instrument for every transport that sends,
		// and never removes it. One shared transport must therefore publish it once, however many clients there are.
		var published = 0;
		void CountIfOpenConnections(Instrument instrument)
		{
			if (instrument.Meter.Name == "System.Net.Http" && instrument.Name == "http.client.open_connections")
			{
				Interlocked.Increment(ref published);
			}
		}

		using var listener = new MeterListener
		{
			InstrumentPublished = (instrument, _) => CountIfOpenConnections(instrument)
		};

		listener.Start();
		using (var warmUp = CreateClient(KeyA))
		{
			using var response = await warmUp.GetAsync(new Uri("warm-up", UriKind.Relative), TestContext.Current.CancellationToken);
		}

		var publishedByOneClient = Volatile.Read(ref published);
		_ = publishedByOneClient.Should().BeGreaterThan(0, "the first transport to send publishes the instrument");

		for (var index = 0; index < 50; index++)
		{
			using var client = CreateClient(index % 2 == 0 ? KeyA : KeyB);
			using var response = await client.GetAsync(new Uri($"call/{index}", UriKind.Relative), TestContext.Current.CancellationToken);
		}

		_ = Volatile.Read(ref published).Should().Be(publishedByOneClient);
	}

	/// <summary>
	/// A local HTTP listener that records what actually arrived on the wire.
	/// </summary>
	private sealed class RecordingServer : IDisposable
	{
		private readonly HttpListener _listener = new();
		private readonly CancellationTokenSource _stopping = new();

		public RecordingServer()
		{
			// HttpListener cannot bind to port 0, so find a free port first
			using (var probe = new TcpListener(IPAddress.Loopback, 0))
			{
				probe.Start();
				BaseAddress = new Uri($"http://127.0.0.1:{((IPEndPoint)probe.LocalEndpoint).Port}/");
			}

			_listener.Prefixes.Add(BaseAddress.AbsoluteUri);
			_listener.Start();
			_ = Task.Run(ServeAsync);
		}

		public Uri BaseAddress { get; }

		public ConcurrentQueue<(string Path, System.Collections.Specialized.NameValueCollection Headers)> Requests { get; } = new();

		public Func<HttpListenerRequest, HttpStatusCode> Respond { get; set; } = _ => HttpStatusCode.OK;

		public string? SetCookie { get; set; }

		private async Task ServeAsync()
		{
			while (!_stopping.IsCancellationRequested)
			{
				HttpListenerContext context;
				try
				{
					context = await _listener.GetContextAsync().ConfigureAwait(false);
				}
				catch (Exception exception) when (exception is HttpListenerException or ObjectDisposedException or InvalidOperationException)
				{
					return;
				}

				Requests.Enqueue((context.Request.Url!.AbsolutePath, context.Request.Headers));
				context.Response.StatusCode = (int)Respond(context.Request);
				if (SetCookie is not null)
				{
					context.Response.Headers.Add("Set-Cookie", SetCookie);
				}

				await context.Response.OutputStream.WriteAsync(System.Text.Encoding.UTF8.GetBytes(context.Request.Url!.AbsolutePath)).ConfigureAwait(false);
				context.Response.Close();
			}
		}

		public void Dispose()
		{
			_stopping.Cancel();
			_listener.Close();
			_stopping.Dispose();
		}
	}
}

/// <summary>
/// The instrument count is process-wide, so these tests must not run alongside others that send over HTTP.
/// </summary>
[CollectionDefinition(nameof(SharedHttpTransportTests), DisableParallelization = true)]
public sealed class SharedHttpTransportTestsSerial;
