namespace Meraki.Api.Data;

[ApiAccessReadOnlyClass]
[DataContract]
public class CloudInformation
{
	/// <summary>
	/// The region
	/// </summary>
	[DataMember(Name = "region")]
	public Region Region { get; set; } = new();
}