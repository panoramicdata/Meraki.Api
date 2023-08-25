namespace Meraki.Api.Data;

/// <summary>
/// The PayloadTemplate
/// </summary>
[DataContract]
public class PayloadTemplateHeader : NamedItem
{
	/// <summary>
	/// The ID
	/// </summary>
	[ApiKey]
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "template")]
	public string Template { get; set; } = null!;
}