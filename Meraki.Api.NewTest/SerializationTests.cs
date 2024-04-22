using FluentAssertions;
using Meraki.Api.Data;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Meraki.Api.NewTest;
public class SerializationTests
{
	[Fact]
	public void ValidJson_Works()
	{
		var settings = new JsonSerializerSettings
		{
			// By default nulls should not be rendered out, this will allow the receiving API to apply any defaults.
			// Use [JsonProperty(NullValueHandling = NullValueHandling.Include)] to send
			// nulls for specific properties, e.g. disassociating port schedule ids from a port
			NullValueHandling = NullValueHandling.Ignore,
			MissingMemberHandling = MissingMemberHandling.Ignore,
			Converters = [new StringEnumConverter()]
		};

		settings.Error = (object? sender, Newtonsoft.Json.Serialization.ErrorEventArgs args) =>
		{
			//errors.Add(args.ErrorContext.Error.Message);
			if (args.ErrorContext.Error is JsonSerializationException jse
			&& jse.InnerException is ArgumentException ae
			&& ae.Message.StartsWith("Requested value", StringComparison.Ordinal)
			&& ae.Message.EndsWith("was not found.", StringComparison.Ordinal))
			{
				// This was specifically a problem with a missing enum value
				//_output.WriteLine(jse.Message);
				args.ErrorContext.Handled = true;
			}
		};

		// Create some multiline json for testing
		var json = """
{
  "alertDestinations": {
    "allAdmins": false,
    "emails": [],
    "httpServerIds": [],
    "snmp": false
  },
  "enabled": false,
  "filters": {},
  "type": "settingsChanged"
}
""";

		var result = JsonConvert.DeserializeObject<Alert>(json, settings);
		_ = result.Should().NotBeNull();
		_ = result!.AlertDestinations.Should().NotBeNull();
		_ = result.AlertDestinations.AllAdmins.Should().BeFalse();
		_ = result.AlertDestinations.Emails.Should().NotBeNull();
		_ = result.AlertDestinations.Emails.Should().BeEmpty();
		_ = result.AlertDestinations.HttpServerIds.Should().NotBeNull();
		_ = result.AlertDestinations.HttpServerIds.Should().BeEmpty();
		_ = result.AlertDestinations.Snmp.Should().BeFalse();
		_ = result.Enabled.Should().BeFalse();
		_ = result.Filters.Should().NotBeNull();
		_ = result.Type.Should().Be(AlertType.SettingsChanged);

		var badJson = """
{
  "alertDestinations": {
    "allAdmins": false,
    "emails": [],
    "httpServerIds": [],
    "snmp": false
  },
  "enabled": false,
  "filters": {},
  "type": "hamster"
}
""";

		result = JsonConvert.DeserializeObject<Alert>(badJson, settings);
		_ = result.Should().NotBeNull();
		_ = result!.AlertDestinations.Should().NotBeNull();
		_ = result.AlertDestinations.AllAdmins.Should().BeFalse();
		_ = result.AlertDestinations.Emails.Should().NotBeNull();
		_ = result.AlertDestinations.Emails.Should().BeEmpty();
		_ = result.AlertDestinations.HttpServerIds.Should().NotBeNull();
		_ = result.AlertDestinations.HttpServerIds.Should().BeEmpty();
		_ = result.AlertDestinations.Snmp.Should().BeFalse();
		_ = result.Enabled.Should().BeFalse();
		_ = result.Filters.Should().NotBeNull();
		_ = result.Type.Should().Be(0);

		// The problem here is that the value is now 0, so although we solved the deserialization issue, the serialization will now fail
		var json2 = JsonConvert.SerializeObject(result, settings);
	}
}
