namespace Meraki.Api.Data;

/// <summary>
/// SubnetNat - Undocumented
/// </summary>
[DataContract]
public class SubnetNat
{
	/// <summary>
	/// Undocumented
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "enabled")]
	public bool? Enabled { get; set; }
}
