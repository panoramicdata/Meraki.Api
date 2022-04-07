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
	/// No documentation available
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "unsupportedModels")]
	public List<object>? UnsupportedModels { get; set; }
}