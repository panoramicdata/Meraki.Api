﻿# Changelog

## 1.56.449
- Added UpdateDeviceSwitchPortSetVlanAsync to allow setting the VLAN on a switch port.
- Added UpdateDeviceSwitchPortSetPortScheduleIdAsync to allow setting the PortScheduleId on a switch port.

## 1.56.443
- Added ability to swap warm spare

## 1.56.438
 - Fixed StartTime and EndTime json member name in LossAndLatencyHistory.

## 1.56.436
- Fixed LossAndLatencyHistory StartTime and EndTime field type

## 1.56.433
- Added various missing interfaces and models to improve coverage

## 1.56.195
- Fixed GetOrganizationApplianceVpnStatsAllAsync to allow retrieving all items when specify t0 & t1 or timespan
- 
## 1.56.193
- Added extension method GetOrganizationApplianceVpnStatsAllAsync
- Fixed VpnPeers stats property types

## 1.56.191
- Added missing SerialNumber/Models
- 
## 1.56.190
- Fixed PerfScore property type for Device Appliance Performance

## 1.56.187
- Fixed Bssid field type for BasicServiceSet for Wireless Device Status
- Fixed Client.AdaptivePolicyGroup to be a nullable string

## 1.56.165
- Added an optional IRateLimiter to the MerakiClientOptions, which can be shared between multiple MerakiClients. The interface contains a single call 	public Task ApplyRateLimitingAsync(
		HttpRequestMessage httpRequestMessage,
		CancellationToken cancellationToken);
- Added a BasicRateLimiter implementation which will limit the number of requests per given timespan - the HttpRequestMessage is ignored.

## 1.56.164
- Added GetModelType handling for CPSC-HUB as CiscoSecureConnect

## 1.56.162
- Updated OpenRoamingCertificateId to support larger values

## 1.56.160
- Added many missing interface calls

## 1.56.21
- Added minimumPasswordLength to Organization admin security
- Added MV84X video resolution details
- Added NetworkType to OSPF Settings
- Added MacWhitelistLimit to switch port

## 1.56.20
- Added ipsk-with-nac for appliance SSID security type

## 1.56.19
- Updates for missing serial number/product type determination

## 1.56.18
- Updates for missing serial number/product type determination

## 1.56.17
- Updates for missing serial number/product type determination

## 1.56.13

- Updated for 1.56 API changes
- Updates for missing serial number/product type determination

## 1.55.11

- XML documentation is now correctly packaged
- Added UserAgent format Meraki documentation link
- Fix for "ReservedIPRanges are not updated when executing UpdateDeviceSwitchRoutingInterfaceDhcpAsync" PR #292 - Kudos @LouisDMateco

## 1.55.5

- Updated for 1.55 API changes

## 1.54.24

- Added filename to DhcpOptionType

## 1.54.23

- Added next_server to DhcpOptionType

## 1.54.22

- Added undocumented boot_options_enabled to DhcpOptionType

## 1.54.12

- WPA 192-bit Security added to appliance SSID

## 1.54.9

- Added Cellular Uplink enum member

## 1.54.7

- Fixes to GetNetworkApplianceUplinksUsageHistoryAsync(). Updated copyright notice.

## 1.54.5

- Reverted SwitchPort.cs changes and added overload for UpdateDeviceSwitchPortAsync to use SwitchPortUpdateRequest which allows nullable values for all properties.

## 1.54.1

- Updated for Meraki API 1.54

## 1.53.19

- Added nullable Client to ChangeLogEntry.cs to prevent deserialization errors for configurationChanges endpoint

## 1.53.12

- Reverted FluentAssertions to 7.0.0 due to licensing change

## 1.53.11

- Updated for Meraki API 1.53
- Updated Microsoft.CodeAnalysis.CSharp.Workspaces reference
- Updated FluentAssertions

## 1.51.51

- Added BackOffDelayFactor to MerakiClientOptions, defaults to 1.0, which allows automatic exponential increased delay on 429 until the maximum MaxBackOffDelay which defaults to 30.
The API response Retry-After will be honored up to the MaxBackOffDelay. 

## 1.51.49

