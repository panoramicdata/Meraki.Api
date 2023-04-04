namespace Meraki.Api.Interfaces.General.Networks;

public interface INetworksSyslogServers
{
	/// <summary>
	/// List the syslog servers for a network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	[Get("/networks/{networkId}/syslogServers")]
	Task<SyslogServers> GetNetworkSyslogServersAsync(
		string networkId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Update the syslog servers for a network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="syslogServers"></param>
	[Put("/networks/{networkId}/syslogServers")]
	Task<SyslogServers> UpdateNetworkSyslogServersAsync(
		string networkId,
		[Body] SyslogServers syslogServers,
		CancellationToken cancellationToken = default
		);
}
