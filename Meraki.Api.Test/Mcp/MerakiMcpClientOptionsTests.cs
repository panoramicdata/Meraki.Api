using Meraki.Api.Exceptions;
using Meraki.Api.Mcp;

namespace Meraki.Api.Test.Mcp;

public class MerakiMcpClientOptionsTests
{
	private static MerakiMcpClientOptions Valid() => new() { ApiKey = "key" };

	[Fact]
	public void Defaults_AreHostedMerakiEndpoint()
	{
		var options = new MerakiMcpClientOptions();

		options.Transport.Should().Be(MerakiMcpTransport.HostedHttp);
		options.Uri.Should().Be("https://mcp.meraki.com/mcp");
		options.ApiRegion.Should().Be(ApiRegion.Default);
		options.EnforceReadOnlyCapabilityNames.Should().BeTrue();
		options.JsonMissingMemberHandling.Should().Be(JsonMissingMemberHandling.Ignore);
		options.Arguments.Should().BeEmpty();
		options.EnvironmentVariables.Should().BeEmpty();
	}

	[Fact]
	public void Validate_WithValidHostedOptions_DoesNotThrow()
	{
		var act = () => Valid().Validate();

		act.Should().NotThrow();
	}

	[Theory]
	[InlineData(null)]
	[InlineData("")]
	[InlineData("   ")]
	public void Validate_WithMissingApiKey_Throws(string? apiKey)
	{
		var options = new MerakiMcpClientOptions { ApiKey = apiKey! };

		var act = () => options.Validate();

		act.Should().Throw<ConfigurationException>().WithMessage("*ApiKey*");
	}

	[Fact]
	public void Validate_WithNonDefaultRegionAndHostedTransport_ThrowsNamingSelfHostingAsTheRemedy()
	{
		var options = Valid();
		options.ApiRegion = ApiRegion.Government;

		var act = () => options.Validate();

		act.Should().Throw<ConfigurationException>()
			.Which.Message.Should().Contain("LocalHttp").And.Contain("Stdio");
	}

	[Theory]
	[InlineData(ApiRegion.China)]
	[InlineData(ApiRegion.Canada)]
	[InlineData(ApiRegion.India)]
	[InlineData(ApiRegion.Government)]
	public void Validate_WithNonDefaultRegionAndLocalHttpTransport_DoesNotThrow(ApiRegion apiRegion)
	{
		var options = Valid();
		options.Transport = MerakiMcpTransport.LocalHttp;
		options.Uri = "http://localhost:8080/mcp";
		options.ApiRegion = apiRegion;

		var act = () => options.Validate();

		act.Should().NotThrow();
	}

	[Theory]
	[InlineData(null)]
	[InlineData("")]
	public void Validate_WithLocalHttpAndMissingUri_Throws(string? uri)
	{
		var options = Valid();
		options.Transport = MerakiMcpTransport.LocalHttp;
		options.Uri = uri!;

		var act = () => options.Validate();

		act.Should().Throw<ConfigurationException>().WithMessage("*Uri*");
	}

	[Fact]
	public void Validate_WithNonAbsoluteUri_Throws()
	{
		var options = Valid();
		options.Uri = "not-a-uri";

		var act = () => options.Validate();

		act.Should().Throw<ConfigurationException>().WithMessage("*not a valid absolute URI*");
	}

	[Fact]
	public void Validate_WithNonHttpScheme_Throws()
	{
		var options = Valid();
		options.Uri = "ftp://example.com/mcp";

		var act = () => options.Validate();

		act.Should().Throw<ConfigurationException>().WithMessage("*http or https*");
	}

	[Fact]
	public void Validate_WithStdioAndNoCommand_Throws()
	{
		var options = Valid();
		options.Transport = MerakiMcpTransport.Stdio;

		var act = () => options.Validate();

		act.Should().Throw<ConfigurationException>().WithMessage("*Command*");
	}

	[Fact]
	public void Validate_WithStdioAndCommand_DoesNotThrow()
	{
		var options = Valid();
		options.Transport = MerakiMcpTransport.Stdio;
		options.Command = "npx";
		options.Arguments.Add("cisco-meraki-mcp");

		var act = () => options.Validate();

		act.Should().NotThrow();
	}

	[Fact]
	public void Validate_WithUnknownTransport_Throws()
	{
		var options = Valid();
		options.Transport = (MerakiMcpTransport)99;

		var act = () => options.Validate();

		act.Should().Throw<ConfigurationException>().WithMessage("*not supported*");
	}

	[Theory]
	[InlineData(0)]
	[InlineData(-1)]
	public void Validate_WithNonPositiveTimeout_Throws(int seconds)
	{
		var options = Valid();
		options.HttpClientTimeoutSeconds = seconds;

		var act = () => options.Validate();

		act.Should().Throw<ConfigurationException>().WithMessage("*HttpClientTimeoutSeconds*");
	}

	[Fact]
	public void Validate_WithZeroMaxAttemptCount_Throws()
	{
		var options = Valid();
		options.MaxAttemptCount = 0;

		var act = () => options.Validate();

		act.Should().Throw<ConfigurationException>().WithMessage("*MaxAttemptCount*");
	}

	[Fact]
	public void Validate_WithNegativeMaxBackOff_Throws()
	{
		var options = Valid();
		options.MaxBackOffDelaySeconds = -1;

		var act = () => options.Validate();

		act.Should().Throw<ConfigurationException>().WithMessage("*MaxBackOffDelaySeconds*");
	}

	[Fact]
	public void Validate_WithBackOffFactorBelowOne_Throws()
	{
		var options = Valid();
		options.BackOffDelayFactor = 0.5;

		var act = () => options.Validate();

		act.Should().Throw<ConfigurationException>().WithMessage("*BackOffDelayFactor*");
	}
}
