using Meraki.Api.Exceptions;

namespace Meraki.Api.Test;

/// <summary>
/// Tests for <see cref="MerakiClientOptions.Validate"/> and for the <see cref="MerakiClient"/>
/// constructor calling it
/// (<see href="https://github.com/panoramicdata/Meraki.Api/issues/377">issue 377</see>).
/// None of these need credentials or a network.
/// </summary>
public class MerakiClientOptionsTests
{
	private static MerakiClientOptions Valid() => new()
	{
		ApiKey = "0000000000000000000000000000000000000000",
		UserAgent = "Meraki.Api.Test/1.0"
	};

	[Fact]
	public void Validate_WithApiKeyAndDefaults_DoesNotThrow()
	{
		var act = () => Valid().Validate();

		_ = act.Should().NotThrow();
	}

	[Theory]
	[InlineData(0)]
	[InlineData(-1)]
	public void Validate_WithMaxAttemptCountBelowOne_Throws(int maxAttemptCount)
	{
		var options = Valid();
		options.MaxAttemptCount = maxAttemptCount;

		var act = () => options.Validate();

		_ = act.Should().Throw<ConfigurationException>().WithMessage($"*{nameof(MerakiClientOptions.MaxAttemptCount)}*");
	}

	[Theory]
	[InlineData(0)]
	[InlineData(-1)]
	public void Validate_WithHttpClientTimeoutSecondsNotPositive_Throws(int httpClientTimeoutSeconds)
	{
		var options = Valid();
		options.HttpClientTimeoutSeconds = httpClientTimeoutSeconds;

		var act = () => options.Validate();

		_ = act.Should().Throw<ConfigurationException>().WithMessage($"*{nameof(MerakiClientOptions.HttpClientTimeoutSeconds)}*");
	}

	[Fact]
	public void Constructor_WithNoCredentials_ThrowsConfigurationException()
	{
		var options = new MerakiClientOptions { UserAgent = "Meraki.Api.Test/1.0" };

		var act = () => new MerakiClient(options);

		_ = act.Should().Throw<ConfigurationException>();
	}

	[Fact]
	public void Constructor_WithBothApiKeyAndAccessToken_ThrowsConfigurationException()
	{
		var options = Valid();
		options.AccessToken = "oauth-token";

		var act = () => new MerakiClient(options);

		_ = act.Should().Throw<ConfigurationException>();
	}

	[Fact]
	public void Constructor_WithNegativeHttpClientInnerTimeoutSeconds_ThrowsConfigurationException()
	{
		var options = Valid();
		options.HttpClientInnerTimeoutSeconds = -1;

		var act = () => new MerakiClient(options);

		_ = act.Should().Throw<ConfigurationException>();
	}

	[Fact]
	public void Constructor_WithValidOptions_Succeeds()
	{
		using var client = new MerakiClient(Valid());

		_ = client.Should().NotBeNull();
	}
}
