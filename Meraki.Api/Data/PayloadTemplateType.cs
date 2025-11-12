namespace Meraki.Api.Data;

/// <summary>
/// Payload Template Type
/// </summary>
[DataContract]
public enum PayloadTemplateType
{
	/// <summary>
	/// Included
	/// </summary>
	[EnumMember(Value = "included")]
	Included = 1,


	/// <summary>
	/// Custom
	/// </summary>
	[EnumMember(Value = "custom")]
	Custom = 2,
}
