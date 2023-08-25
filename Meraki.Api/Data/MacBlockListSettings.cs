namespace Meraki.Api.Data;

/// <summary>
/// MacBlockList on SwitchSettings
/// </summary>
[DataContract]
public class MacBlockListSettings
{
	/// <summary>
	/// Enabled - undocumented 2023-08-25
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "enabled")]
	public bool? Enabled { get; set; }
}