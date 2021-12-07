namespace Meraki.Api.Data;

[DataContract]
public class MandatoryDhcp
{
	[DataMember(Name = "enabled")]
	public bool Enabled { get; set; }
}