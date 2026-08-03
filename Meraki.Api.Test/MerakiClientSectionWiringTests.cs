namespace Meraki.Api.Test;

/// <summary>
/// Unit tests confirming that the organization-level Refit clients reported in
/// <see href="https://github.com/panoramicdata/Meraki.Api/issues/337">issue 337</see>
/// are assigned by the <see cref="MerakiClient"/> constructor. These require no network
/// and no API key, because the wiring happens entirely in the constructor.
/// </summary>
public class MerakiClientSectionWiringTests
{
	private static MerakiClient CreateClient()
		=> new(new MerakiClientOptions
		{
			ApiKey = "0000000000000000000000000000000000000000",
			UserAgent = "Meraki.Api.Test/1.0"
		});

	[Fact]
	public void Constructor_SetsOrganizationsSummarySwitchPower()
	{
		using var merakiClient = CreateClient();

		_ = merakiClient.Organizations.Summary.SwitchPower.Should().NotBeNull();
	}

	[Fact]
	public void Constructor_SetsOrganizationsApplianceUplinksUsage()
	{
		using var merakiClient = CreateClient();

		_ = merakiClient.Organizations.Appliance.Uplinks.Usage.Should().NotBeNull();
	}

	[Fact]
	public void Constructor_SetsOrganizationsWirelessDevicesLatency()
	{
		using var merakiClient = CreateClient();

		_ = merakiClient.Organizations.Wireless.Devices.Latency.Should().NotBeNull();
	}

	[Fact]
	public void Constructor_SetsOrganizationsWirelessDevicesPacketLoss()
	{
		using var merakiClient = CreateClient();

		_ = merakiClient.Organizations.Wireless.Devices.PacketLoss.Should().NotBeNull();
	}

	/// <summary>
	/// This one additionally proves the Refit route/parameter fix: before it, building the
	/// interface threw ArgumentException because the route placeholder was {organizationId}
	/// but the method parameter was spelled "orgnanizationId".
	/// </summary>
	[Fact]
	public void Constructor_SetsOrganizationsWirelessDevicesChannelUtilization()
	{
		using var merakiClient = CreateClient();

		_ = merakiClient.Organizations.Wireless.Devices.ChannelUtilization.Should().NotBeNull();
	}

	/// <summary>
	/// The sections that were previously wired must keep working.
	/// </summary>
	[Fact]
	public void Constructor_StillSetsPreviouslyWiredOrganizationClients()
	{
		using var merakiClient = CreateClient();

		_ = merakiClient.Organizations.Summary.Top.Should().NotBeNull();
		_ = merakiClient.Organizations.SwitchPortsOverview.Should().NotBeNull();
		_ = merakiClient.Organizations.Uplinks.Should().NotBeNull();
	}
}