- Fixed missing Organization Switches initialization

## 1.51.48

- Added 2880x2880 to MV93MResolution

## 1.51.47

- Added 3840x2160 to MV63Resolution

## 1.51.46

- Added 2880x2880 to MV33Resolution

## 1.51.45

- Added disabled to WirelessRfProfileFlexRadiosByModelBand
- Added 3840x2160 to MV13Resolution

## 1.51.18

- Modified MV32 to allow High quality on the profile

## 1.51.17

- Fixed LldpCdp.Ports to be a dictionary of string to LldpCdpPort

## 1.51.15

- Added subscription LicensingModel

## 1.51.12

- Updated more MV resolutions and models

## 1.51.8

- Added 2688x1512 to Mv63XResolution

## 1.51.7

- Added 2688x1512 to MV63

## 1.51.6

- Added IsRouteBased to ThirdPartyVpnPeer

## 1.51.5

- Updated for 1.51 API changes

## 1.50.4

- Added support for Canada, India and Goverment dashboards.

## 1.50.3

- Added resolution 2688x1512

## 1.50.1

- Updated for 1.50

## 1.49.14

- Region support added (for China).  The default region is "Default" ("Rest of the world").
If you want to select China, use:

```C#
merakiClientOptions.ApiRegion = ApiRegion.China;
```

## 1.49.11

- Misc updates

## 1.49.9

- Added wirelessController ProductType

## 1.49.7

- Now handling 504 errors and retrying the request in the same way as 502 & 503.

## 1.49.6

- Added undocumented Network isVirtual

## 1.49.4

- Now handling "Network unreachable" exceptions and retrying the request.
- Now handling 503 errors and retrying the request in the same way as 502.

## 1.49.1

- Updated for 1.49 API changes

## 1.48.8

- Updated dependencies and broken refit reference

## 1.48.4

- Updated for 1.48 API changes
- Adjusted "GetAll" extensions to utilise endingBefore as well as startingAfter. This currently only seemed to affect getting apiRequests.

## 1.46.1

- Added/updated new endpoints.
- Some new endpoints with new paging mechanism have not had "Get All" endpoints added until the inconsistencies between the models have been confirmed as intentional by Meraki API developers.

## 1.45.26

- BREAKING CHANGE : deleteNetworkGroupPolicy now requires a 'force' parameter
- Updates for 1.45 API changes
- Added missing member 'host' to organization cloud region.

## 1.43.34

- SwitchPortType updated to add Stack

## 1.41.8

- Added Organization Clients search in
- Updated dependencies

## 1.41.6

- Updated for 1.41

## 1.39.1

- Updated for AlertType motionAlert

## 1.38.24

- Added Z4 to be detected as an appliance

## 1.38.23

- Updated video resolutions enum

## 1.38.20

- Updated SensorCommand CompletedAt to be nullable

## 1.38.19

- Updated dependencies

## 1.38.18

- Added details to InventoryDevice

## 1.38.10

- Added Device Sensor Commands endpoints (currently in Early-Access)

## 1.38.1

- Initial updates for 1.38 API changes
- Added missing member Tag on AlertFilter

## 1.37.19

- Updated model detection to match Z3* as an Appliance

## 1.37.13

- Added missing AlertTypes

## 1.37.9

- Updated GetModelType to handle more model strings

## 1.37.7

- Updated with missing model members

## 1.37.1

- Updated for v1.37 API changes

## 1.36.30

- Updated for some missing Properties and added CW to product type detection as a Wireless device

## 1.36.24

- Added detection of catalyst 9200 and 9300 models as a switch

## 1.36.20

- Fixed further inconsistencies with webhook and corrected all occurrences of WebHooks/webHook to lowercase h.

## 1.36.19

- Fixes for Webhooks.  In some places, "WebHooks" has been changed to "Webhooks for consistency, which is a breaking change.

## 1.36.13

- Added missing MacBlockList settings on SwitchSettings - undocumented

## 1.36.3

- Updated for v1.36 API changes

## 1.35.1

- Updated for v1.35 API changes

## 1.34.39

- Added UnbindNetworkAsync with optional "retainConfigs" property.

## 1.34.35

