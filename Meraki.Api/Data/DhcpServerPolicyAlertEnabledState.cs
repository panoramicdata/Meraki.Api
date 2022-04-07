namespace Meraki.Api.Data;

[DataContract]
public class DhcpServerPolicyAlertEnabledState
{
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "enabled")]
	public bool Enabled { get; set; }
}