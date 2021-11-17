namespace Meraki.Api.Data;

/// <summary>
/// An organization device
/// </summary>
[DataContract]
public class OrganizationDevice : NamedItem
{
	/// <summary>
	/// serial
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "serial")]
	public string Serial { get; set; } = string.Empty;

	/// <summary>
	/// mac
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "mac")]
	public string Mac { get; set; } = string.Empty;

	/// <summary>
	/// networkId
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[ApiForeignKey(typeof(Network))]
	[DataMember(Name = "networkId")]
	public string NetworkId { get; set; } = string.Empty;

	/// <summary>
	/// model
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "model")]
	public string Model { get; set; } = string.Empty;

	/// <summary>
	/// address
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "address")]
	public string Address { get; set; } = string.Empty;

	/// <summary>
	/// lat
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "lat")]
	public double Lat { get; set; }

	/// <summary>
	/// lng
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "lng")]
	public double Lng { get; set; }

	/// <summary>
	/// notes
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "notes")]
	public string Notes { get; set; } = string.Empty;

	/// <summary>
	/// tags
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "tags")]
	public List<string> Tags { get; set; } = new();

	/// <summary>
	/// lanIp
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "lanIp")]
	public string LanIp { get; set; } = string.Empty;

	/// <summary>
	/// configurationUpdatedAt
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "configurationUpdatedAt")]
	public DateTime ConfigurationUpdatedAt { get; set; }

	/// <summary>
	/// firmware
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "firmware")]
	public string Firmware { get; set; } = string.Empty;

	/// <summary>
	/// url
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "url")]
	public string Url { get; set; } = string.Empty;

	/// <summary>
	/// ProductType
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "productType")]
	public ProductType ProductType { get; set; }
}
