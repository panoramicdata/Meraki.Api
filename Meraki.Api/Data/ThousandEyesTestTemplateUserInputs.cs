namespace Meraki.Api.Data;

/// <summary>
/// Optional object containing customizable value for tenant
/// </summary>
[DataContract]
public class ThousandEyesTestTemplateUserInputs
{
	/// <summary>
	/// Tenant value
	/// </summary>
	[DataMember(Name = "tenant")]
	public string? Tenant { get; set; }
}