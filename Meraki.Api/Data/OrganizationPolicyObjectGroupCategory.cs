namespace Meraki.Api.Data;

/// <summary>
/// Organization Policy Objects Group Category
/// </summary>
[DataContract]
public enum OrganizationPolicyObjectsGroupCategory
{
	[EnumMember(Value = "NetworkObjectGroup")]
	/// <summary>
	/// Network Object Group
	/// </summary>
	NetworkObjectGroup = 1,

	[EnumMember(Value = "GeoLocationGroup")]
	/// <summary>
	/// Geo Location Group
	/// </summary>
	GeoLocationGroup = 2,

	[EnumMember(Value = "PortObjectGroup")]
	/// <summary>
	/// Port Object Group
	/// </summary>
	PortObjectGroup = 3,

	[EnumMember(Value = "ApplicationGroup")]
	/// <summary>
	/// Application Group
	/// </summary>
	ApplicationGroup = 4,
}
