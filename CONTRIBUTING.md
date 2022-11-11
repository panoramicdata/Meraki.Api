# Contributing to the Meraki API project

First of all, thanks for helping!

The "main" branch is used for generating builds that are released and all contributions should be
provided on branches with a pull request into "main".

For example, if you want to fix an enum that has new entries, you could create appropriate hotfix 
branch "hotfix/network-enum-updates" 
or feature "feature/adding-new-endpoints" 
with the changes on and then create a pull request 
to "main" with the changes.

We make regular updates to keep in sync with new releases and try to get round to 
requests as soon as we can, resourcing allowing.

## Endpoint paging

Some endpoints are pageable and are identified by having `perPage`, `startingAfter`, `endingBefore`.

These endpoints should be given a "GetAll" interface method to allow automatic
paging through the data without having to manually page.

For an example see `/organizations/{organizationId}/inventory/devices` in 
`Interfaces/General/Organizations/IOrganizationInventoryDevices.cs`

For this endpoint we would

1.  Create the normal endpoint as per the API documentation called `GetOrganizationInventoryDevicesAsync`.
```c#
[Get("/organizations/{organizationId}/inventory/devices")]
Task<List<InventoryDevice>> GetOrganizationInventoryDevicesAsync(
	string organizationId,
	int? perPage = 1000,
	string? startingAfter = null,
	string? endingBefore = null,
	string? usedState = null,
	string? search = null,
	CancellationToken cancellationToken = default);
```
2.  Create a second copy of the endpoint called `GetInventoryDevicesApiResponseAsync` and marked `internal`.
Exclude the paging parameters `perPage` and `endingBefore` and just leave the filtering parameters.
```c#
[Get("/organizations/{organizationId}/inventory/devices")]
internal Task<ApiResponse<List<InventoryDevice>>> GetOrganizationInventoryDevicesApiResponseAsync(
	string organizationId,
	string? startingAfter = null,
	string? usedState = null,
	string? search = null,
	CancellationToken cancellationToken = default);
```
3.  Change the second copy return type to wrap it in a Refit `ApiResponse`.
4.  This second copy will be used by an extension method that uses the `ApiReponse` to get the response headers and handle paging.
5.  Create an extension method, adding `All` to the method name, in an appropriately named file in `Extensions`; in this case `IOrganizationsInventoryDevicesExtensions.cs`
```c#
namespace Meraki.Api.Extensions;

public static class IOrganizationsInventoryDevicesExtensions
{
	/// <summary>
	/// Get all networks that the user has privileges on in an organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="usedState">Filter results by used or unused inventory. Accepted values are "used" or "unused".</param>
	/// <param name="search">Search for devices in inventory based on serial number, mac address, or model.</param>
	public static Task<List<InventoryDevice>> GetOrganizationInventoryDevicesAllAsync(
		this IOrganizationsInventoryDevices organizationInventoryDevices,
		string organizationId,
		string? usedState = null,
		string? search = null,
		CancellationToken cancellationToken = default)
		=> MerakiClient.GetAllAsync(
			(startingAfter, cancellationToken)
			=> organizationInventoryDevices.GetOrganizationInventoryDevicesApiResponseAsync(
				organizationId,
				startingAfter,
				usedState,
				search,
				cancellationToken
			),
			cancellationToken
		);
}
```
6.  This will allow people to call this method from the `IOrganizationsInventoryDevices` interface and 
7.  it will appear to be on the interface directly.

## ENUMS

Where possible, assuming all known values are available, create enums for well defined lists of options.

See `ProductType.cs` for an example

To correctly serialize, use the following class attributes
```c#
[DataContract]
[JsonConverter(typeof(StringEnumConverter))]
```

Each enum entry should be decorated with an `EnumMember` attribute e.g.

```c#
[EnumMember(Value = "cellularGateway")]
CellularGateway,
```

The first entry should be set to a value of 1 so that deserialization of unknown values 
will result in defaulting to 0 which has no valid value in the enum.

## API Attributes
To assist with understanding at runtime, all models which are used as a response body should be decorated to indicate
which returned properties can be used as part of create/update/delete requests.

### Property attributes
API attributes should be added to indicate their usage.

- `[ApiKey]` - Used to identify the primary key for the API resource.
- `[ApiForeignKey(typeof(xxx))`] - Used to identify another resource linked to by this Id, this can be useful to store for later use.
- `[ApiAccess(ApiAccess.Read)]` - Used to indicate that the returned property value is informational only and cannot be used as part of a Create or Update request.
- `[ApiAccess(ApiAccess.Create)]` - Used to indicate that the property can only be used as part of a Create request.
- `[ApiAccess(ApiAccess.ReadCreate)]` - Used to indicate that the property is returned and can only be used as part of a Create request.
- `[ApiAccess(ApiAccess.Update)]` - Used to indicate that the property can only be used as part of an Update request.
- `[ApiAccess(ApiAccess.ReadUpdate)]` - Used to indicate that the property is returned and can only be used as part of a Update request.
- `[ApiAccess(ApiAccess.CreateUpdate)]` - Used to indicate that the property can only be used as part of a Create or Update request.
- `[ApiAccess(ApiAccess.ReadWrite)]` - Used to indicate that the returned property value can be used as part of a Create or Update request.


### Class attributes
- `[ApiAccessReadOnlyClass]` - This can be set at the class level to indicate that all properties are read only. Useful for
Monitor endpoints.