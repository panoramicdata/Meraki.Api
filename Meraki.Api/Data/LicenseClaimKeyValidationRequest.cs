namespace Meraki.Api.Data;

/// <summary>
/// A license claim key validation request
/// </summary>
[DataContract]
public class LicensingClaimKeyValidationRequest
{
	/// <summary>
	/// The subscription's claim key
	/// </summary>
	[DataMember(Name = "claimKey")]
	public string ClaimKey { get; set; } = string.Empty;
}
