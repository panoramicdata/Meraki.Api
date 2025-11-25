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
			var networkCount = optIn.LimitScopeToNetworks?.Count;
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
		// First, get existing webhook servers
		var httpServers = await TestMerakiClient
			.Organizations
			.Webhooks
			.HttpServers
			.GetOrganizationWebhooksHttpServersAsync(
				Configuration.TestOrganizationId,
				cancellationToken: CancellationToken);

		if (httpServers == null || httpServers.Count == 0)
		{
			// Skip test if no webhook servers configured
			return;
		}

		var testServerId = httpServers[0].Id!;
		var testIname = $"test_receiver_{Guid.NewGuid():N}";

		try
		{
			// 1. Create a receiver profile
			var createRequest = new PushReceiverProfile
			{
				Iname = testIname,
				Name = "Test Receiver Profile",
				Description = "Test receiver profile for integration testing",
				Receiver = new PushReceiver
				{
					Id = testServerId
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
			_ = createdProfile.Iname.Should().Be(testIname);
			_ = createdProfile.Name.Should().Be("Test Receiver Profile");

			// 2. List receiver profiles
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
			_ = profilesResponse.Items.Should().Contain(p => p.Iname == testIname);
		}
		finally
		{
			// 3. Delete the receiver profile
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
						testIname,
						cancellationToken: CancellationToken);
			}
			catch
			{
				// Ignore cleanup errors
			}
		}
	}

	[Fact]
	public async Task PushProfile_Lifecycle_Succeeds()
	{
		// This test requires both webhook servers and receiver profiles to be configured
		// First, ensure we have a receiver profile
		var httpServers = await TestMerakiClient
			.Organizations
			.Webhooks
			.HttpServers
			.GetOrganizationWebhooksHttpServersAsync(
				Configuration.TestOrganizationId,
				cancellationToken: CancellationToken);

		if (httpServers == null || httpServers.Count == 0)
		{
			// Skip test if no webhook servers configured
			return;
		}

		var testServerId = httpServers[0].Id!;
		var receiverIname = $"test_receiver_{Guid.NewGuid():N}";
		var profileIname = $"test_profile_{Guid.NewGuid():N}";

		try
		{
			// 1. Create a receiver profile first
			var receiverProfile = new PushReceiverProfile
			{
				Iname = receiverIname,
				Name = "Test Receiver for Profile",
				Description = "Temporary receiver for push profile testing",
				Receiver = new PushReceiver
				{
					Id = testServerId
				}
			};

			_ = await TestMerakiClient
				.Organizations
				.Api
				.Push
				.Receivers
				.Profiles
				.CreateOrganizationApiPushReceiversProfileAsync(
					Configuration.TestOrganizationId,
					receiverProfile,
					cancellationToken: CancellationToken);

			// 2. Create a push profile
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

			// 3. Update the push profile
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
		finally
		{
			// 4. Clean up - delete push profile
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
			catch
			{
				// Ignore cleanup errors
			}

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
			catch
			{
				// Ignore cleanup errors
			}
		}
	}
}
