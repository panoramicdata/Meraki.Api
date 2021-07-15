using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// A ConfigurationTemplate bind request
	/// </summary>
	[DataContract]
	public partial class ConfigurationTemplateBindRequest
	{
		/// <summary>
		/// The ID of the template to which the network should be bound.
		/// </summary>
		/// <value>The ID of the template to which the network should be bound.</value>
		[DataMember(Name = "configTemplateId", EmitDefaultValue = false)]
		public string ConfigurationTemplateId { get; set; } = string.Empty;

		/// <summary>
		/// Optional boolean indicating whether the network&#39;s switches should automatically bind to profiles of the same model. Defaults to false if left unspecified. This option only affects switch networks and switch templates. Auto-bind is not valid unless the switch template has at least one profile and has at most one profile per switch model.
		/// </summary>
		/// <value>Optional boolean indicating whether the network&#39;s switches should automatically bind to profiles of the same model. Defaults to false if left unspecified. This option only affects switch networks and switch templates. Auto-bind is not valid unless the switch template has at least one profile and has at most one profile per switch model.</value>
		[DataMember(Name = "autoBind", EmitDefaultValue = false)]
		public bool? AutoBind { get; set; }
	}
}
