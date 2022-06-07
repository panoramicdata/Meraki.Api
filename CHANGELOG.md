﻿# Changelog

## v.1.20.x
- Changed AdaptivePolicyGroup CreatedAt and UpdatedAt to be DateTime
- Changed AdaptivePolicyPolicies to correct nullability. Changed timestamps to DateTime
- Updated RoutingOspf to add RoutingOspfV3 settings
- Made all DeviceClient properties null
- Updated nullability on SmNetworkUser

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
- Added JsonMissingMemberResponseLogLevel to MerakiClientOptions. When set to something other than None, this will log
the actual JSON response from the API when a member is missing from the response.
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
