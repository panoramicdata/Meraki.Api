using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// UpdateNetworkNetflowSettings
	/// </summary>
	[DataContract]
	public partial class UpdateNetworkNetflowSettings
	{
		/// <summary>
		/// Boolean indicating whether NetFlow traffic reporting is enabled (true) or disabled (false).
		/// </summary>
		/// <value>Boolean indicating whether NetFlow traffic reporting is enabled (true) or disabled (false).</value>
		[DataMember(Name = "reportingEnabled", EmitDefaultValue = false)]
		public bool? ReportingEnabled { get; set; }
		/// <summary>
		/// The IPv4 address of the NetFlow collector.
		/// </summary>
		/// <value>The IPv4 address of the NetFlow collector.</value>
		[DataMember(Name = "collectorIp", EmitDefaultValue = false)]
		public string CollectorIp { get; set; }
		/// <summary>
		/// The port that the NetFlow collector will be listening on.
		/// </summary>
		/// <value>The port that the NetFlow collector will be listening on.</value>
		[DataMember(Name = "collectorPort", EmitDefaultValue = false)]
		public int? CollectorPort { get; set; }
	}
}
