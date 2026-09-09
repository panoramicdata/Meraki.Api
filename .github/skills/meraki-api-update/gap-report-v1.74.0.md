# Meraki.Api against Dashboard API v1.74.0

Produced by `Find-MissingModelMembers.ps1` on 2026-09-09, against `main` at 84a0c39b.
Regenerate with:

```powershell
pwsh -File .\.github\skills\meraki-api-update\Prepare-MerakiApiUpdate.ps1 -Version 1.74.0
dotnet build Meraki.Api.slnx -c Debug
pwsh -File .\.github\skills\meraki-api-update\Find-MissingModelMembers.ps1 -SpecVersion v1.74.0 -OutCsv gap.csv
```

## Coverage

| Measure | Count |
|---|---|
| Refit endpoints in the library | 1075 |
| Operations in the v1.74.0 spec | 998 |
| Library endpoints matched to a spec operation | 861 |
| Library endpoints with no spec match | 214 |
| Spec operations not implemented | 140 |
| Unmapped response members on existing models | 155, across 86 types |

The 155 unmapped members break down as 118 scalars (string, integer, boolean, number) and 37
objects plus 23 arrays, so around 57 new nested model classes are needed alongside the
properties themselves.

The 214 unmatched library endpoints are not necessarily wrong. Some will be endpoints Cisco has
removed or renamed, and some will be path shapes this script's normalisation does not line up.
They need their own pass; a few may be dead code.

This is the accumulated gap, not only what 1.71 to 1.74 introduced. No attempt was made to
attribute each member to the release that added it.

## Unmapped members by product area

| Area | Members | Of which object or array |
|---|---|---|
| Organizations | 43 | 22 |
| SM | 27 | 5 |
| Appliance | 21 | 12 |
| Wireless | 19 | 6 |
| Switch | 11 | 3 |
| General | 10 | 1 |
| Camera | 8 | 1 |
| CellularGateway | 7 | 1 |
| Sensor | 6 | 5 |
| LiveTools | 2 | 0 |
| Licensing | 1 | 1 |

## Unmapped members in full

### Appliance (21)

| Model | JSON member | JSON type | Seen in |
|---|---|---|---|
| `AppliancePort` | `sgt` | object | getNetworkAppliancePort, getNetworkAppliancePorts |
| `Gre` | `clientIsolation` | boolean | getNetworkWirelessSsid, getNetworkWirelessSsids |
| `LanConfiguration` | `vrf` | object | getNetworkApplianceSingleLan |
| `MxFirewallRule` | `rules` | array | getNetworkApplianceFirewallInboundCellularFirewallRules |
| `Neighbor` | `vrf` | object | getNetworkApplianceVpnBgp |
| `NetworkUmbrellaAccountConnectResponse` | `umbrella` | object | connectNetworkApplianceUmbrellaAccount |
| `OrganizationApplianceDnsLocalRecordsProfile` | `address` | string | updateOrganizationApplianceDnsLocalRecord |
| `OrganizationApplianceDnsLocalRecordsProfile` | `hostname` | string | updateOrganizationApplianceDnsLocalRecord |
| `OrganizationApplianceDnsLocalRecordsProfile` | `profile` | object | updateOrganizationApplianceDnsLocalRecord |
| `OrganizationApplianceDnsLocalRecordsProfile` | `recordId` | string | updateOrganizationApplianceDnsLocalRecord |
| `SecurityEvent` | `wanTrafficUplinkPreferences` | array | updateNetworkApplianceSdwanInternetPolicies |
| `SiteToSiteVpn` | `hostTranslations` | array | getNetworkApplianceVpnSiteToSiteVpn |
| `SiteToSiteVpn` | `sgt` | object | getNetworkApplianceVpnSiteToSiteVpn |
| `StaticRoute` | `ipVersion` | integer | getNetworkApplianceStaticRoute, getNetworkApplianceStaticRoutes |
| `ThirdPartyVpnPeer` | `ecmpUplinkConfigs` | array | getOrganizationApplianceVpnThirdPartyVPNPeers |
| `ThirdPartyVpnPeerEbgpNeighbor` | `receiveLimit` | integer | getOrganizationApplianceVpnThirdPartyVPNPeers |
| `ThirdPartyVpnPeers` | `name` | string | getOrganizationApplianceVpnStatuses |
| `ThirdPartyVpnPeers` | `publicIp` | string | getOrganizationApplianceVpnStatuses |
| `ThirdPartyVpnPeers` | `reachability` | string | getOrganizationApplianceVpnStatuses |
| `TrafficUplinkPreference` | `vrf` | object | getNetworkApplianceTrafficShapingUplinkSelection |
| `Vlan` | `sgt` | object | createNetworkApplianceVlan, getNetworkApplianceVlans |

