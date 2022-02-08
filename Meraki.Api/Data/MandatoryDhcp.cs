namespace Meraki.Api.Data;

[DataContract]
public class MandatoryDhcp
{
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "enabled")]
	public bool Enabled { get; set; }
}