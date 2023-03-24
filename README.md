# Meraki.Api

[![Nuget](https://img.shields.io/nuget/v/Meraki.Api)](https://www.nuget.org/packages/Meraki.Api/)
[![Nuget](https://img.shields.io/nuget/dt/Meraki.Api)](https://www.nuget.org/packages/Meraki.Api/)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)
[![Codacy Badge](https://app.codacy.com/project/badge/Grade/d52eda04578e471e90b8495c40bdcb9d)](https://www.codacy.com/gh/panoramicdata/Meraki.Api/dashboard?utm_source=github.com&amp;utm_medium=referral&amp;utm_content=panoramicdata/Meraki.Api&amp;utm_campaign=Badge_Grade)

This project implements access to the v1 Meraki API

See the [contribution guide](CONTRIBUTING.md) for more information regarding contributing to this project

To use the Meraki API nuget package:

## Visual Studio
1. Open your project in Visual Studio
1. Right-click on the project and click "Manage Nuget packages"
1. Find the package "Meraki.Api" - install the latest version

## Example code (C# 11)

``` C#
using Meraki.Api;
using System;
using System.Threading.Tasks;

namespace My.Project
{
	public static class Program
	{
		public static async Task Main()
		{
			using var merakiClient = new MerakiClient(new MerakiClientOptions
			{
				ApiKey = "0123456789abcdef0123456789abcdef01234567",
				UserAgent = "YourApplicationNameHere YourCompanyNameHere"
			});

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
}
```

## API Documentation

The Meraki API documentation can be found here:
- [Meraki API Documentation v1](https://developer.cisco.com/meraki/api-v1/)

## Testing

You can test this using a Meraki Sandbox here:
- [Meraki Always On](https://devnetsandbox.cisco.com/RM/Diagram/Index/a9487767-deef-4855-b3e3-880e7f39eadc?diagramType=Topology)
- [Meraki Enterprise](https://devnetsandbox.cisco.com/RM/Diagram/Index/e7b3932b-0d47-408e-946e-c23a0c031bda?diagramType=Topology)
- [Meraki Small Business](https://devnetsandbox.cisco.com/RM/Diagram/Index/aa48e6e2-3e59-4b87-bfe5-7833c45f8db8?diagramType=Topology)

After signing in, look in the lower left hand side of the page for your API key.
