using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Network device to be updated
	/// </summary>
	[DataContract]
	public class Appliance
	{
		/// <summary>
		/// Next upgrade
		/// </summary>
		[DataMember(Name = "nextUpgrade")]
		public NextUpgradeUpdate NextUpgrade { get; set; } = new();
	}
}
