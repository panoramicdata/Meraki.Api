namespace Meraki.Api.Data;

[DataContract]
public class CloudInformation
{
	/// <summary>
	/// The region
	/// </summary>
	[DataMember(Name = "region")]
	public Region Region { get; set; } = new();
}