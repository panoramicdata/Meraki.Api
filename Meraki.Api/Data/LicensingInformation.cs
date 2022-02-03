namespace Meraki.Api.Data;

/// <summary>
/// Licensing information
/// </summary>
[DataContract]
public class LicensingInformation
{
	/// <summary>
	/// Licensing model
	/// </summary>
	[DataMember(Name = "model")]
	public LicensingModel Model { get; set; }

}