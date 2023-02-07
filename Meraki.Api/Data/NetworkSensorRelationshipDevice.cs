namespace Meraki.Api.Data;

/// <summary>
/// A sensor or gateway device in the network
/// </summary>
[DataContract]
public class NetworkSensorRelationshipDevice
{
	/// <summary>
	/// The name of the device
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// The product type of the device
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "productType")]
	public string ProductType { get; set; } = string.Empty;

	/// <summary>
	/// The serial of the device
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "serial")]
	public string Serial { get; set; } = string.Empty;
}