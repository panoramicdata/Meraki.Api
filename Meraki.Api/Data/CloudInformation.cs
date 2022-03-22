namespace Meraki.Api.Data;

[DataContract]
public class CloudInformation
{
	/// <summary>
	/// The region
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "region")]
	public Region Region { get; set; } = new();
}