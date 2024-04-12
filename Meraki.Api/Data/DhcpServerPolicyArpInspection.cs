namespace Meraki.Api.Data;

/// <summary>
/// No documentation available
/// </summary>
[DataContract]
public class DhcpServerPolicyArpInspection
{
	/// <summary>
	/// No documentation available
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "enabled")]
	public bool Enabled { get; set; }

	/// <summary>
	/// List of switch models that does not support dynamic ARP inspection
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "unsupportedModels")]
	public List<string>? UnsupportedModels { get; set; }
}