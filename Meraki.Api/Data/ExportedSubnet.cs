using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Exported subnet
	/// </summary>
	[DataContract]
	public partial class ExportedSubnet
	{
		/// <summary>
		/// Subnet
		/// </summary>
		[DataMember(Name = "subnet")]
		public string Subnet { get; set; } = string.Empty;

		/// <summary>
		/// Name
		/// </summary>
		[DataMember(Name = "name")]
		public string Name { get; set; } = string.Empty;
	}
}
