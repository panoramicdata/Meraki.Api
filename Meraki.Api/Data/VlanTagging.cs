using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// The VLAN tagging settings for your group policy. Only available if your network has a wireless configuration.
	/// </summary>
	[DataContract]
	public class VlanTagging
	{
		/// <summary>
		/// Gets or Sets Settings
		/// </summary>
		[DataMember(Name = "settings", EmitDefaultValue = false)]
		public Setting Settings { get; set; }

		/// <summary>
		/// The ID of the vlan you want to tag. This only applies if &#39;settings&#39; is set to &#39;custom&#39;.
		/// </summary>
		/// <value>The ID of the vlan you want to tag. This only applies if &#39;settings&#39; is set to &#39;custom&#39;.</value>
		[DataMember(Name = "vlanId", EmitDefaultValue = false)]
		public string VlanId { get; set; } = null!;
	}
}
