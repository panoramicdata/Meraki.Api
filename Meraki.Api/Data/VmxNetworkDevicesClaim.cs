namespace Meraki.Api.Data;

[DataContract]
public class VmxNetworkDevicesClaim
{
	/// <summary>
	/// Size of VMX
	/// </summary>
	[DataMember(Name = "size")]
	[ApiAccess(ApiAccess.Create)]
	public string Size { get; set; } = string.Empty;
}
