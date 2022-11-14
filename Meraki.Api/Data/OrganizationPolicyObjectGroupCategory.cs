namespace Meraki.Api.Data;

[DataContract]
public enum OrganizationPolicyObjectsGroupCategory
{
	[EnumMember(Value = "networkObjectGroup")]
	NetworkObjectGroup = 1,

	[EnumMember(Value = "geoLocationGroup")]
	GeoLocationGroup = 2,

	[EnumMember(Value = "portObjectGroup")]
	PortObjectGroup = 3,

	[EnumMember(Value = "applicationGroup")]
	ApplicationGroup = 4,
}
