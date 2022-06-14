namespace Meraki.Api.Data;

[DataContract]
public class StaticRouteGatewayOffset
{
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "enabled")]
	public bool? Enabled { get; set; }

	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "value")]
	public object? Value { get; set; }

	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "interfaceId")]
	public string? InterfaceId { get; set; }
}