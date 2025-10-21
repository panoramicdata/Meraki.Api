# GitHub Copilot Instructions for Meraki.Api

## Project Overview

This is the **Meraki.Api** - a .NET client library for the Cisco Meraki Dashboard API. The library provides a strongly-typed C# interface to interact with Meraki cloud-managed network infrastructure.

### Key Technologies
- **Target Frameworks**: .NET 9, .NET Standard 2.0
- **HTTP Client**: Refit (declarative REST library)
- **Serialization**: Newtonsoft.Json
- **Testing**: xUnit
- **Code Generation**: Source generators for Refit interfaces

## Project Structure

### Core Projects
- **Meraki.Api**: Main client library (multi-targeted: .NET Standard 2.0, .NET 9)
- **Meraki.Api.Test**: xUnit tests
- **Meraki.Api.NewTest**: Additional test suite
- **RefitClassSourceGenerator**: Source generator for Refit interfaces
- **Meraki.ApiChecker**: API validation and checking tool
- **Benchmarks**: Performance benchmarks

## Coding Standards & Conventions

### General Guidelines

1. **Follow existing patterns**: This is a mature, established codebase. Study existing code before adding new features.

2. **Multi-targeting**: Remember the library targets both .NET Standard 2.0. Avoid using APIs not available in .NET Standard 2.0.

3. **Nullable reference types**: The project uses nullable reference types. Be explicit about nullability.

4. **XML Documentation**: All public APIs must have XML documentation comments (summary, param, returns).

### Naming Conventions

#### Model Classes
- Follow Meraki API naming exactly: `OrganizationWirelessMqttSettings`, `SwitchPort`, `AccessPolicy`
- Nested models follow hierarchy: `ParentModelChildProperty` (e.g., `SwitchSettingsUplinkSelection`)
- Use `Request` suffix for request models: `SsidUpdateRequest`, `AccessPolicyCreateRequest`
- Use `Response` suffix when needed to distinguish from request models

#### Interfaces
- Refit interfaces start with `I` and describe the resource: `IOrganizationsWirelessMqtt`, `INetworksClients`
- Section classes match the resource hierarchy: `OrganizationsWirelessSection`, `NetworksAlertsSection`

