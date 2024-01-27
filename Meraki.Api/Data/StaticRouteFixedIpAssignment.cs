namespace Meraki.Api.Data;

[DataContract]
public class StaticRouteFixedIpAssignment
{
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "ip")]
	public string? Ip { get; set; }

	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "name")]
	public string? Name { get; set; }
}