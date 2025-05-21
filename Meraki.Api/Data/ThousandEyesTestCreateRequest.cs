namespace Meraki.Api.Data;

/// <summary>
/// ThousandEyes Network Test Create Request
/// </summary>
[DataContract]
public class ThousandEyesTestCreateRequest
{
	/// <summary>
	/// An array of tests to be created
	/// </summary>
	[DataMember(Name = "tests")]
	public List<ThousandEyesTest>? Tests { get; set; }
}
