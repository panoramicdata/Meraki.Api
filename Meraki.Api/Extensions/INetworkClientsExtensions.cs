namespace Meraki.Api.Extensions;

public static class INetworkClientsExtensions
{
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
}