using ModelContextProtocol.Client;
using Newtonsoft.Json.Linq;

namespace Meraki.Api.Mcp;

// Codacy analyses each file on its own, so it reports 'partial' as gratuitous (S2333) and the static-only parts as S1118. The other parts live in sibling files.
#pragma warning disable S2333, S1118
public sealed partial class MerakiMcpClient
{
	private async Task<MerakiMcpToolResponse> CallToolAsync(
		string toolName,
		IReadOnlyDictionary<string, object?> arguments,
		CancellationToken cancellationToken)
	{
		var toolNames = await GetToolNamesAsync(cancellationToken).ConfigureAwait(false);

		if (!toolNames.Contains(toolName, StringComparer.Ordinal))
		{
			throw new MerakiMcpToolNotFoundException(toolName, toolNames);
		}

		var session = await GetSessionAsync(cancellationToken).ConfigureAwait(false);

		Statistics.RecordToolCall();

		try
		{
			return await session
				.CallToolAsync(toolName, arguments, cancellationToken)
				.ConfigureAwait(false);
		}
		catch (Exception ex)
		{
			throw Translate(ex, $"calling tool '{toolName}'");
		}
	}

	private async Task<IReadOnlyList<string>> GetToolNamesAsync(CancellationToken cancellationToken)
	{
		if (_toolNames is not null)
		{
			return _toolNames;
		}

		var session = await GetSessionAsync(cancellationToken).ConfigureAwait(false);

		try
		{
			_toolNames = await session.ListToolNamesAsync(cancellationToken).ConfigureAwait(false);
		}
		catch (Exception ex)
		{
			throw Translate(ex, "listing the server's tools");
		}

		return _toolNames;
	}

	private async Task<IMerakiMcpSession> GetSessionAsync(CancellationToken cancellationToken)
	{
		if (_session is not null)
		{
			return _session;
		}

		await _sessionLock.WaitAsync(cancellationToken).ConfigureAwait(false);
		try
		{
			ThrowIfDisposed();

			if (_session is null)
			{
				try
				{
					_session = await _sessionFactory(cancellationToken).ConfigureAwait(false);
				}
				catch (Exception ex)
				{
					throw Translate(ex, "establishing a session");
				}
			}

			return _session;
		}
		finally
		{
			_ = _sessionLock.Release();
		}
	}
}
