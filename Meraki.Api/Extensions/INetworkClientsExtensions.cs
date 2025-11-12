namespace Meraki.Api.Extensions;

/// <summary>
/// Extension methods for INetwork Clients
/// </summary>
public static class INetworkClientsExtensions
{
	/// <summary>
	/// Gets all network clients for a network with automatic pagination
	/// </summary>
	/// <param name="networkClients">The network clients section</param>
	/// <param name="networkId">The network ID</param>
	/// <param name="t0">The beginning of the timespan for the data</param>
	/// <param name="timespan">The timespan for which the information will be fetched</param>
	/// <param name="statuses">Filter by client connection statuses</param>
	/// <param name="ip">Filter clients by IP address</param>
	/// <param name="ip6">Filter clients by IPv6 address</param>
	/// <param name="ip6Local">Filter clients by local IPv6 address</param>
	/// <param name="mac">Filter clients by MAC address</param>
	/// <param name="os">Filter clients by operating system</param>
	/// <param name="pskGroup">Filter clients by PSK group</param>
	/// <param name="description">Filter clients by description</param>
	/// <param name="recentDeviceConnections">Filter clients by recent device connections</param>
	/// <param name="cancellationToken">The cancellation token</param>
	/// <returns>A list of all clients</returns>
	public static Task<List<Client>> GetNetworkClientsAllAsync(
		this NetworksClientsSection networkClients,
		string networkId,
		string t0 = null!,
		double? timespan = null,
		string? statuses = null,
		string? ip = null,
		string? ip6 = null,
		string? ip6Local = null,
		string? mac = null,
		string? os = null,
		string? pskGroup = null,
		string? description = null,
		List<string>? recentDeviceConnections = null,
		CancellationToken cancellationToken = default)
		=> MerakiClient.GetAllAsync(
			(startingAfter, endingBefore, cancellationToken)
			=> networkClients.Clients.GetNetworkClientsApiResponseAsync(
				networkId,
				t0,
				timespan,
				1000,
				startingAfter,
				endingBefore,
				statuses,
				ip,
				ip6,
				ip6Local,
				mac,
				os,
				pskGroup,
				description,
				recentDeviceConnections,
				cancellationToken
			),
			cancellationToken
		);
}}