#### Properties
- Use PascalCase for properties (following C# conventions)
- Use `[DataMember(Name = "propertyName")]` for JSON serialization mapping
- Use `[ApiAccess(ApiAccess.xxx)]` to denote whether the property is can be read, written only on create, updated, or both
- Mark nullable properties with `?` for value types and reference types

### Code Organization

#### Data Models (`Meraki.Api/Data/`)
```csharp
[DataContract]
public class ModelName
{
    /// <summary>
    /// Description of the property
    /// </summary>
    [DataMember(Name = "propertyName")]
    [ApiAccess(ApiAccess.xxx)]
    public string? PropertyName { get; set; }
}
```

#### Refit Interfaces (`Meraki.Api/Interfaces/`)
```csharp
/// <summary>
/// Interface description
/// </summary>
public interface IResourceName
{
    /// <summary>
    /// Operation description
    /// GET /path/{pathParam}
    /// </summary>
    /// <param name="pathParam">Parameter description</param>
    /// <param name="cancellationToken">The cancellation token</param>
    [Get("/path/{pathParam}")]
    Task<ResponseType> GetResourceAsync(
        string pathParam,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Update operation description
    /// PUT /path/{pathParam}
    /// </summary>
    [Put("/path/{pathParam}")]
    Task<ResponseType> UpdateResourceAsync(
        string pathParam,
        [Body] RequestType request,
        CancellationToken cancellationToken = default);
}
```

**Important Refit Rules:**
- Path parameters must NOT have `[AliasAs]` attribute
- Query parameters should use `[AliasAs("paramName")]` if different from C# name
- Body parameters must use `[Body]` attribute
- All methods should have `CancellationToken cancellationToken = default` parameter

#### Section Classes (`Meraki.Api/Sections/`)
```csharp
public class ResourceSection
{
    internal ResourceSection(IOrganizations organizations)
    {
        Organizations = organizations;
    }

    private IOrganizations Organizations { get; }

    public ISubResource SubResource => new SubResourceSection(Organizations);
}
```

### API Updates & Versioning

When updating for new Meraki API versions:

1. **Review the changelog**: Check official Meraki API changelog (e.g., `v1.63.0.md` found at https://raw.githubusercontent.com/CiscoDevNet/Meraki-Portal-What-s-New-Changelog/master/changelog/v1.63.0.md)

2. **Check the OpenApiSpec**: Review the OpenAPI specification for new endpoints and changes - found at https://raw.githubusercontent.com/meraki/openapi/refs/tags/v1.63.0/openapi/spec2.json where v1.63.0 is the version

3. **Update models**: Add new properties to existing models or create new models
   - Add properties as nullable unless required
   - Add XML documentation from API docs
   - Use `[DataMember(Name = "apiName")]` for JSON mapping

4. **Update interfaces**: Add new endpoints to appropriate interface

5. **Update CHANGELOG.md**: Document all changes with version number, date, and detailed list of changes

6. **Build**: Ensure `run_build` succeeds

7. Do not automatically commit - allow the user to review changes

### Common Patterns

#### Pagination
```csharp
// Interface with pagination
[Get("/resources")]
Task<List<Resource>> GetResourcesAsync(
    [AliasAs("perPage")] int? perPage = null,
    [AliasAs("startingAfter")] string? startingAfter = null,
    [AliasAs("endingBefore")] string? endingBefore = null,
    CancellationToken cancellationToken = default);
```

#### Optional Query Parameters
```csharp
// Use nullable types for optional parameters
[Get("/resources")]
Task<Resource> GetResourceAsync(
    string id,
    [AliasAs("include[]")] List<string>? include = null,
    [AliasAs("timespan")] double? timespan = null,
    CancellationToken cancellationToken = default);
```

#### Update/Create Requests
```csharp
// Separate request models from response models
[DataContract]
public class ResourceUpdateRequest
{
    [DataMember(Name = "name")]
    public string? Name { get; set; }
    
    [DataMember(Name = "enabled")]
    public bool? Enabled { get; set; }
}
```

### Error Handling

- The library uses Refit's error handling
- HTTP errors are handled by the underlying Refit infrastructure
- Custom retry logic exists in `MerakiClient` for rate limiting (429) and server errors (502, 503, 504)

### Configuration

- API key should be loaded from environment variables or configuration
- Use `MerakiClientOptions` for client configuration
- Support for different API regions (Default, China, Canada, India, Government)

## File Generation Guidelines

### When Creating New Models

1. Place in `Meraki.Api/Data/` directory
2. Use `[DataContract]` on class
3. Use `[DataMember(Name = "jsonName")]` on properties
4. Add XML documentation for class and all public members
5. Use nullable types appropriately

### When Creating New Interfaces

1. Place in appropriate subdirectory under `Meraki.Api/Interfaces/`
   - General: `/General/Organizations/`, `/General/Networks/`, `/General/Devices/`
   - Products: `/Products/Appliance/`, `/Products/Switch/`, `/Products/Wireless/`, etc.
2. Inherit from appropriate parent interface if needed
3. Use Refit attributes: `[Get]`, `[Post]`, `[Put]`, `[Delete]`, `[Patch]`
4. Follow the URL path structure from Meraki API documentation

### When Updating Existing Code

1. Search for similar patterns in the codebase first
2. Maintain consistency with existing code style
3. Update related tests if behavior changes
4. Update CHANGELOG.md with all changes

## Important Context

### Meraki API Specifics

- **Base URL**: `https://api.meraki.com/api/v1`
- **Authentication**: API key in `X-Cisco-Meraki-API-Key` header
- **Rate Limiting**: 
  - Per-organization rate limits
  - 429 responses include `Retry-After` header
  - Library automatically handles retries with exponential backoff
- **Pagination**: Uses `startingAfter` and `endingBefore` parameters

### Known Patterns in Codebase

1. **Section Hierarchy**: Mirrors Meraki API structure
   - Organizations → Wireless → MQTT
   - Networks → Switch → Ports
   - Devices → Wireless → Radio

2. **Extension Methods**: Used for "GetAll" pagination helpers in `Extensions/` folder

3. **Statistics**: `MerakiClientStatistics` tracks request counts and timing

4. **Custom Serialization**: `CustomNewtonsoftJsonContentSerializer` handles JSON (de)serialization with custom settings

## Common Tasks

### Adding a New Endpoint

1. Find or create the appropriate interface
2. Add the method with correct Refit attributes
3. Create/update request and response models
4. Add to section class if needed
5. Update CHANGELOG.md
6. Build and verify compilation

### Adding Properties to Existing Model

1. Locate the model in `Meraki.Api/Data/`
2. Add property with `[DataMember]` attribute
3. Add XML documentation
4. Use nullable type if optional
5. Update CHANGELOG.md
6. Build and verify

### Updating for New API Version

1. Review Meraki API changelog
2. Update models with new properties
3. Add new endpoints to interfaces
4. Create new models as needed
5. Update CHANGELOG.md with version number and changes
6. Run full build to verify

## Questions to Ask Before Implementing

1. **Does this follow the existing pattern?** - Look for similar code in the repository
2. **Is this .NET Standard 2.0 compatible?** - Verify APIs used are available
3. **Are all public members documented?** - Add XML comments
4. **Is nullability correct?** - Mark optional properties as nullable
5. **Does this match the Meraki API specification?** - Verify against official docs
6. **Are Refit attributes correct?** - No `[AliasAs]` on path parameters
7. **Is CHANGELOG.md updated?** - Document all changes

## Resources

- **Meraki API Documentation**: https://developer.cisco.com/meraki/api/
- **Refit Documentation**: https://github.com/reactiveui/refit
- **Project Repository**: https://github.com/panoramicdata/Meraki.Api

## Anti-Patterns to Avoid

❌ Using `[AliasAs]` on path parameters in Refit interfaces
❌ Forgetting XML documentation on public APIs
❌ Using non-.NET Standard 2.0 APIs without conditional compilation
❌ Breaking changes without major version bump
❌ Modifying existing property names (breaks serialization)
❌ Not updating CHANGELOG.md
❌ Hard-coding API keys or secrets

## Best Practices

✅ Study existing code patterns before implementing new features
✅ Keep model properties nullable unless explicitly required
✅ Use descriptive variable and method names
✅ Add comprehensive XML documentation
✅ Follow the existing section/interface hierarchy
✅ Test changes with actual API calls when possible
✅ Use `CancellationToken` for all async operations
✅ Update CHANGELOG.md for every change
✅ Run build before committing

---

When in doubt, look at existing similar code in the repository and follow those patterns. Consistency is key in this mature codebase.
