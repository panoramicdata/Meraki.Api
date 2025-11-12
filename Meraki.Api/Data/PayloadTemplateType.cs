namespace Meraki.Api.Data;

/// <summary>
/// Payload Template Type
/// </summary>
[DataContract]
public enum PayloadTemplateType
{
	[EnumMember(Value = "included")]
	/// <summary>
	/// Included
	/// </summary>
	Included = 1,

	[EnumMember(Value = "custom")]
	/// <summary>
	/// Custom
	/// </summary>
	Custom = 2,
}
