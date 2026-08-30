using System.Globalization;

namespace Meraki.Api.Test.PushApi;

public class PushApiTests(ITestOutputHelper testOutputHelper) : MerakiClientTest(testOutputHelper)
{
	[Fact]
	public async Task VerifyPushApiEarlyAccessEnabled_Succeeds()
	{
		// This test verifies that the organization has early access features enabled
		// For the purposes of this project, a pass is when ALL early access is enabled
		var optIns = await TestMerakiClient
			.Organizations
			.EarlyAccess
			.Features
			.GetOrganizationEarlyAccessFeaturesOptInsAsync(
				Configuration.TestOrganizationId,
				cancellation: CancellationToken);

		// Assert that early access features are enabled
		_ = optIns.Should().NotBeNull("Early access opt-ins should be available");
		_ = optIns.Should().NotBeEmpty("Organization must have at least one early access feature enabled");

		// Log all enabled early access features for visibility
		foreach (var optIn in optIns.OrderBy(o => o.ShortName))
		{
			TestOutputHelper.WriteLine($"{optIn.ShortName} (ID: {optIn.Id}) since {optIn.CreatedAt}");
		}

		// There should be one with the text "push" in the short name
		var shortNames = optIns.Select(o => o.ShortName!.ToLower(CultureInfo.InvariantCulture)).ToList();
		_ = shortNames.Should().Contain(sn => sn.Contains("push"), "Push API early access must be enabled for this test");
	}

	[Fact]
	public async Task GetOrganizationApiPushTopics_Succeeds()
	{
		// Try to get Push API topics
		var result = await TestMerakiClient
			.Organizations
			.Api
			.Push
			.Topics
			.GetOrganizationApiPushTopicsAsync(
				Configuration.TestOrganizationId,
				cancellationToken: CancellationToken);

		_ = result.Should().NotBeNull();
		_ = result.Should().NotBeEmpty();

		// Verify expected topics exist
		var topicIds = result.Select(t => t.Id).ToList();
		_ = topicIds.Should().Contain("organizationDevicesAvailabilitiesChangeHistory");
		_ = topicIds.Should().Contain("organizationConfigurationChanges");
	}

	[Fact]
	public async Task PushReceiverProfile_Lifecycle_Succeeds()
	{
		// This test requires webhook servers to be configured
		var testServerId = await TryGetWebhookServerIdAsync();
		if (testServerId is null)
		{
			// Skip test if no webhook servers configured
			return;
		}

		var testIname = $"test_receiver_{Guid.NewGuid():N}";

		try
		{
			await CreateReceiverProfileAsync(testIname, "Test Receiver Profile", "Test receiver profile for integration testing", testServerId);
			await AssertReceiverProfileIsListedAsync(testIname);
		}
		finally
		{
			await TryDeleteReceiverProfileAsync(testIname);
		}
	}

	/// <summary>
	/// The push tests need a webhook server to point a receiver at. Returns null where the test
	/// organization has none, in which case the caller skips.
	/// </summary>
	private async Task<string?> TryGetWebhookServerIdAsync()
	{
		var httpServers = await TestMerakiClient
			.Organizations
			.Webhooks
			.HttpServers
			.GetOrganizationWebhooksHttpServersAsync(
				Configuration.TestOrganizationId,
				cancellationToken: CancellationToken);

		return httpServers is null || httpServers.Count == 0
			? null
			: httpServers[0].Id!;
	}

	private async Task<PushReceiverProfile> CreateReceiverProfileAsync(
		string iname,
		string name,
		string description,
		string webhookServerId)
	{
		var createRequest = new PushReceiverProfile
		{
			Iname = iname,
			Name = name,
			Description = description,
			Receiver = new PushReceiver
			{
				Id = webhookServerId
			}
		};

		var createdProfile = await TestMerakiClient
			.Organizations
			.Api
			.Push
			.Receivers
			.Profiles
			.CreateOrganizationApiPushReceiversProfileAsync(
				Configuration.TestOrganizationId,
				createRequest,
				cancellationToken: CancellationToken);

		_ = createdProfile.Should().NotBeNull();
		_ = createdProfile.Iname.Should().Be(iname);
		_ = createdProfile.Name.Should().Be(name);

		return createdProfile;
	}

