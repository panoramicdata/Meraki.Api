namespace Meraki.Api.Data;

/// <summary>
/// sepioo IIoT settings for electronic shelf labels
/// </summary>
[DataContract]
public class ElectronicShelfLabelSettingsNetworkSepioo
{
	/// <summary>
	/// The sepioo hostname
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "hostname")]
	public string? Hostname { get; set; }
}
