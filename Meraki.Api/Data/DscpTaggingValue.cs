namespace Meraki.Api.Data;

/// <summary>
/// Dscp Tagging Value
/// </summary>
[DataContract]
public class DscpTaggingValue
{
	/// <summary>
	/// Gets the dscp tag value
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "dscpTagValue")]
	public int DscpTagValue { get; set; }

	/// <summary>
	/// Gets the description
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "description")]
	public string Description { get; set; } = string.Empty;
}
