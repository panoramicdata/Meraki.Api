namespace Meraki.Api;

/// <summary>
/// The one network transport that every <see cref="MerakiClient"/> in the process sends through.
/// </summary>
/// <remarks>
/// <para>
/// A transport owns connections and nothing else. It is deliberately built so that it cannot carry
/// anything from one client to another: cookies are off and it has no credentials of its own. The
/// API key or access token is added to each request by the client's own
/// <see cref="AuthenticatedBackingOffHttpClientHandler"/>, which sits above the transport and is
/// never shared.
/// </para>
/// <para>
/// Sharing matters because a transport is expensive to set up and, on .NET 11, the runtime keeps
/// metric instruments for every transport that has sent a request, even after it is disposed. An
/// application that creates a client per operation would otherwise grow without bound.
/// </para>
/// </remarks>
internal static class SharedHttpTransport
{
	/// <summary>
	/// How long a pooled connection is reused before it is replaced, so that DNS changes are picked
	/// up even though the transport itself lives as long as the process.
	/// </summary>
	internal static readonly TimeSpan PooledConnectionLifetime = TimeSpan.FromMinutes(5);

	private static readonly Lazy<SocketsHttpHandler> _instance = new(Create);

	/// <summary>
	/// The process-wide transport, created on first use.
	/// </summary>
	internal static SocketsHttpHandler Instance => _instance.Value;

	/// <summary>
	/// Creates a transport with the settings every shared transport must have.
	/// </summary>
	internal static SocketsHttpHandler Create() => new()
	{
		// A cookie container on a shared transport would replay one client's cookies on another's requests.
		UseCookies = false,
		PooledConnectionLifetime = PooledConnectionLifetime
	};

	/// <summary>
	/// Gives one client its own handle on the shared transport. Disposing the handle, which happens
	/// when the client is disposed, leaves the transport open for every other client.
	/// </summary>
	/// <remarks>
	/// Where the runtime has no socket transport (a browser), each client gets the platform's own handler, as before.
	/// </remarks>
	internal static HttpMessageHandler Lease() => SocketsHttpHandler.IsSupported ? Lease(Instance) : new HttpClientHandler();

	/// <summary>
	/// Gives one client its own handle on the given transport, which the handle never disposes.
	/// </summary>
	internal static HttpMessageHandler Lease(HttpMessageHandler transport) => new TransportLease(transport);

	/// <summary>
	/// One client's handle on a transport. It forwards every request and owns nothing, so disposing
	/// it cannot close the transport.
	/// </summary>
	internal sealed class TransportLease(HttpMessageHandler transport) : HttpMessageHandler
	{
		private readonly HttpMessageInvoker _invoker = new(transport, disposeHandler: false);

		/// <summary>
		/// The transport this handle sends through.
		/// </summary>
		internal HttpMessageHandler Transport { get; } = transport;

		protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
			=> _invoker.SendAsync(request, cancellationToken);
	}
}