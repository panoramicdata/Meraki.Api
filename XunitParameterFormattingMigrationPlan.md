# xUnit Parameter Formatting Migration Plan

## Overview
This document outlines the plan to standardize parameter formatting across all unit test files in the Meraki.Api.Test project to comply with xUnit1051 (CancellationToken parameter naming) and improve code consistency.

## Current State Analysis
Based on the `WebHookTests.cs` file, the following pattern has been established:
- Multi-line parameter formatting for better readability
- Explicit `cancellationToken: CancellationToken` named parameter on API calls
- Consistent indentation and alignment

## Target Pattern

### For API Calls with Multiple Parameters
```csharp
var result = await TestMerakiClient
    .Section
    .SubSection
    .MethodAsync(
        parameter1,
  parameter2,
        parameter3,
        cancellationToken: CancellationToken);
```

### For API Calls with Single Parameter (+ CancellationToken)
```csharp
var result = await TestMerakiClient
    .Section
    .SubSection
    .MethodAsync(
        parameter1,
      cancellationToken: CancellationToken);
```

### For API Calls with Only CancellationToken
```csharp
var result = await TestMerakiClient
    .Section
    .SubSection
    .MethodAsync(cancellationToken: CancellationToken);
```

### For API Calls with Request Objects
```csharp
var result = await TestMerakiClient
    .Section
    .SubSection
    .MethodAsync(
        organizationId,
        new RequestObject
        {
        Property1 = value1,
            Property2 = value2
        },
    cancellationToken: CancellationToken);
```

## Migration Strategy

### Phase 1: High-Priority Test Files (Core Functionality)
Files that test core client functionality and are frequently referenced:

1. ? **Meraki.Api.Test\Networks\Webhooks\WebHookTests.cs** - COMPLETED (Reference Pattern)
2. **Meraki.Api.Test\Client\BasicRateLimiterTests.cs**
3. **Meraki.Api.Test\Client\BackOffDelaysTests.cs**
4. **Meraki.Api.Test\Organizations\OrganizationTests.cs** - Partially done
5. **Meraki.Api.Test\Networks\NetworkTests.cs**
6. **Meraki.Api.Test\Appliance\ApplianceTests.cs** - Partially done
7. **Meraki.Api.Test\Devices\Tests.cs**
8. **Meraki.Api.Test\RateLimitingTests.cs**

### Phase 2: Product-Specific Test Files
Tests for specific Meraki product lines:

#### Appliance
9. **Meraki.Api.Test\Appliance\Uplinks\UsageTests.cs**
10. **Meraki.Api.Test\Appliance\Vpn\ThirdPartyVpnPeers\Tests.cs**

#### Switch
11. **Meraki.Api.Test\Switch\Ports\SwitchPortTests.cs**
12. **Meraki.Api.Test\Switch\Ports\Tests.cs**
13. **Meraki.Api.Test\Switch\Routing\Interfaces\Tests.cs**
14. **Meraki.Api.Test\Switch\AccessControlLists\Tests.cs**
15. **Meraki.Api.Test\Switch\PortSchedules\Tests.cs**
16. **Meraki.Api.Test\Switch\Stacks\Tests.cs**

#### Wireless
17. **Meraki.Api.Test\Wireless\Status\Tests.cs** - Partially done
18. **Meraki.Api.Test\Wireless\Ssids\Tests.cs**
19. **Meraki.Api.Test\Wireless\Client\LatencyStats\Tests.cs**

#### Camera
(Tests embedded in Networks\Tests.cs - no separate file found)

#### Sensor
20. **Meraki.Api.Test\Devices\SensorCommands\Tests.cs** - Partially done

#### Secure Connect
21. **Meraki.Api.Test\SecureConnect\Tests.cs**

### Phase 3: Organization-Level Test Files
Tests for organization-level operations:

22. **Meraki.Api.Test\Organizations\Tests.cs**
23. **Meraki.Api.Test\Organizations\Networks\Tests.cs** - Partially done
24. **Meraki.Api.Test\Organizations\Devices\Tests.cs**
25. **Meraki.Api.Test\Organizations\ApiRequests\Tests.cs**
26. **Meraki.Api.Test\Organizations\ApiRequests\ApiRequestsTests.cs**
27. **Meraki.Api.Test\Organizations\Admins\Tests.cs**
28. **Meraki.Api.Test\Organizations\Clients\Tests.cs**
29. **Meraki.Api.Test\Organizations\ConfigTemplates\Tests.cs**
30. **Meraki.Api.Test\Organizations\ConfigurationChanges\Tests.cs**
31. **Meraki.Api.Test\Organizations\EarlyAccess\Tests.cs**
32. **Meraki.Api.Test\Organizations\InventoryDevices\Tests.cs**
33. **Meraki.Api.Test\Organizations\Licenses\Tests.cs** - Partially done
34. **Meraki.Api.Test\Organizations\SummaryTop\Tests.cs**

### Phase 4: Network-Level Test Files
Tests for network-level operations:

