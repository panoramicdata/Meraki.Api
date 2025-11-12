namespace Meraki.Api.Data;

/// <summary>
/// Organization Policy Objects Group Category
/// </summary>
[DataContract]
public enum OrganizationPolicyObjectsGroupCategory
{
	/// <summary>
	/// Network Object Group
	/// </summary>
	[EnumMember(Value = "NetworkObjectGroup")]
	NetworkObjectGroup = 1,


	/// <summary>
	/// Geo Location Group
	/// </summary>
	[EnumMember(Value = "GeoLocationGroup")]
	GeoLocationGroup = 2,


	/// <summary>
	/// Port Object Group
	/// </summary>
	[EnumMember(Value = "PortObjectGroup")]
	PortObjectGroup = 3,


	/// <summary>
	/// Application Group
	/// </summary>
	[EnumMember(Value = "ApplicationGroup")]
	ApplicationGroup = 4,
}
