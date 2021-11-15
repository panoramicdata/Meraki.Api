using System.Runtime.Serialization;

namespace Meraki.Api.Data;

[DataContract]
public class DscpTaggingValues
{
	[DataMember(Name = "dscpTagValue")]
	public int DscpTagValue { get; set; }

	[DataMember(Name = "description")]
	public string Description { get; set; } = string.Empty;
}
