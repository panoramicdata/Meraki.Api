namespace Meraki.Api.Data;

/// <summary>
/// RadiusAccountingServer
/// </summary>
[DataContract]
public class RadiusAccountingServer : IdentifiedItem
{
	/// <summary>
	/// IP address to which the APs will send RADIUS accounting messages
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "host")]
	public string Host { get; set; } = null!;

	/// <summary>
	/// Port on the RADIUS server that is listening for accounting messages
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "port")]
	public int? Port { get; set; }

	/// <summary>
	/// Shared key used to authenticate messages between the APs and RADIUS server
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "secret")]
	public string Secret { get; set; } = null!;

	/// <summary>
	/// Radsec enabled
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "radsecEnabled")]
	public bool? RadsecEnabled { get; set; }
}
