using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Destination
	/// </summary>
	[DataContract]
	public partial class Destination
	{
		/// <summary>
		/// The IP address to test connectivity with
		/// </summary>
		/// <value>The IP address to test connectivity with</value>
		[DataMember(Name = "ip", EmitDefaultValue = false)]
		public string Ip { get; set; }
		/// <summary>
		/// Description of the testing destination. Optional, defaults to null
		/// </summary>
		/// <value>Description of the testing destination. Optional, defaults to null</value>
		[DataMember(Name = "description", EmitDefaultValue = false)]
		public string Description { get; set; }
		/// <summary>
		/// Boolean indicating whether this is the default testing destination (true) or not (false). Defaults to false. Only one default is allowed
		/// </summary>
		/// <value>Boolean indicating whether this is the default testing destination (true) or not (false). Defaults to false. Only one default is allowed</value>
		[DataMember(Name = "default", EmitDefaultValue = false)]
		public bool? _Default { get; set; }
	}
}
