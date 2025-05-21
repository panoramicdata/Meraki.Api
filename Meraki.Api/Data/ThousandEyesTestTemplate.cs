namespace Meraki.Api.Data;

/// <summary>
/// Thousand Eye test template object, maximun size: 1000
/// </summary>
[DataContract]
public class ThousandEyesTestTemplate
{
	/// <summary>
	/// Template Id
	/// </summary>
	[DataMember(Name = "id")]
	public string Id { get; set; } = string.Empty;

	/// <summary>
	/// Optional object containing customizable value for tenant
	/// </summary>
	[DataMember(Name = "userInputs")]
	public ThousandEyesTestTemplateUserInputs? UserInputs { get; set; }
}