### Camera (8)

| Model | JSON member | JSON type | Seen in |
|---|---|---|---|
| `CameraRoleAppliedOnDevice` | `permissionLevel` | string | createOrganizationCameraRole, getOrganizationCameraRoles |
| `CameraRoleAppliedOnDevice` | `permissionScope` | string | createOrganizationCameraRole, getOrganizationCameraRoles |
| `CameraRoleAppliedOnNetwork` | `permissionLevel` | string | createOrganizationCameraRole, getOrganizationCameraRoles |
| `CameraRoleAppliedOnNetwork` | `permissionScope` | string | createOrganizationCameraRole, getOrganizationCameraRoles |
| `CameraRoleAppliedOrgWide` | `permissionLevel` | string | createOrganizationCameraRole, getOrganizationCameraRoles |
| `CameraRoleAppliedOrgWide` | `permissionScope` | string | createOrganizationCameraRole, getOrganizationCameraRoles |
| `CameraRoleAppliedOrgWide` | `tag` | string | createOrganizationCameraRole, getOrganizationCameraRoles |
| `Zones` | `zoneId` | object | getDeviceCameraAnalyticsLive |

### CellularGateway (7)

| Model | JSON member | JSON type | Seen in |
|---|---|---|---|
| `EsimsServiceProvidersAccountsItem` | `accountId` | string | getOrganizationCellularGatewayEsimsServiceProvidersAccounts |
| `EsimsServiceProvidersAccountsItem` | `lastUpdatedAt` | string | getOrganizationCellularGatewayEsimsServiceProvidersAccounts |
| `EsimsServiceProvidersAccountsItem` | `serviceProvider` | object | getOrganizationCellularGatewayEsimsServiceProvidersAccounts |
| `EsimsServiceProvidersAccountsItem` | `title` | string | getOrganizationCellularGatewayEsimsServiceProvidersAccounts |
| `EsimsServiceProvidersAccountsItem` | `username` | string | getOrganizationCellularGatewayEsimsServiceProvidersAccounts |
| `EsimsServiceProvidersItemLogo` | `url` | string | getOrganizationCellularGatewayEsimsServiceProviders |
| `NetworkCellularGatewayEsimsInventoryItemDevice` | `status` | string | getOrganizationCellularGatewayEsimsInventory, updateOrganizationCellularGatewayEsimsInventory |

### General (10)

| Model | JSON member | JSON type | Seen in |
|---|---|---|---|
| `Client` | `cdp` | array | getNetworkClient |
| `ClientProvision` | `clientId` | string | provisionNetworkClients |
| `ClientProvision` | `message` | string | provisionNetworkClients |
| `DeviceClient` | `adaptivePolicyGroup` | string | getDeviceClients |
| `DeviceClient` | `switchport` | string | getDeviceClients |
| `Events` | `clientMac` | string | getNetworkEvents |
| `LossAndLatencyHistory` | `endTime` | string | getDeviceLossAndLatencyHistory |
| `LossAndLatencyHistory` | `startTime` | string | getDeviceLossAndLatencyHistory |
| `SubclassApplicationUsage` | `received` | integer | getNetworkClientsApplicationUsage |
| `SubclassUsageHistory` | `received` | number | getNetworkClientsUsageHistories |

### Licensing (1)

| Model | JSON member | JSON type | Seen in |
|---|---|---|---|
| `OrganizationLicensingCotermLicenseMoveResponse` | `movedLicenses` | array | moveOrganizationLicensingCotermLicenses |

### LiveTools (2)

| Model | JSON member | JSON type | Seen in |
|---|---|---|---|
| `LiveToolsArpTableResultTableEntry` | `interface` | string | getDeviceLiveToolsArpTable |
| `LiveToolsThroughputTestCreateResponse` | `throughputTestId` | string | createDeviceLiveToolsThroughputTest |

### Organizations (43)