35. **Meraki.Api.Test\Networks\Tests.cs**
36. **Meraki.Api.Test\Networks\BluetoothClients\Tests.cs**
37. **Meraki.Api.Test\Networks\Clients\Tests.cs**
38. **Meraki.Api.Test\Networks\Devices\Tests.cs**
39. **Meraki.Api.Test\Networks\Devices\DeviceStatusesTests.cs**
40. **Meraki.Api.Test\Networks\Vlans\GetNetworkVlansTests.cs**
41. **Meraki.Api.Test\Networks\Vlans\UniqueVlanTests.cs**
42. **Meraki.Api.Test\Networks\Webhooks\Tests.cs**

### Phase 5: Utility and Extension Test Files
Tests for utility classes, extensions, and helpers:

43. **Meraki.Api.Test\Extensions\DeviceGetModelTypeTests.cs**
44. **Meraki.Api.Test\EndOfSaleDetails\Tests.cs**
45. **Meraki.Api.Test\Environmental\Tests.cs**
46. **Meraki.Api.Test\SerialNumberInfo\Tests.cs**
47. **Meraki.Api.Test\PortScheduleExtensions\DayScheduleTotalActiveHoursTests.cs**
48. **Meraki.Api.Test\PortScheduleExtensions\PortScheduleTotalActiveHoursTests.cs**

## Implementation Guidelines

### Step-by-Step Process for Each File

1. **Open the test file** in Visual Studio
2. **Identify all API calls** that accept a CancellationToken parameter
3. **For each API call:**
   - If the method has 0-1 parameters (excluding CancellationToken), keep on one line if short, otherwise multi-line
   - If the method has 2+ parameters (excluding CancellationToken), use multi-line formatting
   - Ensure `cancellationToken: CancellationToken` is always the last parameter
   - Use explicit named parameter syntax: `cancellationToken: CancellationToken`
   - Maintain consistent indentation (4 spaces or 1 tab per level)
   - Align parameters vertically when multi-line

4. **Handle special cases:**
   - **ConfigureAwait calls:** Remove if present (not needed in test context)
   - **Request object creation:** Keep request objects inline if short (1-3 properties), or extract to variable if complex
   - **Lambda expressions:** Maintain their current formatting unless they contain API calls
   - **Chained calls:** Format each level of the chain on a new line

5. **Verify compilation:**
 - Build the solution after each file
   - Fix any compilation errors
   - Run the specific test file to ensure tests still pass

6. **Commit strategy:**
   - Commit each phase separately
   - Use descriptive commit messages: "refactor: standardize parameters in [Phase] test files"

## Specific Patterns to Address

### Pattern 1: Missing Named Parameter
**Before:**
```csharp
var result = await TestMerakiClient
    .Section
    .MethodAsync(param1, param2, CancellationToken);
```

**After:**
```csharp
var result = await TestMerakiClient
  .Section
    .MethodAsync(
        param1,
        param2,
        cancellationToken: CancellationToken);
```

### Pattern 2: Single-Line with Multiple Parameters
**Before:**
```csharp
var result = await TestMerakiClient.Section.MethodAsync(param1, param2, CancellationToken);
```

**After:**
```csharp
var result = await TestMerakiClient
    .Section
    .MethodAsync(
  param1,
        param2,
        cancellationToken: CancellationToken);
```

### Pattern 3: ConfigureAwait in Tests
**Before:**
```csharp
var result = await TestMerakiClient
    .Section
    .MethodAsync(param1)
    .ConfigureAwait(false);
```

**After:**
```csharp
var result = await TestMerakiClient
    .Section
    .MethodAsync(
        param1,
        cancellationToken: CancellationToken);
```

### Pattern 4: Inline Request Objects
**Before:**
```csharp
await TestMerakiClient.Section.MethodAsync(id, new Request { Prop1 = val1 });
```

**After (if simple):**
```csharp
await TestMerakiClient
    .Section
    .MethodAsync(
  id,
        new Request { Prop1 = val1 },
        cancellationToken: CancellationToken);
```

**After (if complex):**
```csharp
var request = new Request
{
    Prop1 = val1,
    Prop2 = val2,
    Prop3 = val3
};

await TestMerakiClient
  .Section
    .MethodAsync(
      id,
        request,
        cancellationToken: CancellationToken);
```

### Pattern 5: Methods with Optional Parameters
**Before:**
```csharp
var result = await TestMerakiClient
    .Section
    .MethodAsync(
        organizationId,
     perPage: 100);
```

**After:**
```csharp
var result = await TestMerakiClient
    .Section
    .MethodAsync(
        organizationId,
    perPage: 100,
     cancellationToken: CancellationToken);
```

## Edge Cases to Handle

### 1. Tests Without CancellationToken
Some older tests may not use the CancellationToken from the base class. These should be updated to use it.

### 2. Tests with Inline Task.CompletedTask
```csharp
await Task.CompletedTask;
```
These don't need CancellationToken and should be left as-is.

### 3. Assert.ThrowsAsync Calls
```csharp
var exception = await Assert.ThrowsAsync<ApiException>(
    () => TestMerakiClient.Section.MethodAsync(param1, CancellationToken));
```
Format lambda body with consistent pattern.

