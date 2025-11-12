namespace Meraki.Api.Data;

/// <summary>
/// Cloud Information
/// </summary>
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