| Model | JSON member | JSON type | Seen in |
|---|---|---|---|
| `EarlyAccessFeatureOptInOptOutEligibilityHelp` | `label` | string | createOrganizationEarlyAccessFeaturesOptIn, getOrganizationEarlyAccessFeaturesOptIns |
| `FirmwareProducts` | `campusGateway` | object | getNetworkFirmwareUpgrades |
| `LoginSecurity` | `enforceLockedIpSessions` | boolean | getOrganizationLoginSecurity |
| `NetworkFirmwareUpdateStagedEventsProducts` | `switchCatalyst` | object | deferNetworkFirmwareUpgradesStagedEvents, rollbacksNetworkFirmwareUpgradesStagedEvents |
| `NetworkFirmwareUpgradeStagedEventsProduct` | `switchCatalyst` | object | getNetworkFirmwareUpgradesStagedEvents |
| `NetworkMove` | `createdAt` | string | createNetworkMove |
| `NetworkMove` | `initiator` | object | createNetworkMove |
| `NetworkMove` | `lastUpdatedAt` | string | createNetworkMove |
| `NetworkMove` | `moveId` | string | createNetworkMove |
| `NetworkMove` | `network` | object | createNetworkMove |
| `NetworkMove` | `organizations` | object | createNetworkMove |
| `NetworkMove` | `result` | object | createNetworkMove |
| `NetworkMoveDetailed` | `items` | array | getNetworkMoves |
| `NetworkMoveDetailed` | `meta` | object | getNetworkMoves |
| `NetworksCampusGatewayClusterUplink` | `addresses` | array | createNetworkCampusGatewayCluster |
| `NetworkStatusSummary` | `group` | object | getOrganizationSummaryTopNetworksByStatus |
| `NetworkStatusSummary` | `permissions` | object | getOrganizationSummaryTopNetworksByStatus |
| `NextUpgrade` | `predownload` | object | getNetworkFirmwareUpgrades |
| `NextUpgrade` | `strategy` | string | getNetworkFirmwareUpgrades |
| `OrganizationAdaptivePolicyOverview` | `limits` | object | getOrganizationAdaptivePolicyOverview |
| `OrganizationAdaptivePolicyOverviewCounts` | `customGroups` | integer | getOrganizationAdaptivePolicyOverview |
| `OrganizationAdaptivePolicyOverviewCounts` | `policyObjects` | integer | getOrganizationAdaptivePolicyOverview |
| `OrganizationAssuranceAlertScopeDevice` | `productType` | string | getOrganizationAssuranceAlert, getOrganizationAssuranceAlerts |
| `OrganizationAssuranceAlertsOverviewByNetworkItem` | `lastAlertedAt` | string | getOrganizationAssuranceAlertsOverviewByNetwork |
| `OrganizationAssuranceAlertsOverviewByTypeItem` | `categoryType` | string | getOrganizationAssuranceAlertsOverviewByType |
| `OrganizationAssuranceAlertsOverviewByTypeItem` | `count` | integer | getOrganizationAssuranceAlertsOverviewByType |
| `OrganizationAssuranceAlertsOverviewByTypeItem` | `deviceTags` | array | getOrganizationAssuranceAlertsOverviewByType |
| `OrganizationAssuranceAlertsOverviewByTypeItem` | `deviceTypes` | array | getOrganizationAssuranceAlertsOverviewByType |
| `OrganizationAssuranceAlertsOverviewByTypeItem` | `lastAlertedAt` | string | getOrganizationAssuranceAlertsOverviewByType |
| `OrganizationAssuranceAlertsOverviewByTypeItem` | `lastResolvedAt` | string | getOrganizationAssuranceAlertsOverviewByType |
| `OrganizationAssuranceAlertsOverviewByTypeItem` | `networkCount` | integer | getOrganizationAssuranceAlertsOverviewByType |
| `OrganizationAssuranceAlertsOverviewByTypeItem` | `networks` | array | getOrganizationAssuranceAlertsOverviewByType |
| `OrganizationAssuranceAlertsOverviewByTypeItem` | `severity` | string | getOrganizationAssuranceAlertsOverviewByType |
| `OrganizationAssuranceAlertsOverviewByTypeItem` | `type` | string | getOrganizationAssuranceAlertsOverviewByType |
| `OrganizationCampusGatewayCluster` | `items` | array | getOrganizationCampusGatewayClusters |
| `OrganizationCampusGatewayCluster` | `meta` | object | getOrganizationCampusGatewayClusters |
| `OrganizationDevice` | `imei` | string | getOrganizationDevices |
| `OrganizationDevicesSyslogServersRolesByNetworkItem` | `available` | array | getOrganizationDevicesSyslogServersRolesByNetwork |
| `OrganizationSplashTheme` | `isSystemTheme` | boolean | createOrganizationSplashTheme, getOrganizationSplashThemes |
| `OrganizationSplashTheme` | `themeAssets` | array | createOrganizationSplashTheme, getOrganizationSplashThemes |
| `SamlIdp` | `ssoLoginUrl` | string | getOrganizationSamlIdp, getOrganizationSamlIdps |
| `SamlIdp` | `visionConsumerUrl` | string | getOrganizationSamlIdp, getOrganizationSamlIdps |
| `WebhookAlertType` | `example` | object | getOrganizationWebhooksAlertTypes |

