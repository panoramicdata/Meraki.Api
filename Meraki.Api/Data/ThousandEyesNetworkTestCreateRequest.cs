namespace Meraki.Api.Data;

/// <summary>
/// ThousandEyes Network Test Create Request
/// </summary>
[DataContract]
public class ThousandEyesNetworkTestCreateRequest
{
	/// <summary>
	/// An array of tests to be created
	/// </summary>
	[DataMember(Name = "tests")]
	public List<ThousandEyesNetworkTest>? Tests { get; set; }
}
