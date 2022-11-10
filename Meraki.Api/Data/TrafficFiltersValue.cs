namespace Meraki.Api.Data;

/// <summary>
/// Value
/// </summary>
[DataContract]
public class TrafficFiltersValue : NamedItem
{
	/// <summary>
	/// Protocol of this custom type traffic filter. Must be one of: 'tcp', 'udp', 'icmp' or 'any'
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "protocol")]
	public FirewallProtocol Protocol { get; set; }

	/// <summary>
	/// Source of this custom type traffic filter
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "source")]
	public ValueSource? Source { get; set; }

	/// <summary>
	/// Destination of this custom type traffic filter
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "destination")]
	public ValueSource? Destination { get; set; }

	/// <summary>
	/// ID of this applicationCategory or application type traffic filter. E.g.: "meraki:layer7/category/1", "meraki:layer7/application/4"
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "id")]
	public string? Id { get; set; }
}
