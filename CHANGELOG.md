# Changelog

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
- Fixed https://developer.cisco.com/meraki/api-latest/#!get-organization-wireless-devices-ethernet-statuses for:
  - port to ports, permitting deserialization
  - renamed Speed to SpeedMbps
  - renamed IsConnectd to IsConnected

## v1.25.6
- Added https://developer.cisco.com/meraki/api-latest/#!get-organization-wireless-devices-ethernet-statuses as `MerakiClient.Wireless.Devices.OrganizationEthernetStatuses`

## v1.25.1
- Added appliance SSID endpoints - https://developer.cisco.com/meraki/api-v1/#!get-network-appliance-ssids

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