- Added Multi to the BandOperationMode in the Meraki API

## 1.34.28

- Serial numbers added
- Updated dependencies

## 1.34.1

- Updated for v1.34 API changes

## 1.33.22

- Updated ClientUsageHistory Sent and Received to be longs instead of ints.

## 1.33.6

- Added uplinkClientSampling to Network Switch Settings

## 1.33.1

- Updated for v1.33 API changes

## 1.32.7

- Added observed value "open" for EncryptionMode on SSID

## 1.32.6

- Added missing AuthModes in SSID and corrected typos.

## 1.32.4

- Added missing Appliance DynamicDns Url.

## 1.32.3

- RefitSettings CollectionFormat now set to CollectionFormat.Multi, default was CSV, this allows sending multiple values for the filters.

## 1.32.2

- Updates models to reflect changes on API v1.32. Some nullability updated.

## 1.31.51

- Thanks to @rlouch2 for the PR to fix the encoding of colons in MACs being set in a GET query.
- Thanks to @garlic17 for the PR to catch the typo in a datamember for cidr.

## 1.31.48

- Allow all properties on an SSID Update to be nullable to allow only setting certain properties.

## 1.31.46

- Added MerakiClient.ApiClientVersion to return the library version which returns similar to 1.31.46

## 1.31.31

- Removed unnecessary AliasAs attributes to improve code maintenance
- Added analysers to detect correct AliasAs usage

## 1.31.14

- Fixed bug with missing DataContract on DeviceRemovalRequest

## 1.31.8

- Updated for 1.31 API changes
- All query endpoints that provide lists now have "[]" after the parameter name to allow for multiple values to be passed in and work with the Meraki API.

## 1.30.23

- Fixed GetOrganizationDevicesStatusesAsync and GetNetworkSmDevicesAsync to use "[]" after the parameter names for lists to work.
- Updated log messages when retry fails to include the method and url.

## 1.30.15

- Added obsolete VmConcentrator to ProductType
- Made all device properties nullable
- Modified GeoLocation Lat/Long to be non nullable as they should either both be present or the GeoLocation should be null

## 1.30.9

- Added LastRequestUri to MerakiClient

## 1.30.3

- Fix for GetOrganizationApiRequestsOverviewResponseCodesByIntervalAsync breaking client creation

## 1.30.1

- Added 1.30 related API endpoints and updated models. Some nullability updated.

## 1.29.11

- Added TotalActiveHours Extension for DaySchedule and PortSchedule

## 1.29.1

- Added daiTrusted to SwitchPort

## 1.28.6

- Updated GroupPolicy to allow all properties to be nullable

## 1.28.4

- Updated ActionBatch CreatedResource Id to be a string

## 1.27.23

- Changed RoutingInterface MulticastRouting property to be an enum.
- Updated RoutingInterface to identify InterfaceId as a key

## 1.27.15

- Allowed UplinkBandwidthLimits Wan1, Wan2 and Cellular to be nullable

## v1.27.4

- Added Mask and Cidr to vlanspec

## v1.27.3

- Added Device Cellular Sims
- Added Organization Policy Object Groups

## v1.26.22

- Fixed bug with policyObjects endpoint

## v1.26.1

- Added organisations summary top methods

## v1.25.13

- Fixed <https://developer.cisco.com/meraki/api-latest/#!get-organization-wireless-devices-ethernet-statuses> for:
  - port to ports, permitting deserialization
  - renamed Speed to SpeedMbps
  - renamed IsConnectd to IsConnected

## v1.25.6

- Added <https://developer.cisco.com/meraki/api-latest/#!get-organization-wireless-devices-ethernet-statuses> as `MerakiClient.Wireless.Devices.OrganizationEthernetStatuses`

## v1.25.1

- Added appliance SSID endpoints - <https://developer.cisco.com/meraki/api-v1/#!get-network-appliance-ssids>

## v1.24.19

- Modified network settings local page authentication to allow setting password.

## v1.24.1

- Changed all floats to double.
- Modified several models to be nullable where the response model is also used in requests to allow only setting certain properties.
- Added missing endpoints
- Updated existing models
- No change made yet to Client to support new documentation "Platform" layout.  Intention is to add "Platform" at the root level with duplicate references to sections and interfaces to allow easily finding calls matching documentation.