### Sensor (6)

| Model | JSON member | JSON type | Seen in |
|---|---|---|---|
| `SensorAlertConditionThresholdTemperature` | `fahrenheit` | number | getNetworkSensorAlertsProfile, getNetworkSensorAlertsProfiles |
| `SensorReadingHistoric` | `no2` | object | getOrganizationSensorReadingsHistory |
| `SensorReadingHistoric` | `o3` | object | getOrganizationSensorReadingsHistory |
| `SensorReadingHistoric` | `pm10` | object | getOrganizationSensorReadingsHistory |
| `SensorReadingLatest` | `items` | array | getOrganizationSensorGatewaysConnectionsLatest |
| `SensorReadingLatest` | `meta` | object | getOrganizationSensorGatewaysConnectionsLatest |

### SM (27)

| Model | JSON member | JSON type | Seen in |
|---|---|---|---|
| `DeviceLiveToolsMacTableCreateResponseRequest` | `mac` | string | createDeviceLiveToolsMacTable |
| `DeviceLiveToolsMacTableGetResponseRequest` | `mac` | string | getDeviceLiveToolsMacTable |
| `DeviceLiveToolsMulticastRoutingGetResponseInterface` | `ipVersion` | string | getDeviceLiveToolsMulticastRouting |
| `DeviceLiveToolsMulticastRoutingGetResponseInterface` | `vrf` | string | getDeviceLiveToolsMulticastRouting |
| `DeviceLiveToolsMulticastRoutingGetResponseInterface` | `vrfType` | string | getDeviceLiveToolsMulticastRouting |
| `DeviceLiveToolsMulticastRoutingGetResponseRoute` | `ipVersion` | string | getDeviceLiveToolsMulticastRouting |
| `DeviceLiveToolsMulticastRoutingGetResponseRoute` | `vrf` | string | getDeviceLiveToolsMulticastRouting |
| `OrganizationSmSentryPoliciesAssignmentsResponse` | `items` | array | updateOrganizationSmSentryPoliciesAssignments |
| `SmDevicesCheckinRequest` | `id` | string | modifyNetworkSmDevicesTags |
| `SmDevicesCheckinRequest` | `serial` | string | modifyNetworkSmDevicesTags |
| `SmDevicesCheckinRequest` | `tags` | array | modifyNetworkSmDevicesTags |
| `SmDevicesCheckinRequest` | `wifiMac` | string | modifyNetworkSmDevicesTags |
| `SmProfile` | `payloadTypes` | array | getNetworkSmProfiles |
| `SmTrustedAccessConfig` | `timeboundType` | string | getNetworkSmTrustedAccessConfigs |
| `SmVppAccount` | `allowedAdmins` | string | getOrganizationSmVppAccount, getOrganizationSmVppAccounts |
| `SmVppAccount` | `assignableNetworkIds` | array | getOrganizationSmVppAccount, getOrganizationSmVppAccounts |
| `SmVppAccount` | `assignableNetworks` | string | getOrganizationSmVppAccount, getOrganizationSmVppAccounts |
| `SmVppAccount` | `contentToken` | string | getOrganizationSmVppAccount, getOrganizationSmVppAccounts |
| `SmVppAccount` | `email` | string | getOrganizationSmVppAccount, getOrganizationSmVppAccounts |
| `SmVppAccount` | `lastForceSyncedAt` | string | getOrganizationSmVppAccount, getOrganizationSmVppAccounts |
| `SmVppAccount` | `lastSyncedAt` | string | getOrganizationSmVppAccount, getOrganizationSmVppAccounts |
| `SmVppAccount` | `name` | string | getOrganizationSmVppAccount, getOrganizationSmVppAccounts |
| `SmVppAccount` | `networkIdAdmins` | string | getOrganizationSmVppAccount, getOrganizationSmVppAccounts |
| `SmVppAccount` | `parsedToken` | object | getOrganizationSmVppAccount, getOrganizationSmVppAccounts |
| `SmVppAccount` | `vppAccountId` | string | getOrganizationSmVppAccount, getOrganizationSmVppAccounts |
| `SmVppAccount` | `vppLocationId` | string | getOrganizationSmVppAccount, getOrganizationSmVppAccounts |
| `SmVppAccount` | `vppLocationName` | string | getOrganizationSmVppAccount, getOrganizationSmVppAccounts |

