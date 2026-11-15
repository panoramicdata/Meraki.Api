
namespace Meraki.Api;

// Codacy analyses each file on its own, so it reports 'partial' as gratuitous (S2333) and the static-only parts as S1118. The other parts live in sibling files.
#pragma warning disable S2333, S1118
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
