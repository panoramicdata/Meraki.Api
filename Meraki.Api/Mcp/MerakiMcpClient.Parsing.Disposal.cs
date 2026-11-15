using ModelContextProtocol.Client;
using Newtonsoft.Json.Linq;
namespace Meraki.Api.Mcp;

// Codacy analyses each file on its own, so it reports 'partial' as gratuitous (S2333) and the static-only parts as S1118. The other parts live in sibling files.
#pragma warning disable S2333, S1118
public sealed partial class MerakiMcpClient : IDisposable, IAsyncDisposable
{
	private void ThrowIfDisposed() => ObjectDisposedException.ThrowIf(_isDisposed, this);

	/// <summary>
	/// Disposes the client, closing any session and terminating any child process.
	/// </summary>
	public void Dispose()
	{
		if (_isDisposed)
		{
			return;
		}

		_isDisposed = true;

		var session = _session;
		_session = null;

		// Block only as long as necessary; the SDK's disposal is asynchronous.
		session?.DisposeAsync().AsTask().GetAwaiter().GetResult();

		_sessionLock.Dispose();
	}

	/// <summary>
	/// Asynchronously disposes the client, closing any session and terminating any child process.
	/// </summary>
	/// <returns>A task that completes when disposal is complete.</returns>
	public async ValueTask DisposeAsync()
	{
		if (_isDisposed)
		{
			return;
		}

		_isDisposed = true;

		var session = _session;
		_session = null;

		if (session is not null)
		{
			await session.DisposeAsync().ConfigureAwait(false);
		}

		_sessionLock.Dispose();
	}
}
