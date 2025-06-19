namespace Meraki.Api.Data;

/// <summary>
/// Xdr Product Type
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum XdrProductType
{
	/// <summary>
	/// Appliance
	/// </summary>
	[EnumMember(Value = "appliance")]
	Appliance
}