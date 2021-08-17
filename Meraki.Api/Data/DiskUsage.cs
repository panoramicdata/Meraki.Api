using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Disk usage
	/// </summary>
	[DataContract]
	public class DiskUsage
	{
		/// <summary>
		/// C
		/// </summary>
		[DataMember(Name = "c")]
		public DiskUsageC C { get; set; } = new();
	}
}
