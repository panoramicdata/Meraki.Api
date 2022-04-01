namespace Meraki.Api.Data;

[DataContract]
public class DscpTaggingValue
{
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "dscpTagValue")]
	public int DscpTagValue { get; set; }

	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "description")]
	public string Description { get; set; } = string.Empty;
}
