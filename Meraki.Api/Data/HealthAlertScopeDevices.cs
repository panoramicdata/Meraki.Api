namespace Meraki.Api.Data;

/// <summary>
/// Health alert scope device
/// </summary>
[DataContract]
public class HealthAlertScopeDevices
{
	/// <summary>
	/// Url
	/// </summary>
	[DataMember(Name = "url")]
	public string Url { get; set; } = string.Empty;

	/// <summary>
	/// Name
	/// </summary>
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// Product type
	/// </summary>
	[DataMember(Name = "productType")]
	public string ProductType { get; set; } = string.Empty;

	/// <summary>
	/// Serial
	/// </summary>
	[DataMember(Name = "serial")]
	public string Serial { get; set; } = string.Empty;

	/// <summary>
	/// Mac
	/// </summary>
	[DataMember(Name = "mac")]
	public string Mac { get; set; } = string.Empty;

	/// <summary>
	/// Lldp
	/// </summary>
	[DataMember(Name = "lldp")]
	public HealthAlertScopeDevicesLldp Lldp { get; set; } = new();

	/// <summary>
	/// Clients
	/// </summary>
	[DataMember(Name = "clients")]
	public List<Client> Clients { get; set; } = new();
}
