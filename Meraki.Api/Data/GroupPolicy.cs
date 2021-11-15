namespace Meraki.Api.Data;

/// <summary>
/// CreateNetworkGroupPolicy
/// </summary>
[DataContract]
public class GroupPolicy : NamedItem
{
	/// <summary>
	/// The Group Policy Id
	/// </summary>
	[ApiKey]
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "groupPolicyId")]
	public string? GroupPolicyId { get; set; }

	/// <summary>
	/// Gets or Sets Scheduling. The schedule for the group policy. Schedules are applied to days of the week.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "scheduling")]
	public Scheduling Scheduling { get; set; } = new();

	/// <summary>
	/// Gets or Sets Bandwidth
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "bandwidth")]
	public Bandwidth Bandwidth { get; set; } = new();

	/// <summary>
	/// Gets or Sets FirewallAndTrafficShaping
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "firewallAndTrafficShaping")]
	public FirewallAndTrafficShaping FirewallAndTrafficShaping { get; set; } = new();

	/// <summary>
	/// Gets or Sets ContentFiltering
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "contentFiltering")]
	public ContentFilteringResult ContentFiltering { get; set; } = new();

	/// <summary>
	/// Gets or Sets SplashAuthSettings
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "splashAuthSettings")]
	public SplashAuthSetting SplashAuthSettings { get; set; }

	/// <summary>
	/// Gets or Sets VlanTagging
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "vlanTagging")]
	public VlanTagging VlanTagging { get; set; } = new();

	/// <summary>
	/// Gets or Sets BonjourForwarding
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "bonjourForwarding")]
	public BonjourForwarding BonjourForwarding { get; set; } = new();
}
