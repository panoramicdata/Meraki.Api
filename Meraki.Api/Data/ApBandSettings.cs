namespace Meraki.Api.Data;

/// <summary>
/// Settings that will be enabled if selectionType is set to &#39;ap&#39;.
/// </summary>
[DataContract]
public class ApBandSettings
{
	/// <summary>
	/// Gets or Sets BandOperationMode
	/// </summary>
	[DataMember(Name = "bandOperationMode")]
	public BandOperationMode BandOperationMode { get; set; }
	/// <summary>
	/// Steers client to most open band. Can be either true or false. Defaults to true.
	/// </summary>
	/// <value>Steers client to most open band. Can be either true or false. Defaults to true.</value>
	[DataMember(Name = "bandSteeringEnabled")]
	public bool? BandSteeringEnabled { get; set; }
}
