namespace Meraki.Api.Data;

/// <summary>
/// Origin
/// </summary>
[DataContract]
public class DeviceAppliancePrefixesDelegatedVlanAssignmentItemOrigin
{
	/// <summary>
	/// Interface
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "interface")]
	public string Interface { get; set; } = string.Empty;

	/// <summary>
	/// Prefix
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "prefix")]
	public string Prefix { get; set; } = string.Empty;
}