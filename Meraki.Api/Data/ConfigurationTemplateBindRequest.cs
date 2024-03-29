namespace Meraki.Api.Data;

/// <summary>
/// A ConfigurationTemplate bind request
/// </summary>
[DataContract]
public class ConfigurationTemplateBindRequest
{
	/// <summary>
	/// The ID of the template to which the network should be bound.
	/// </summary>
	/// <value>The ID of the template to which the network should be bound.</value>
	[DataMember(Name = "configTemplateId")]
	public string ConfigurationTemplateId { get; set; } = string.Empty;

	/// <summary>
	/// Optional boolean indicating whether the network's switches should automatically bind to profiles of the same model. Defaults to false if left unspecified. This option only affects switch networks and switch templates. Auto-bind is not valid unless the switch template has at least one profile and has at most one profile per switch model.
	/// </summary>
	/// <value>Optional boolean indicating whether the network's switches should automatically bind to profiles of the same model. Defaults to false if left unspecified. This option only affects switch networks and switch templates. Auto-bind is not valid unless the switch template has at least one profile and has at most one profile per switch model.</value>
	[DataMember(Name = "autoBind")]
	public bool? AutoBind { get; set; }
}