### 4. Tests with Multiple Sequential API Calls
Each call should follow the pattern independently.

### 5. GetAllAsync Extension Methods
These should already have CancellationToken but verify the pattern:
```csharp
var result = await TestMerakiClient
    .GetAllAsync(
        (startingAfter, endingBefore, cancellationToken)
        => TestMerakiClient
    .Section
       .MethodAsync(
                orgId,
       startingAfter: startingAfter,
        endingBefore: endingBefore,
cancellationToken: cancellationToken
            ),
        CancellationToken.None
    );
```

## Quality Checks

After completing each phase:

1. ? All tests in the phase compile without errors
2. ? All tests in the phase pass
3. ? No xUnit1051 warnings remain for files in the phase
4. ? Code formatting is consistent across all files in the phase
5. ? No ConfigureAwait calls remain in test files
6. ? All API calls use named parameter for CancellationToken

## Success Criteria

- ? All 48+ test files follow the standardized pattern
- ? Zero xUnit1051 warnings in the solution
- ? All tests compile and pass
- ? Code is more readable and maintainable
- ? Consistent parameter formatting across entire test project

## Timeline Estimate

- **Phase 1:** 2-3 hours (8 files, core functionality requires careful testing)
- **Phase 2:** 2-3 hours (13 files, product-specific tests)
- **Phase 3:** 2-3 hours (13 files, organization-level tests)
- **Phase 4:** 2-2.5 hours (8 files, network-level tests)
- **Phase 5:** 1-2 hours (6 files, utilities and extensions)

**Total Estimated Time:** 9-13.5 hours

## Notes

- This migration improves code quality and maintainability
- The pattern established here should be used for all new test development
- Consider adding this to the `.github/copilot-instructions.md` file as a standard
- The CancellationToken from the base MerakiClientTest class should always be used
- This aligns with xUnit best practices and Microsoft coding guidelines

## Progress Tracking

Use this checklist to track progress:

### Phase 1: High-Priority
- [ ] Client\BasicRateLimiterTests.cs
- [ ] Client\BackOffDelaysTests.cs
- [ ] Organizations\OrganizationTests.cs
- [ ] Networks\NetworkTests.cs
- [ ] Appliance\ApplianceTests.cs
- [ ] Devices\Tests.cs
- [ ] RateLimitingTests.cs

### Phase 2: Product-Specific
- [ ] Appliance\Uplinks\UsageTests.cs
- [ ] Appliance\Vpn\ThirdPartyVpnPeers\Tests.cs
- [ ] Switch\Ports\SwitchPortTests.cs
- [ ] Switch\Ports\Tests.cs
- [ ] Switch\Routing\Interfaces\Tests.cs
- [ ] Switch\AccessControlLists\Tests.cs
- [ ] Switch\PortSchedules\Tests.cs
- [ ] Switch\Stacks\Tests.cs
- [ ] Wireless\Status\Tests.cs
- [ ] Wireless\Ssids\Tests.cs
- [ ] Wireless\Client\LatencyStats\Tests.cs
- [ ] Devices\SensorCommands\Tests.cs
- [ ] SecureConnect\Tests.cs

### Phase 3: Organization-Level
- [ ] Organizations\Tests.cs
- [ ] Organizations\Networks\Tests.cs
- [ ] Organizations\Devices\Tests.cs
- [ ] Organizations\ApiRequests\Tests.cs
- [ ] Organizations\ApiRequests\ApiRequestsTests.cs
- [ ] Organizations\Admins\Tests.cs
- [ ] Organizations\Clients\Tests.cs
- [ ] Organizations\ConfigTemplates\Tests.cs
- [ ] Organizations\ConfigurationChanges\Tests.cs
- [ ] Organizations\EarlyAccess\Tests.cs
- [ ] Organizations\InventoryDevices\Tests.cs
- [ ] Organizations\Licenses\Tests.cs
- [ ] Organizations\SummaryTop\Tests.cs

### Phase 4: Network-Level
- [ ] Networks\Tests.cs
- [ ] Networks\BluetoothClients\Tests.cs
- [ ] Networks\Clients\Tests.cs
- [ ] Networks\Devices\Tests.cs
- [ ] Networks\Devices\DeviceStatusesTests.cs
- [ ] Networks\Vlans\GetNetworkVlansTests.cs
- [ ] Networks\Vlans\UniqueVlanTests.cs
- [ ] Networks\Webhooks\Tests.cs

### Phase 5: Utility and Extension
- [ ] Extensions\DeviceGetModelTypeTests.cs
- [ ] EndOfSaleDetails\Tests.cs
- [ ] Environmental\Tests.cs
- [ ] SerialNumberInfo\Tests.cs
- [ ] PortScheduleExtensions\DayScheduleTotalActiveHoursTests.cs
- [ ] PortScheduleExtensions\PortScheduleTotalActiveHoursTests.cs

---

**Last Updated:** 2024 (document creation date)
**Status:** Planning Complete - Ready for Implementation
