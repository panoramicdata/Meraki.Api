using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// UpdateNetworkGroupPolicy
	/// </summary>
	[DataContract]
	public partial class GroupPolicyUpdateRequest
	{
		/// <summary>
		/// The name for your group policy.
		/// </summary>
		/// <value>The name for your group policy.</value>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string Name { get; set; } = string.Empty;
		/// <summary>
		/// Gets or Sets Scheduling
		/// </summary>
		[DataMember(Name = "scheduling", EmitDefaultValue = false)]
		public Scheduling Scheduling { get; set; } = new();
		/// <summary>
		/// Gets or Sets Bandwidth
		/// </summary>
		[DataMember(Name = "bandwidth", EmitDefaultValue = false)]
		public Bandwidth Bandwidth { get; set; } = new();
		/// <summary>
		/// Gets or Sets FirewallAndTrafficShaping
		/// </summary>
		[DataMember(Name = "firewallAndTrafficShaping", EmitDefaultValue = false)]
		public FirewallAndTrafficShaping FirewallAndTrafficShaping { get; set; } = new();
		/// <summary>
		/// Gets or Sets ContentFiltering
		/// </summary>
		[DataMember(Name = "contentFiltering", EmitDefaultValue = false)]
		public ContentFiltering ContentFiltering { get; set; } = new();
		/// <summary>
		/// Gets or Sets SplashAuthSettings
		/// </summary>
		[DataMember(Name = "splashAuthSettings", EmitDefaultValue = false)]
		public SplashAuthSetting SplashAuthSettings { get; set; }
		/// <summary>
		/// Gets or Sets VlanTagging
		/// </summary>
		[DataMember(Name = "vlanTagging", EmitDefaultValue = false)]
		public VlanTagging VlanTagging { get; set; } = new();
		/// <summary>
		/// Gets or Sets BonjourForwarding
		/// </summary>
		[DataMember(Name = "bonjourForwarding", EmitDefaultValue = false)]
		public BonjourForwarding BonjourForwarding { get; set; } = new();
	}
}
