using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Action
	/// </summary>
	[DataContract]
	public partial class Action
	{
		/// <summary>
		/// Unique identifier for the resource to be acted on
		/// </summary>
		/// <value>Unique identifier for the resource to be acted on</value>
		[DataMember(Name = "resource", EmitDefaultValue = false)]
		public string Resource { get; set; } = null!;

		/// <summary>
		/// The operation to be used
		/// </summary>
		/// <value>The operation to be used</value>
		[DataMember(Name = "operation", EmitDefaultValue = false)]
		public string Operation { get; set; } = null!;
	}
}