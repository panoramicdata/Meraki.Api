namespace Meraki.Api.Data;

/// <summary>
/// Origin
/// </summary>
[DataContract]
public class DeviceAppliancePrefixesDelegatedItemOrigin
{
	/// <summary>
	/// Interface
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "interface")]
	public string Interface { get; set; } = string.Empty;
}