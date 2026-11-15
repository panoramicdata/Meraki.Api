
namespace Meraki.Api;

public partial class MerakiClient
{
	private OrganizationBrandingPoliciesSection BuildOrganizationsBrandingPoliciesSection()
		=> new()
		{
			BrandingPolicies = RefitFor(Organizations.BrandingPolicies.BrandingPolicies),
			Priorities = RefitFor(Organizations.BrandingPolicies.Priorities)
		};

	private OrganizationsSamlSection BuildOrganizationsSamlSection()
		=> new()
		{
			Saml = RefitFor(Organizations.Saml.Saml),
			Idp = RefitFor(Organizations.Saml.Idp)
		};

	private OrganizationsSummarySection BuildOrganizationsSummarySection()
		=> new()
		{
			Top = RefitFor(Organizations.Summary.Top),
			SwitchPower = RefitFor(Organizations.Summary.SwitchPower)
		};

	private OrganizationsCameraSection BuildOrganizationsCameraSection()
		=> new()
		{
			Permissions = RefitFor(Organizations.Camera.Permissions),
			Detections = RefitFor(Organizations.Camera.Detections)
		};

	private OrganizationsCampusGateway BuildOrganizationsCampusGatewaySection()
		=> new()
		{
			Clusters = RefitFor(Organizations.CampusGateway.Clusters),
			Devices = BuildOrganizationsCampusGatewayDevicesSection()
		};

	private OrganizationsCertificatesSection BuildOrganizationsCertificatesSection()
		=> new()
		{
			Certificates = RefitFor(Organizations.Certificates.Certificates),
			RadSec = BuildOrganizationsCertificatesRadSecSection()
		};

	private OrganizationsCertificatesRadSecSection BuildOrganizationsCertificatesRadSecSection()
		=> new()
		{
			DeviceCertificateAuthorities = RefitFor(Organizations.Certificates.RadSec.DeviceCertificateAuthorities)
		};

	private OrganizationsCloudSection BuildOrganizationsCloudSection()
		=> new()
		{
			Connectivity = RefitFor(Organizations.Cloud.Connectivity)
		};

	private OrganizationsExtensionsSection BuildOrganizationsExtensionsSection()
		=> new()
		{
			SdwanManager = new()
			{
				Interconnects = RefitFor(Organizations.Extensions.SdwanManager.Interconnects)
			},
			ThousandEyes = RefitFor(Organizations.Extensions.ThousandEyes)
		};

	private OrganizationsInsightSection BuildOrganizationsInsightSection()
		=> new()
		{
			Insight = RefitFor(Organizations.Insight.Insight),
			Applications = RefitFor(Organizations.Insight.Applications),
			WebApps = RefitFor(Organizations.Insight.WebApps)
		};

	private OrganizationsIntegrationsSection BuildOrganizationsIntegrationsSection()
		=> new()
		{
			Xdr = RefitFor(Organizations.Integrations.Xdr)
		};
}
