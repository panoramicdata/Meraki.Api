namespace Meraki.Api.Data;

/// <summary>
/// The device provisioning status. Possible statuses: unprovisioned, incomplete, complete.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum DeviceProvisioningStatusStatus
{
	/// <summary>
	/// Unprovisioned
	/// </summary>
	[EnumMember(Value = "unprovisioned")]
	Unprovisioned,

	/// <summary>
	/// Incomplete
	/// </summary>
	[EnumMember(Value = "incomplete")]
	Incomplete,

	/// <summary>
	/// Complete
	/// </summary>
	[EnumMember(Value = "complete")]
	Complete
}