	private async Task AssertReceiverProfileIsListedAsync(string iname)
	{
		var profilesResponse = await TestMerakiClient
			.Organizations
			.Api
			.Push
			.Receivers
			.Profiles
			.GetOrganizationApiPushReceiversProfilesAsync(
				Configuration.TestOrganizationId,
				cancellationToken: CancellationToken);

		_ = profilesResponse.Should().NotBeNull();
		_ = profilesResponse.Items.Should().NotBeNull();
		_ = profilesResponse.Items.Should().Contain(p => p.Iname == iname);
	}

	/// <summary>
	/// Cleanup must not mask the failure that brought us here, so errors are swallowed.
	/// </summary>
	private async Task TryDeleteReceiverProfileAsync(string iname)
	{
		try
		{
			await TestMerakiClient
				.Organizations
				.Api
				.Push
				.Receivers
				.Profiles
				.DeleteOrganizationApiPushReceiversProfileAsync(
					Configuration.TestOrganizationId,
					iname,
					cancellationToken: CancellationToken);
		}
		catch (Exception ex)
		{
			TestOutputHelper.WriteLine($"Ignoring cleanup failure for receiver profile {iname}: {ex.Message}");
		}
	}

	[Fact]
	public async Task PushProfile_Lifecycle_Succeeds()
	{
		// This test requires both webhook servers and receiver profiles to be configured
		var testServerId = await TryGetWebhookServerIdAsync();
		if (testServerId is null)
		{
			// Skip test if no webhook servers configured
			return;
		}

		var receiverIname = $"test_receiver_{Guid.NewGuid():N}";
		var profileIname = $"test_profile_{Guid.NewGuid():N}";

		try
		{
			// A push profile needs a receiver to deliver to
			_ = await CreateReceiverProfileAsync(
				receiverIname,
				"Test Receiver for Profile",
				"Temporary receiver for push profile testing",
				testServerId);

			await CreatePushProfileAsync(profileIname, receiverIname);
			await UpdateAndVerifyPushProfileAsync(profileIname);
		}
		finally
		{
			await TryDeletePushProfileAsync(profileIname);

			// 5. Clean up - delete receiver profile
			try
			{
				await TestMerakiClient
					.Organizations
					.Api
					.Push
					.Receivers
					.Profiles
					.DeleteOrganizationApiPushReceiversProfileAsync(
						Configuration.TestOrganizationId,
						receiverIname,
						cancellationToken: CancellationToken);
			}
			catch (Exception ex)
			{
				TestOutputHelper.WriteLine($"Ignoring cleanup failure for receiver profile {receiverIname}: {ex.Message}");
			}
		}
	}

	private async Task CreatePushProfileAsync(string profileIname, string receiverIname)
	{
		var createRequest = new PushProfile
		{
			Iname = profileIname,
			Name = "Test Push Profile",
			Description = "Test push profile for integration testing",
			Topic = new PushTopicReference
			{
				Id = "organizationConfigurationChanges"
			},
			Receiver = new PushReceiver
			{
				Iname = receiverIname
			}
		};

		var createdProfile = await TestMerakiClient
			.Organizations
			.Api
			.Push
			.Profiles
			.CreateOrganizationApiPushProfileAsync(
				Configuration.TestOrganizationId,
				createRequest,
				cancellationToken: CancellationToken);

		_ = createdProfile.Should().NotBeNull();
		_ = createdProfile.Iname.Should().Be(profileIname);
		_ = createdProfile.Description.Should().Be("Test push profile for integration testing");
	}

	private async Task UpdateAndVerifyPushProfileAsync(string profileIname)
	{
		var updateRequest = new PushProfileUpdateRequest
		{
			Description = "Updated description for testing"
		};

		var updatedProfile = await TestMerakiClient
			.Organizations
			.Api
			.Push
			.Profiles
			.UpdateOrganizationApiPushProfileAsync(
				Configuration.TestOrganizationId,
				profileIname,
				updateRequest,
				cancellationToken: CancellationToken);

		_ = updatedProfile.Should().NotBeNull();
		_ = updatedProfile.Description.Should().Be("Updated description for testing");
	}

	/// <inheritdoc cref="TryDeleteReceiverProfileAsync" />
	private async Task TryDeletePushProfileAsync(string profileIname)
	{
		try
		{
			await TestMerakiClient
				.Organizations
				.Api
				.Push
				.Profiles
				.DeleteOrganizationApiPushProfileAsync(
					Configuration.TestOrganizationId,
					profileIname,
					cancellationToken: CancellationToken);
		}
		catch (Exception ex)
		{
			TestOutputHelper.WriteLine($"Ignoring cleanup failure for push profile {profileIname}: {ex.Message}");
		}
	}
}
