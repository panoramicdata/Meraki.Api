namespace Meraki.Api.Data;

/// <summary>
/// Updating device details (currently only used for Catalyst devices)
/// </summary>
[DataContract]
public class BulkDevicesUpdateDetail
{
	/// <summary>
	///	Name of device detail
	/// </summary>
	[ApiAccess(ApiAccess.Update)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// Value of device detail
	/// </summary>
	[ApiAccess(ApiAccess.Update)]
	[DataMember(Name = "value")]
	public string Value { get; set; } = string.Empty;
		;

}
