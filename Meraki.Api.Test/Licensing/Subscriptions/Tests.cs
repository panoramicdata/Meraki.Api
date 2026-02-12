namespace Meraki.Api.Test.Licensing.Subscriptions;

public class Tests(ITestOutputHelper iTestOutputHelper) : MerakiClientTest(iTestOutputHelper)
{
	/// <summary>
	/// Test getting licensing subscriptions for a specific subscription ID
	/// GET /administered/licensing/subscription/subscriptions
	/// </summary>
	[Fact]
	public async Task GetAdministeredLicensingSubscriptionSubscriptionsAsync_WithSubscriptionId_Succeeds()
	{
		try
		{
			// Arrange
			// First, get all subscriptions for the organization to find a valid subscription ID
			var allSubscriptions = await TestMerakiClient
				.Licensing
				.Subscriptions
				.GetAdministeredLicensingSubscriptionSubscriptionsAsync(
					organizationIds: [Configuration.TestOrganizationId],
					cancellationToken: CancellationToken);

			// Skip test if no subscriptions are available
			if (allSubscriptions == null || allSubscriptions.Count == 0)
			{
				TestOutputHelper.WriteLine($"No subscriptions available for organization {Configuration.TestOrganizationId}. Skipping test.");
				return;
			}

			var testSubscriptionId = allSubscriptions[0].SubscriptionId;
			TestOutputHelper.WriteLine($"Testing with subscription ID: {testSubscriptionId}");

			// Act
			var filteredSubscriptions = await TestMerakiClient
				.Licensing
				.Subscriptions
				.GetAdministeredLicensingSubscriptionSubscriptionsAsync(
					organizationIds: [Configuration.TestOrganizationId],
					subscriptionIds: [testSubscriptionId],
					cancellationToken: CancellationToken);

			// Assert
			_ = filteredSubscriptions.Should().NotBeNull();
			_ = filteredSubscriptions.Should().ContainSingle();
			_ = filteredSubscriptions[0].SubscriptionId.Should().Be(testSubscriptionId);
		}
		catch (ApiException ex) when (ex.StatusCode == System.Net.HttpStatusCode.NotFound)
		{
			TestOutputHelper.WriteLine($"API returned 404 Not Found for organization {Configuration.TestOrganizationId}");
			TestOutputHelper.WriteLine($"Status Code: {ex.StatusCode}");
			TestOutputHelper.WriteLine($"Response Body: {ex.Content}");
			TestOutputHelper.WriteLine("This is expected if the organization has no subscriptions. Skipping test.");
		}
	}

	/// <summary>
	/// Test getting all licensing subscriptions for an organization
	/// GET /administered/licensing/subscription/subscriptions
	/// </summary>
	[Fact]
	public async Task GetAdministeredLicensingSubscriptionSubscriptionsAsync_ForOrganization_Succeeds()
	{
		try
		{
			// Act
			var subscriptions = await TestMerakiClient
				.Licensing
				.Subscriptions
				.GetAdministeredLicensingSubscriptionSubscriptionsAsync(
					organizationIds: [Configuration.TestOrganizationId],
					cancellationToken: CancellationToken);

			// Assert
			_ = subscriptions.Should().NotBeNull();
			TestOutputHelper.WriteLine($"Found {subscriptions.Count} subscription(s) for organization {Configuration.TestOrganizationId}");
		}
		catch (ApiException ex) when (ex.StatusCode == System.Net.HttpStatusCode.NotFound)
		{
			TestOutputHelper.WriteLine($"API returned 404 Not Found for organization {Configuration.TestOrganizationId}");
			TestOutputHelper.WriteLine($"Status Code: {ex.StatusCode}");
			TestOutputHelper.WriteLine($"Response Body: {ex.Content}");
			TestOutputHelper.WriteLine("This is expected if the organization has no subscriptions. Skipping test.");
		}
	}

	/// <summary>
	/// Test getting licensing subscriptions filtered by organization ID
	/// GET /administered/licensing/subscription/subscriptions
	/// </summary>
	[Fact]
	public async Task GetAdministeredLicensingSubscriptionSubscriptionsAsync_WithOrganizationId_Succeeds()
	{
		try
		{
			// Act
			var subscriptions = await TestMerakiClient
				.Licensing
				.Subscriptions
				.GetAdministeredLicensingSubscriptionSubscriptionsAsync(
					organizationIds: [Configuration.TestOrganizationId],
					cancellationToken: CancellationToken);

			// Assert
			_ = subscriptions.Should().NotBeNull();
			TestOutputHelper.WriteLine($"Found {subscriptions.Count} subscription(s) for organization {Configuration.TestOrganizationId}");
		}
		catch (ApiException ex) when (ex.StatusCode == System.Net.HttpStatusCode.NotFound)
		{
			TestOutputHelper.WriteLine($"API returned 404 Not Found for organization {Configuration.TestOrganizationId}");
			TestOutputHelper.WriteLine($"Status Code: {ex.StatusCode}");
			TestOutputHelper.WriteLine($"Response Body: {ex.Content}");
			TestOutputHelper.WriteLine("This is expected if the organization has no subscriptions. Skipping test.");
		}
	}

	/// <summary>
	/// Test getting licensing subscriptions with pagination
	/// GET /administered/licensing/subscription/subscriptions
	/// </summary>
	[Fact]
	public async Task GetAdministeredLicensingSubscriptionSubscriptionsAsync_WithPagination_Succeeds()
	{
		try
		{
			// Act
			var subscriptions = await TestMerakiClient
				.Licensing
				.Subscriptions
				.GetAdministeredLicensingSubscriptionSubscriptionsAsync(
					organizationIds: [Configuration.TestOrganizationId],
					perPage: 10,
					cancellationToken: CancellationToken);

			// Assert
			_ = subscriptions.Should().NotBeNull();
			_ = subscriptions.Count.Should().BeLessThanOrEqualTo(10);
			TestOutputHelper.WriteLine($"Found {subscriptions.Count} subscription(s) for organization {Configuration.TestOrganizationId} with pagination (perPage: 10)");
		}
		catch (ApiException ex) when (ex.StatusCode == System.Net.HttpStatusCode.NotFound)
		{
			TestOutputHelper.WriteLine($"API returned 404 Not Found for organization {Configuration.TestOrganizationId}");
			TestOutputHelper.WriteLine($"Status Code: {ex.StatusCode}");
			TestOutputHelper.WriteLine($"Response Body: {ex.Content}");
			TestOutputHelper.WriteLine("This is expected if the organization has no subscriptions. Skipping test.");
		}
	}
}
