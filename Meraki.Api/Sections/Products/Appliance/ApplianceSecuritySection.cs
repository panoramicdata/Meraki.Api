namespace Meraki.Api.Sections.Products.Appliance;

public class ApplianceSecuritySection
{
	public IApplianceSecurityIntrusion Intrusion { get; internal set; } = null!;
	public IApplianceSecurityMalware Malware { get; internal set; } = null!;
}
