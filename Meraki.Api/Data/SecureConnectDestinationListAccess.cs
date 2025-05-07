namespace Meraki.Api.Data;

/// <summary>
/// The type of access for the destination list.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum SecureConnectDestinationListAccess
{
	/// <summary>
	/// allow
	/// </summary>
	[EnumMember(Value = "allow")]
	Allow,

	/// <summary>
	/// block
	/// </summary>
	[EnumMember(Value = "block")]
	Block,
}
