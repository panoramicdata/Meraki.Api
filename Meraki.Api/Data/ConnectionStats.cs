namespace Meraki.Api.Data;

/// <summary>
/// Connection Stats
/// </summary>
[DataContract]
public class ConnectionStats
{
	/// <summary>
	/// assoc
	/// </summary>
	[DataMember(Name = "assoc")]
	public long Assoc { get; set; }

	/// <summary>
	/// auth
	/// </summary>
	[DataMember(Name = "auth")]
	public long Auth { get; set; }

	/// <summary>
	/// dhcp
	/// </summary>
	[DataMember(Name = "dhcp")]
	public long Dhcp { get; set; }

	/// <summary>
	/// dns
	/// </summary>
	[DataMember(Name = "dns")]
	public long Dns { get; set; }

	/// <summary>
	/// success
	/// </summary>
	[DataMember(Name = "success")]
	public long Success { get; set; }

	/// <summary>
	/// Total (sum of all the others)
	/// </summary>
	public long Total => Assoc + Auth + Dhcp + Dns + Success;
}
