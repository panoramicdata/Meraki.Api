namespace Meraki.Api.Data;

[DataContract]
public enum OrganizationPolicyObjectsGroupCategory
{
	[EnumMember(Value = "NetworkObjectGroup")]
	NetworkObjectGroup = 1,

	[EnumMember(Value = "GeoLocationGroup")]
	GeoLocationGroup = 2,

	[EnumMember(Value = "PortObjectGroup")]
	PortObjectGroup = 3,

	[EnumMember(Value = "ApplicationGroup")]
	ApplicationGroup = 4,
}
