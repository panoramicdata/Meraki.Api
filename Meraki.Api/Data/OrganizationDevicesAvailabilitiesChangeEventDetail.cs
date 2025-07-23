namespace Meraki.Api.Data;

/// <summary>
/// 
/// </summary>
[DataContract]
[DebuggerDisplay("{Name} = {Value}")]
public class OrganizationDevicesAvailabilitiesChangeEventDetail
{
	/// <summary>
	/// Name of the detail
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// Value of the detail
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "value")]
	public string Value { get; set; } = string.Empty;
}