namespace Meraki.Api.Data;

/// <summary>
/// Array of device specific details
/// </summary>
[DataContract]
public class OrganizationDevicesPacketCaptureFileDetail
{
	/// <summary>
	/// Name of detail
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// Product type this set of details belongs to
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "productType")]
	public string ProductType { get; set; } = string.Empty;

	/// <summary>
	/// Value of the named detail
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "value")]
	public string Value { get; set; } = string.Empty;
}