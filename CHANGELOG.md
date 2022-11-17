# Changelog

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
  - Added https://developer.cisco.com/meraki/api-latest/#!get-organization-wireless-devices-ethernet-statuses 
as `MerakiClient.Wireless.Devices.OrganizationEthernetStatuses`

## v1.25.1
  - Added appliance SSID endpoints - https://developer.cisco.com/meraki/api-v1/#!get-network-appliance-ssids

## v1.24.19
  - Modified network settings local page authentication to allow setting password.

## v1.24.1
  - Changed all floats to double.
  - Modified several models to be nullable where the response model is also used in requests to allow only setting certain properties.
  - Added missing endpoints.
  - Updated existing models.
  - No change made yet to Client to support new documentation "Platform" layout.
Intention is to add "Platform" at the root level with duplicate references to sections and interfaces to allow easily finding calls matching documentation.

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
