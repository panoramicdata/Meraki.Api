using Newtonsoft.Json.Linq;

namespace Meraki.Api.Data;

/// <summary>
/// The type of the destination list in the policy.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum SecureConnectDestinationListBundleType
{
	/// <summary>
	/// DNS - 1
	/// </summary>
	[EnumMember(Value = "1")]
	DNS1,

	/// <summary>
	/// web - 2
	/// </summary>
	[EnumMember(Value = "2")]
	Web2,

	/// <summary>
	/// SAML Bypass - 4
	/// </summary>
	[EnumMember(Value = "4")]
	SAMLBypass4

}
