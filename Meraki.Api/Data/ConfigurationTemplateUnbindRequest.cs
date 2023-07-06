namespace Meraki.Api.Data;

/// <summary>
/// A ConfigurationTemplate unbind request
/// </summary>
[DataContract]
public class ConfigurationTemplateUnbindRequest
{
	/// <summary>
	/// Optional boolean to retain all the current configs given by the template.
	/// </summary>
	/// <value>Optional boolean to retain all the current configs given by the template.</value>
	[DataMember(Name = "retainConfigs")]
	public bool? RetainConfigs { get; set; }
}
