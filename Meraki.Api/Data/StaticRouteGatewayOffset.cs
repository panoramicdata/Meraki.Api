namespace Meraki.Api.Data;

/// <summary>
/// Static Route Gateway Offset
/// </summary>
[DataContract]
public class StaticRouteGatewayOffset
{
	/// <summary>
	/// Whether enabled
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "enabled")]
	public bool? Enabled { get; set; }

	/// <summary>
	/// Gets the value
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "value")]
	public object? Value { get; set; }

	/// <summary>
	/// Gets the interface id
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "interfaceId")]
	public string? InterfaceId { get; set; }
}
