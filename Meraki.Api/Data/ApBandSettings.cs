namespace Meraki.Api.Data;

/// <summary>
/// Settings that will be enabled if selectionType is set to 'ap'.
/// </summary>
[DataContract]
public class ApBandSettings
{
	/// <summary>
	/// Gets or Sets BandOperationMode
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "bandOperationMode")]
	public BandOperationMode BandOperationMode { get; set; }

	/// <summary>
	/// Steers client to most open band. Can be either true or false. Defaults to true.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "bandSteeringEnabled")]
	public bool BandSteeringEnabled { get; set; }
}