### Switch (11)

| Model | JSON member | JSON type | Seen in |
|---|---|---|---|
| `AlternateManagementInterface` | `useOobMgmt` | boolean | getNetworkSwitchAlternateManagementInterface |
| `ConfigOverrides` | `voiceVlan` | integer | getDeviceSwitchPortsStatuses |
| `ConfigTemplateSwitchProfilePort` | `stpPortFastTrunk` | boolean | getOrganizationConfigTemplateSwitchProfilePort, getOrganizationConfigTemplateSwitchProfilePorts |
| `ConfigTemplateSwitchProfilePortDot3az` | `enabled` | boolean | getOrganizationConfigTemplateSwitchProfilePort, getOrganizationConfigTemplateSwitchProfilePorts |
| `NetworksSwitchDhcpV4ServersSeenLastPacketSourceIpv4` | `address` | string | getNetworkSwitchDhcpV4ServersSeen |
| `StackDevice` | `productType` | string | getNetworkTopologyLinkLayer |
| `SwitchPort` | `stpPortFastTrunk` | boolean | getDeviceSwitchPort, getDeviceSwitchPorts |
| `SwitchPortsStatusesBySwitch` | `items` | array | getOrganizationSwitchPortsStatusesBySwitch |
| `SwitchPortsStatusesBySwitch` | `meta` | object | getOrganizationSwitchPortsStatusesBySwitch |
| `SwitchPortsTopologyDiscoveryByDeviceItemPort` | `intervals` | array | getOrganizationSwitchPortsUsageHistoryByDeviceByInterval |
| `SwitchPortsUsageHistoryByDeviceByIntervalItem` | `serial` | string | getOrganizationSwitchPortsUsageHistoryByDeviceByInterval |

### Wireless (19)

| Model | JSON member | JSON type | Seen in |
|---|---|---|---|
| `AirMarshal` | `encryption` | string | getNetworkWirelessAirMarshal |
| `AirMarshal` | `manufacturers` | array | getNetworkWirelessAirMarshal |
| `AirMarshal` | `types` | array | getNetworkWirelessAirMarshal |
| `ConnectivityEvents` | `occurredAt` | string | getNetworkWirelessClientConnectivityEvents |
| `ConnectivityEvents` | `ssidNumber` | integer | getNetworkWirelessClientConnectivityEvents |
| `DevicesWirelessZigbeeEnrollmentsDetailed` | `enrollmentStartedAt` | string | getDeviceWirelessZigbeeEnrollment |
| `ElectronicShelfLabelSettingsNetwork` | `sepioo` | object | getNetworkWirelessElectronicShelfLabel, getNetworkWirelessElectronicShelfLabelConfiguredDevices |
| `FailedConnection` | `radio` | integer | getNetworkWirelessFailedConnections |
| `NaiRealm` | `name` | string | getNetworkWirelessSsidHotspot20 |
| `OrganizationWirelessControllerDevicesInterfacesL2UsageHistoryByIntervalGetResponse` | `meta` | object | getOrganizationWirelessControllerDevicesInterfacesL2UsageHistoryByInterval |
| `Ssid` | `campusGateway` | object | getNetworkWirelessSsid, getNetworkWirelessSsids |
| `Ssid` | `wlanIdentifier` | integer | getNetworkWirelessSsid, getNetworkWirelessSsids |
| `SsidsStatusesByDeviceItemBasicServiceSetRadio` | `index` | string | getOrganizationWirelessSsidsStatusesByDevice |
| `Wifi` | `endTime` | string | getNetworkNetworkHealthChannelUtilization |
| `Wifi` | `startTime` | string | getNetworkNetworkHealthChannelUtilization |
| `Wifi` | `utilization80211` | number | getNetworkNetworkHealthChannelUtilization |
| `Wifi` | `utilizationNon80211` | number | getNetworkNetworkHealthChannelUtilization |
| `Wifi` | `utilizationTotal` | number | getNetworkNetworkHealthChannelUtilization |
| `WirelessRfProfile` | `dot11be` | object | createNetworkWirelessRfProfile, getNetworkWirelessRfProfiles |
