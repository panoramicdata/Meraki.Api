# User-Agent string

It is important to set a User-Agent string in your HTTP requests.
This is a string that identifies the client making the request.
It is used by the Meraki servers to identify the type of client making the request.

For Meraki's full guidance, see [here](https://developer.cisco.com/meraki/api-v1/user-agents-overview/#user-agents).

To use this in the Meraki.Api library, you can set the UserAgent property on the MerakiClient object:
```csharp
using var client = new MerakiClient(
	new MerakiClientOptions
	{
		UserAgent = "ApplicationName/1.0 VendorName"
	}
);
```