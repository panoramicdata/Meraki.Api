namespace Meraki.Api.Data;

[DataContract]
public enum PayloadTemplateType
{
	[EnumMember(Value = "included")]
	Included = 1,

	[EnumMember(Value = "custom")]
	Custom = 2,
}