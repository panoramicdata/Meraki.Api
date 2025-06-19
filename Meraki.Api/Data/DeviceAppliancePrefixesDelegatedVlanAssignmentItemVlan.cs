namespace Meraki.Api.Data;

/// <summary>
/// Vlan
/// </summary>
[DataContract]
public class DeviceAppliancePrefixesDelegatedVlanAssignmentItemVlan
{
	/// <summary>
	/// Id
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "id")]
	public int Id { get; set; }

	/// <summary>
	/// Name
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;
}