namespace Meraki.Api.Data;

/// <summary>
/// Switch Port Module
/// </summary>
[DataContract]
public class SwitchPortModule
{
	/// <summary>
	/// Model
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "model")]
	public object? Model { get; set; }

	/// <summary>
	/// Slot
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "slot")]
	public object? Slot { get; set; }

	/// <summary>
	/// Serial
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "serial")]
	public object? Serial { get; set; }

	/// <summary>
	/// Active
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "active")]
	public object? Active { get; set; }
}
