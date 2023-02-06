namespace Meraki.Api.Data;

/// <summary>
/// An array of the related devices for the role
/// </summary>
[DataContract]
public class SensorRelationshipLivestreamRelatedDevice
{
	///<summary>
	/// The product type of the related device
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "productType")]
	public string? ProductType { get; set; }

	///<summary>
	/// The serial of the related device
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "serial")]
	public string Serial { get; set; } = string.Empty;
}