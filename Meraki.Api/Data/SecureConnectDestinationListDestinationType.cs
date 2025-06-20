namespace Meraki.Api.Data;

/// <summary>
/// The type of the destination.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum SecureConnectDestinationListDestinationType
{
	/// <summary>
	/// domain
	/// </summary>
	[EnumMember(Value = "domain")]
	Domain,

	/// <summary>
	/// url
	/// </summary>
	[EnumMember(Value = "url")]
	Url,

	/// <summary>
	/// ipv4
	/// </summary>
	[EnumMember(Value = "ipv4")]
	Ipv4

}
