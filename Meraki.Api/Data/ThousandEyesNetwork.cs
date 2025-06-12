namespace Meraki.Api.Data;

/// <summary>
/// ThousandEyes network
/// </summary>
[DataContract]
public class ThousandEyesNetwork
{
	/// <summary>
	/// ThousandEyes agent identifier
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "agentId")]
	public string AgentId { get; set; } = string.Empty;

	/// <summary>
	/// Network that will have the ThousandEyes agent installed on
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "networkId")]
	public string NetworkId { get; set; } = string.Empty;

	/// <summary>
	/// Whether or not the ThousandEyes agent is enabled for the network
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "enabled")]
	public bool Enabled { get; set; }
}
