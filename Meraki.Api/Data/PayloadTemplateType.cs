namespace Meraki.Api.Data;

/// <summary>
/// Payload Template Type
/// </summary>
[DataContract]
public enum PayloadTemplateType
{
	[EnumMember(Value = "included")]
	Included = 1,

	[EnumMember(Value = "custom")]
	Custom = 2,
}
