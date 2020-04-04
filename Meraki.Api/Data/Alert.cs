using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Alert
	/// </summary>
	[DataContract]
	public partial class Alert
	{
		/// <summary>
		/// The type of alert
		/// </summary>
		/// <value>The type of alert</value>
		[DataMember(Name = "type", EmitDefaultValue = false)]
		public string Type { get; set; }
		/// <summary>
		/// A boolean depicting if the alert is turned on or off
		/// </summary>
		/// <value>A boolean depicting if the alert is turned on or off</value>
		[DataMember(Name = "enabled", EmitDefaultValue = false)]
		public bool? Enabled { get; set; }
		/// <summary>
		/// Gets or Sets AlertDestinations
		/// </summary>
		[DataMember(Name = "alertDestinations", EmitDefaultValue = false)]
		public AlertDestinations AlertDestinations { get; set; }
		/// <summary>
		/// A hash of specific configuration data for the alert. Only filters specific to the alert will be updated.
		/// </summary>
		/// <value>A hash of specific configuration data for the alert. Only filters specific to the alert will be updated.</value>
		[DataMember(Name = "filters", EmitDefaultValue = false)]
		public object Filters { get; set; }
	}
}
