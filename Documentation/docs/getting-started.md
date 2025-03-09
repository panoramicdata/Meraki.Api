# Getting started

To get started, you will need to install the Meraki.Api nuget package.
You can find the package on [Nuget](https://www.nuget.org/packages/Meraki.Api/).

Then, you will be able to write code like this:

``` C#
using Meraki.Api;
using System;
using System.Threading.Tasks;

namespace My.Project;
public static class Program
{
	public static async Task Main()
	{
		using var merakiClient = new MerakiClient(
			new MerakiClientOptions
			{
				ApiKey = "0123456789abcdef0123456789abcdef01234567",
				UserAgent = "YourProductName/YourProductVersion YourCompanyName"
			}
		);

		var organizations = await merakiClient
			.Organizations
			.GetOrganizationsAsync()
			.ConfigureAwait(false);

		var firstOrganization = organizations[0];

		var devices = await merakiClient
			.Organizations
			.Devices
			.GetOrganizationDevicesAsync(firstOrganization.Id)
			.ConfigureAwait(false);

		Console.WriteLine("Devices:");
		foreach (var device in devices)
		{
			Console.WriteLine($"    - {device.Serial}: {device.Name}");
		}
	}
}
```