namespace Meraki.Api.Data;

/// <summary>
/// Hub
/// </summary>
[DataContract]
public class Hub
{
	/// <summary>
	/// The network ID of the hub.
	/// </summary>
	[ApiForeignKey(typeof(Network))]
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "hubId")]
	public string HubId { get; set; } = string.Empty;

	/// <summary>
	/// Only valid in 'spoke' mode. Indicates whether default route traffic should be sent to this hub.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "useDefaultRoute")]
	public bool? UseDefaultRoute { get; set; }
}