## v1.23.9

- Updates for Meraki API v1.23

## v1.22.19

- Renamed AuthMode enum entries
  - _8021xmeraki to Auth8021xmeraki
  - _8021xradius to Auth8021xradius

- Renamed DhcpLeaseTime enum entries
  - _30minutes to Duration30Minutes
  - _1hour to Duration1Hour
  - _4hours to Duration4Hours
  - _12hours to Duration12Hours
  - _1day to Duration1Day
  - _1week to Duration1Week

## v1.22.15

- Added JsonMissingMemberAction which will execute when Options.JsonMissingMemberHandling is set to something other than Ignore.

## v1.22.4

- Added Gateway to StaticRoute

## v1.22.3

- Changed AdaptivePolicyGroup CreatedAt and UpdatedAt to be DateTime
- Changed AdaptivePolicyPolicies to correct nullability. Changed timestamps to DateTime
- Updated RoutingOspf to add RoutingOspfV3 settings
- Made all DeviceClient properties null
- Updated nullability on SmNetworkUser
- Changed Products to FirmwareProducts

## v1.20.42

- v1.15 changes
- Added new properties to several models.
- Added new optional params to GetOrganizationDevicesAsync.
- Fixed WebhookTest models and Network models.
- Separated some request/response models.
- Updated SplashPage enum with new entries.

## v1.20.11

- Added Health Alerts to Networks Health.

## v1.20.10

- Added "arpInspection" to DHCP Server Policy.

## v1.20.8

- Updated for release against 1.20 API
- Added JsonMissingMemberResponseLogLevel to MerakiClientOptions. When set to something other than None, this will log the actual JSON response from the API when a member is missing from the response.
- Added "concentrator" to Wireless SSID VPN Settings.
- Added "alerts" to DHCP Server Policy.

## v1.19.78

- Updated the following method names to follow naming conventions:
  - `RemoveNetworkDeviceAsync` -> `RemoveNetworkDevicesAsync`
  - `GetNetworksWebhooksPayloadTemplatesAsync` -> `GetNetworkWebhooksPayloadTemplatesAsync`
  - `GetNetworkWebhooksPayloadTemplateAsync` -> `GetNetworkWebhooksPayloadTemplateAsync`
  - `UpdateNetworksWebhooksPayloadTemplatesAsync` -> `UpdateNetworkWebhooksPayloadTemplateAsync`
  - `GetNetworkSsidL3FirewallRulesAsync` -> `GetNetworkWirelessSsidFirewallL3FirewallRulesAsync`
  - `UpdateNetworkSsidL3FirewallRulesAsync` -> `UpdateNetworkWirelessSsidFirewallL3FirewallRulesAsync`
  - `GetNetworkCellularGatewaySettingsUplinkAsync` -> `GetNetworkCellularGatewayUplinkAsync`
  - `UpdateNetworkCellularGatewaySettingsUplinkAsync` -> `UpdateNetworkCellularGatewayUplinkAsync`
  - `GetNetworkCellularGatewaySettingsSubnetPoolAsync` -> `GetNetworkCellularGatewaySubnetPoolAsync`
  - `UpdateNetworkCellularGatewaySettingsSubnetPoolAsync` -> `UpdateNetworkCellularGatewaySubnetPoolAsync`
  - `UpdateOrganizationAdaptivePolicyGroup`-> `UpdateOrganizationAdaptivePolicyGroupAsync`
- Changed other function names to match documentation operation ids.
- Modified models to correct ApiAccess attributes.

## v1.19.60

- Fixed NetworkTraffic.Port type from int to object, as the API can return either an int or a string
- Fixed Client.Manufacturer type from string to string?
- Fixed Client.Switchport type from string to string?
- BREAKING CHANGE: OrganizationDeviceStatus.productType renamed to ProductType (capitalized)
- Correctly implemented Wifi class (previously no fields were correctly mapping)

## v1.19.52

- Added LinkNegotiationCapabilities to SwitchProfilePorts and Switchport.
