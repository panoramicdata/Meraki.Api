# Changelog

## v1.vnext
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

## v1.19.60
- Fixed NetworkTraffic.Port type from int to object, as the API can return either an int or a string
- Fixed Client.Manufacturer type from string to string?
- Fixed Client.Switchport type from string to string?
- BREAKING CHANGE: OrganizationDeviceStatus.productType renamed to ProductType (capitalized)
- Correctly implemented Wifi class (previously no fields were correctly mapping)

## v1.19.52
- Added LinkNegotiationCapabilities to SwitchProfilePorts and Switchport.
