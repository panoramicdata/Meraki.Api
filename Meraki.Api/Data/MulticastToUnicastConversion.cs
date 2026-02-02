namespace Meraki.Api.Data;

/// <summary>
/// Multicast to unicast conversion settings
/// </summary>
[DataContract]
public class MulticastToUnicastConversion
{
	/// <summary>
	/// Whether multicast to unicast conversion is enabled. Undocumented property.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "enabled")]
	public bool? Enabled { get; set; }
}
