using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// CreateOrganizationInsightMonitoredMediaServer
	/// </summary>
	[DataContract]
	public partial class InsightMonitoredMediaServerCreationRequest
	{
		/// <summary>
		/// The name of the VoIP provider
		/// </summary>
		/// <value>The name of the VoIP provider</value>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string Name { get; set; } = null!;

		/// <summary>
		/// The IP address (IPv4 only) or hostname of the media server to monitor
		/// </summary>
		/// <value>The IP address (IPv4 only) or hostname of the media server to monitor</value>
		[DataMember(Name = "address", EmitDefaultValue = false)]
		public string Address { get; set; } = null!;
	}
}
