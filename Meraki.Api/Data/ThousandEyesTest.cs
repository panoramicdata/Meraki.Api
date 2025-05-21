namespace Meraki.Api.Data;

/// <summary>
/// A test to be created
/// </summary>
[DataContract]
public class ThousandEyesTest
{
	/// <summary>
	/// Network
	/// </summary>
	[DataMember(Name = "network")]
	public ThousandEyesTestNetwork Network { get; set; } = new();

	/// <summary>
	/// Thousand Eye test template object, maximun size: 1000
	/// </summary>
	[DataMember(Name = "template")]
	public ThousandEyesTestTemplate Template { get; set; } = new();
}
