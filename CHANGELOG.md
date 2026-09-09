# Changelog

## 1.74.15

- **Nineteen Wireless response members the v1.74.0 spec documents are now mapped**, the fourth
  per-area batch from the gap report: `Ssid.CampusGateway` (new `SsidCampusGateway` and
  `SsidCampusGatewayCluster`) and `Ssid.WlanIdentifier`; `WirelessRfProfileCreateUpdateRequest.Dot11be`
  (see below); `ElectronicShelfLabelSettingsNetwork.Sepioo` (new
  `ElectronicShelfLabelSettingsNetworkSepioo`); `AirMarshal.Encryption`, `.Manufacturers` and
  `.Types`; `Gre.ClientIsolation`; `NaiRealm.Name`; `FailedConnection.Radio`;
  `DevicesWirelessZigbeeEnrollmentsDetailed.EnrollmentStartedAt`; `ConnectivityEvents.SsidNumber`;
  `SsidsStatusesByDeviceItemBasicServiceSetRadio.Index`; and on `Wifi` (channel utilization) the
  API's current names `startTime`, `endTime`, `utilizationTotal`, `utilization80211` and
  `utilizationNon80211` alongside the legacy `start_ts`/`end_ts`/`utilization`/`wifi`/`non_wifi`
  members, which are kept because it is not known which set the API sends today.

- **Two misspelt member names corrected**, each of which meant the property never bound:
  `OrganizationWirelessControllerDevicesInterfacesL2UsageHistoryByIntervalGetResponse.Meta` was
  mapped to `name` instead of `meta`; and `WirelessRfProfileCreateUpdateRequest.Be` was mapped to
  `be` where the API sends `dot11be`, so it is now `Dot11be` and `WirelessRfProfileBe` gains the
  spec's `Mode` and `Ssids` (per-group settings, new `WirelessRfProfileBeSsids` and
  `WirelessRfProfileBeSsidGroup`). Also, `DevicesWirelessZigbeeEnrollmentsDetailed` had a property
  called `EnrollmentStartedAt` that was bound to `enrollmentStatus`; it is renamed `EnrollmentStatus`
  and the new `EnrollmentStartedAt` is the real timestamp. Regression tests are in
  `Meraki.Api.Test.Data.WirelessMemberTests`.

## 1.74.13

- **Eighteen Appliance response members the v1.74.0 spec documents are now mapped**, the third
  per-area batch from the gap report. Security Group Tag settings on `AppliancePort.Sgt`, `Vlan.Sgt`
  and `SiteToSiteVpn.Sgt` (new `AppliancePortSgt`, `VlanSgt`, `SiteToSiteVpnSgt`); VRF settings on
  `LanConfiguration.Vrf`, `Neighbor.Vrf` and `TrafficUplinkPreference.Vrf` (reusing `VlanVrf`, the
  same `{id, name}` shape); `SiteToSiteVpn.HostTranslations` (new `SiteToSiteVpnHostTranslation`
  and `SiteToSiteVpnHostTranslationAddress`); `ThirdPartyVpnPeer.EcmpUplinkConfigs` (new
  `ThirdPartyVpnPeerEcmpUplinkConfig` and `ThirdPartyVpnPeerEcmpUplinkConfigEbgpNeighbor`);
  `NetworkUmbrellaAccountConnectResponse.Umbrella` (new `NetworkUmbrellaAccountConnectResponseUmbrella`
  and `NetworkUmbrellaAccountConnectResponseUmbrellaOrganization`); `StaticRoute.IpVersion`;
  `ThirdPartyVpnPeerEbgpNeighbor.ReceiveLimit`.

- **Two more members that could never bind are corrected** (breaking in the type-system sense
  only, since they always came back empty):
  - `VpnStatus.ThirdPartyVpnPeers` was a `List<ThirdPartyVpnPeers>`, the *configuration* wrapper
    whose only member is `peers`. Each status entry is `{name, publicIp, reachability}`; the list is
    now `List<VpnStatusThirdPartyVpnPeer>`.
  - `UpdateOrganizationApplianceDnsLocalRecordAsync` returned `OrganizationApplianceDnsLocalRecordsProfile`
    (only `id`); the API returns the record, so it now returns
    `OrganizationApplianceDnsLocalRecordsResponse` like the create and list methods.

  Regression tests are in `Meraki.Api.Test.Data.ApplianceMemberTests`.

## 1.74.11

- **Nineteen Systems Manager response members the v1.74.0 spec documents are now mapped**, the
  second per-area batch from the gap report. `SmVppAccount` gains the thirteen fields the API
  returns beyond `id` and `vppServiceToken` (`VppAccountId`, `ContentToken`, `Email`, `Name`,
  `AllowedAdmins`, `NetworkIdAdmins`, `AssignableNetworks`, `AssignableNetworkIds`,
  `VppLocationId`, `VppLocationName`, `LastSyncedAt`, `LastForceSyncedAt` and `ParsedToken`, a new
  `SmVppAccountParsedToken`). `SmProfile.PayloadTypes` and `SmTrustedAccessConfig.TimeboundType`
  are added.

- **`ModifyNetworkSmDevicesTagsAsync` now returns `List<SmDevicesModifyTagsResponse>`** (breaking).
  It was declared as `List<SmDevicesCheckinRequest>`, the *request* type, whose members (`ids`,
  `scope`, `serials`, `wifiMacs`) never appear in the response; each returned device is
  `{id, serial, wifiMac, tags}` and previously came back as an empty object. `CheckinNetworkSmDevicesAsync`
  and `LockNetworkSmDevicesAsync` keep returning the request type, because the API's `{ids}`
  response does bind to it. Regression tests are in `Meraki.Api.Test.Data.SmMemberTests`.

## 1.74.9

- **Thirty Organizations-area response members the v1.74.0 spec documents are now mapped**, the
  first of the per-area batches from the gap report in `.github/skills/meraki-api-update/`. Scalars:
  `EarlyAccessFeatureOptInOptOutEligibilityHelp.Label`, `LoginSecurity.EnforceLockedIpSessions`,
  `NextUpgrade.Strategy`, `OrganizationAdaptivePolicyOverviewCounts.CustomGroups` and
  `.PolicyObjects`, `OrganizationAssuranceAlertScopeDevice.ProductType`,
  `OrganizationAssuranceAlertsOverviewByNetworkItem.LastAlertedAt`, `OrganizationDevice.Imei`,
  `OrganizationSplashTheme.IsSystemTheme`, `SamlIdp.SsoLoginUrl` and `.VisionConsumerUrl`. Nested:
  `FirmwareProducts.CampusGateway`, `NetworkFirmwareUpdateStagedEventsProducts.SwitchCatalyst` and
  `NetworkFirmwareUpgradeStagedEventsProduct.SwitchCatalyst` (reusing the existing product types),
  `NetworkStatusSummary.Group` and `.Permissions`, `NextUpgrade.Predownload`,
  `OrganizationAdaptivePolicyOverview.Limits` and `WebhookAlertType.Example`, backed by six new
  classes. Everything is read-only except where the spec puts the member on a request body
  (`NextUpgrade.Strategy`/`.Predownload`, `LoginSecurity.EnforceLockedIpSessions`, the firmware
  product entries), which are read/update.

- **Three models in this area had never matched the API and are corrected**, which is breaking for
  anyone reading the old members (they were always default-valued):
  - `OrganizationAssuranceAlertsOverviewByTypeItem` carried a copy of the by-network item's members
    (`AlertCount`, `NetworkId`, `NetworkName`, `SeverityCounts`). It now has the documented shape:
    `Type`, `CategoryType`, `Severity`, `Count`, `NetworkCount`, `Networks`, `DeviceTypes`,
    `DeviceTags`, `LastAlertedAt`, `LastResolvedAt`. `OrganizationAssuranceAlertsOverviewByTypeItemSeverityCount`
    is `[Obsolete]` and will be removed.
  - `WebhookAlertType` had the example payload's fields flattened onto the alert type; the API sends
    them under `example`. They are now `[Obsolete]` at the top level and available on `Example`,
    which also carries `NetworkTags`, `EnrollmentString`, `Notes`, `ProductTypes` and `EncryptedId`.
  - `OrganizationDevicesSyslogServersRolesByNetworkItem.AvailableRoles` was mapped to
    `availableRoles`; the API sends `available`. The C# name is unchanged.

  Regression tests are in `Meraki.Api.Test.Data.OrganizationsMemberTests`.

## 1.74.7

### Breaking changes

An audit against the v1.74.0 OpenAPI spec (`Find-ModelShapeMismatches.ps1`) found endpoints whose
declared return type does not match the shape the Dashboard API sends, so the call could never
deserialize, and `[DataMember]` names that are misspelt, so the property never bound. Fixing them
changes public signatures and property names; each change is listed so callers can update.

- **Six methods declared `List<T>` where the API sends an `{items, meta}` wrapper.** Each now
  returns a wrapper type deriving from `ItemsResponseWithMeta<T>`:
  `GetNetworkMovesAsync` → `NetworkMovesResponse`,
  `GetOrganizationCampusGatewayClustersAsync` → `OrganizationCampusGatewayClustersResponse`,
  `GetOrganizationSensorGatewaysConnectionsLatestAsync` → `OrganizationSensorGatewaysConnectionsLatestResponse`
  (items are the existing `SensorGatewayConnectionsLatestItem`, not `SensorReadingLatest`),
  `GetOrganizationSwitchPortsStatusesBySwitchAsync` → `OrganizationSwitchPortsStatusesBySwitchResponse`,
  `GetOrganizationIntegrationsXdrNetworksAsync` → the existing wrapper `OrganizationIntegrationsXdrByNetwork`
  (it was declared as a `List` of that wrapper), and
  `UpdateOrganizationSmSentryPoliciesAssignments` → `OrganizationSmSentryPoliciesAssignmentsUpdateResponse`
  (an `{items}` wrapper with no meta). Read `.Items` where you previously enumerated the result.

- **Six methods declared a single object where the API sends an array.** Each now returns
  `List<T>` of the type it previously returned:
  `GetAdministeredLicensingSubscriptionSubscriptionsComplianceStatusesAsync`,
  `GetNetworkSmDeviceConnectivityAsync`, `UpdateNetworkFirmwareUpgradesStagedStagesAsync`,
  `CreateOrganizationApplianceDnsLocalRecordAsync`, `GetOrganizationApplianceDnsLocalRecordsAsync`
  and `CreateOrganizationDevicesControllerMigrationAsync`.

- **Ten methods declared `List<T>` where the API sends a single object**, all single-resource paths:
  `GetNetworkApplianceFirewallFirewalledServiceAsync` and `Update…` → `FirewalledService`;
  `GetNetworkApplianceFirewallInboundCellularFirewallRulesAsync` and `Update…` →
  `InboundCellularFirewallRules` (the `{rules}` object; the getter was declared as a bare list of
  rules); `UpdateNetworkApplianceSdwanInternetPoliciesAsync` → `OrganizationApplianceSdwanInternetPolicies`
  (it was declared as `List<SecurityEvent>`, an unrelated type); `GetDeviceCameraCustomAnalyticsAsync`
  and `Update…` → `CameraCustomAnalytics`; `CreateOrganizationAdaptivePolicyAclAsync` → `AdaptivePolicyAcl`;
  `GetDeviceSensorRelationshipsAsync` → `SensorRelationship`; `GetNetworkSmDeviceRestrictionsAsync` →
  `SmDeviceRestrictions`.

- **`CreateNetworkMoveAsync` now returns `NetworkMoveDetailed`.** The API stopped returning
  `networkMoveId` and `url`, so neither property of `NetworkMove` bound; that type is now
  `[Obsolete]` and will be removed in a later release. `NetworkMoveDetailed` gains `MoveId` (the
  identifier the API now sends) and `Result` (a new `NetworkMoveResult` with `Status` and `Reason`);
  its `Status` is no longer in the spec and becomes nullable.

- **Misspelt member names corrected**, with the C# property renamed to match where it carried the
  typo: `ConnectivityEvents.OccuredAt` → `OccurredAt` (`occurredAt`),
  `SensorAlertConditionThresholdTemperature.Farenheit` → `Fahrenheit` (`fahrenheit`),
  `OrganizationLicensingCotermLicenseMoveResponse.MoveLicenses` → `MovedLicenses` (`movedLicenses`),
  `NetworkMoveDetailed.Initiator` (`intiator` → `initiator`),
  `OrganizationSplashTheme.ThemeAssets` (`themeAssests` → `themeAssets`), and
  `NetworksCampusGatewayClusterUplink.Addresses` (`address` → `addresses`).

- **`Meta` on every `ItemsResponseWithMeta<T>` response was always empty.** The abstract base and the
  `ItemsResponseMeta`, `ItemsResponseMetaCounts` and `ItemsResponseMetaCountsItems` classes lacked
  `[DataContract]`, so on each opt-in derived wrapper Newtonsoft treated the inherited `Meta` as
  ignored and dropped the API's `meta` object silently — pagination counts never arrived, and an
  unmapped field inside `meta` could not be detected. All four now carry `[DataContract]`. Not a
  signature change, but `Meta.Counts` will start being populated where it was previously null.

- Three object-versus-list findings were left alone as the known Meraki spec habit of documenting a
  list endpoint's item rather than the array (`GetNetworkWirelessRfProfilesAsync` is observed live
  as an array), and five where the spec documents an array whose only item is itself an
  `{items, meta}` wrapper (the library's wrapper is right). Regression tests in
  `Meraki.Api.Test.Data.ResponseShapeTests` cover the new shapes and the corrected names.

## 1.74.5

- **The library now tracks Dashboard API 1.74**, so `version.json` moves from `1.70` to `1.74`.
  v1.74.0 is the latest stable tag in `meraki/openapi`, published 2026-09-02. This resets the
  Nerdbank.GitVersioning height, which is why the versions jump from 1.70.138 rather than
  continuing to 1.70.139.

  The bump says which spec version the library is measured against. It does **not** claim every
  1.74 endpoint is implemented, and **no library code changed in this release** — only
  `version.json` and the repository's own tooling.

- **A repeatable model gap diff**, `.github/skills/meraki-api-update/Find-MissingModelMembers.ps1`.
  It reflects over the compiled Refit interfaces, matches each method's verb and path to a spec
  operation, then walks every 2xx JSON response schema in parallel with the C# return type,
  comparing spec property names against `[DataMember]` names. Dictionary-typed models, non-generic
  `Task` returns and purely numeric property names are excluded, because the spec describes those
  as ordinary properties while the models correctly represent them as open-ended maps or as no
  payload at all.

  Against v1.74.0 it reports **155 unmapped response members across 86 types**, 140 spec operations
  not implemented, and 214 library endpoints matching no spec path. That run is checked in as
  `gap-report-v1.74.0.md`, broken down by product area. This is the accumulated gap, not only what
  1.71 to 1.74 introduced.

## 1.70.138

- **Fourteen more response fields the Dashboard API returns are now mapped.** An unmapped-member
  export gathered from live organizations found them; callers who set
  `JsonMissingMemberHandling.ThrowOnError` were getting a failed deserialization rather than an
  ignored field, so for them these were hard failures on ordinary calls.

  Seven are simple scalars on classes that already existed:
  `VlanProfileDeviceAssignment.ConfigurationSource`, `ConfigTemplateSwitchProfilePort.ActiveVlans`,
  `CameraQualityRetentionProfile.AxisVideoQuality`, `VpnBgp.PriorityRoute`,
  `RoutingInterface.IsSwitchDefaultGateway`, and `TrafficShapingVpnExclusionsApplication.Protocol`
  and `.Source`.

  Seven are nested objects: `TwoPointFourGhzSettings.Dot11ax` and `FiveGhzSettings.Dot11ax`,
  `SwitchPort.PerpetualPoe` and `.FastPoe`, `NetworkApplianceSsidRadiusServer.Radsec`,
  `Admin.OtherOrganizationAccounts`, and `VpnBgp.Ipv6` and `.TunnelDownTermination`.

  Ten new classes back the nested ones: `TwoPointFourGhzSettingsDot11ax`, `FiveGhzSettingsDot11ax`,
  `SwitchPortPerpetualPoe`, `SwitchPortFastPoe`, `NetworkApplianceSsidRadiusServerRadsec`,
  `AdminOtherOrganizationAccounts` and `AdminOtherOrganizationAccountsLockout`, `VpnBgpIpv6`,
  `VpnBgpIpv6SinglePeering` and `VpnBgpTunnelDownTermination`.

  `Dot11ax` on both bands and both PoE objects are in the v1.74.0 OpenAPI spec on request bodies as
  well as responses, so they are writable: `Dot11ax` is read/write and the two PoE objects are
  read/update, matching their endpoints. The spec also marks `axEnabled` deprecated in favour of
  `dot11ax.enabled` on both bands, which the XML docs now say. `ConfigurationSource` and
  `AxisVideoQuality` are in the spec as response-only fields. The remaining ten appear nowhere in
  the spec and are mapped read-only from the observed responses. `Protocol` reuses the existing
  `TrafficShapingVpnExclusionsCustomProtocol` enum, matching `TrafficShapingVpnExclusionsCustom`,
  on which both `protocol` and `source` were already mapped.

  Only the first unmapped field in a response is ever reported, so four of the fourteen
  (`SwitchPort.FastPoe`, `VpnBgp.Ipv6` and `.TunnelDownTermination`, and
  `TrafficShapingVpnExclusionsApplication.Source`) were found by checking every sibling key of a
  reported field rather than only the reported field itself.

- **These mappings have credential-free regression tests.**
  `Meraki.Api.Test.Data.MissingMemberScalarFieldTests` and `MissingMemberNestedFieldTests`
  deserialize the observed payloads (with identifying values replaced) using
  `MissingMemberHandling.Error`, so an unmapped field fails the test instead of being dropped.
  CI gained a step that runs the whole `Meraki.Api.Test.Data` namespace, which previously ran no
  tests in CI at all.

## 1.70.133

- **Two more fields the Dashboard API returns are now mapped**: `ApiUsage.OperationId` (the
  operation a request called, e.g. `getOrganizationNetworks`) and
  `PayloadTemplateSharingByNetwork.WithAll` (whether a template is shared with every network rather
  than the listed ones). As with the eight in 1.70.127, callers who set
  `JsonMissingMemberHandling.ThrowOnError` were getting a failed deserialization rather than an
  ignored field. Only the first unmapped field in a response is ever reported, so fixing the
  previous batch is what revealed these.

- Internal restructuring only, with **no API change**: methods and files across the client, the MCP
  handler and the API checker were brought under the project's complexity and length limits.
  `MerakiClient.GeneralSections.cs` became one file per section
  (`MerakiClient.DevicesSections.cs`, `.NetworksSections.cs`, `.OrganizationsSections.cs`), and the
  MCP client's JSON reading moved to `MerakiMcpClient.Parsing.cs`. The types and members these
  files declare are unchanged; only their arrangement differs.

## 1.70.127

- **Eight response fields the Dashboard API has added are now mapped.** Running the integration
  suite against a live organization found eight fields with no model property. Callers who set
  `JsonMissingMemberHandling.ThrowOnError` were getting a failed deserialization rather than an
  ignored field, so for them these were hard failures on ordinary calls:
  `Network.Group`, `InventoryDevice.Address`, `EarlyAccessFeature.Advantage` and `.AdvantageTrial`,
  `WebhookHttpServer.Enabled`, `PayloadTemplateSharingByNetwork.Ids`, `Client.Model` and
  `ApiUsage.Version`. Types come from the observed responses; `WebhookHttpServer.Enabled` has only
  ever been seen in responses, so it is mapped read-only until a write is confirmed.

- **Seven public `const` members are now `static readonly`.** `Device.MaxAddressLength`,
  `FloorplanDevice.MaxAddressLength`, `Network.MaxNameLength`, `SwitchStack.MaxNameLength`,
  `MerakiMcpClient.SemanticSearchToolName`, `MerakiMcpClient.ExecuteApiToolName` and
  `MerakiMcpClientOptions.DefaultHostedUri` no longer inline into consuming assemblies, so a change
  to any of them takes effect on reference update rather than on recompile. **This is source-breaking
  in a `const` context**: code using one of these as an attribute argument, a `case` label, another
  `const`, or a default parameter value will no longer compile. Read at runtime, as almost all
  callers do, nothing changes.

- **Every section and Refit client on `MerakiClient` is now wired** (issue
  [#357](https://github.com/panoramicdata/Meraki.Api/issues/357)). The hand-maintained constructor had
  drifted from the 134-class section tree: 82 Refit interface properties and 4 sub-sections
  (`Devices.Appliance`, `Devices.Wireless`, `Networks.Switch`, `Organizations.Certificates.RadSec`)
  were null, so roughly a fifth of the client surface threw `NullReferenceException` on first use. Two
  credential-free tests now walk the tree by reflection and construct every Refit interface, so this
  cannot recur. The latter also found that `Refit.Reflection` was never referenced, leaving
  `IOrganizationsCameraDetections` unconstructable; it is now referenced. Constructing a client builds
  about 90 more Refit proxies, adding a few tens of milliseconds per instance, so reuse one where possible.

- Documented that the `*AllAsync` pagination helpers are **all-or-nothing**
  (issue [#355](https://github.com/panoramicdata/Meraki.Api/issues/355), first step). If any page
  fails, the exception propagates and already-fetched pages are discarded. Because Meraki answers 404
  for some genuinely empty collections, a 404 on a late page is indistinguishable from an empty result,
  so callers must not treat an exception as "empty". The 27 `*AllAsync` methods, the six `GetAll*Async`
  pagers and the README now say so. **No behaviour changed.**

- New opt-in `MerakiClientOptions.ThrowOnRetryExhaustion`
  (issue [#375](https://github.com/panoramicdata/Meraki.Api/issues/375)). When every attempt ends in a
  retryable status (429, 502, 503, 504), the client returned the final response, so the resulting
  `ApiException` was indistinguishable from a first-attempt failure. With the option set, it instead
  throws `RetryExhaustedException` carrying `StatusCode`, `AttemptCount`, `MaxAttemptCount`, `Elapsed`,
  `Method` and `RequestUri`. **Defaults to false.** The new exception is deliberately not an
  `ApiException`, so code that catches `ApiException` will not see it. Timeouts still throw
  `TimeoutException` and non-retryable statuses are still returned.

- Pagination **no longer stops silently** on a `rel=next` link the client cannot follow
  (issue [#356](https://github.com/panoramicdata/Meraki.Api/issues/356)). The Link parser required
  exactly one attribute per segment, so a link with an extra attribute (e.g. `title`) was treated as
  "no next page" and a truncated list was returned as complete. The parser now accepts any attributes
  and is shared with `QueryAsync` auto-pagination, which had the same flaw. A `rel=next` link whose URL
  is missing or relative now throws the new `PaginationException` rather than returning partial data.
  Multiple `rel=next` segments no longer throw; the first is used.

- A caller's `CancellationToken` now **aborts an in-flight HTTP attempt** immediately
  (issue [#391](https://github.com/panoramicdata/Meraki.Api/issues/391)). Previously only the waits
  between attempts honoured it, so cancelling mid-attempt waited out the rest of
  `HttpClientInnerTimeoutSeconds` (default 25 s). Timeout detection is unchanged: inner timeouts are
  still retried and caller cancellation still surfaces as `OperationCanceledException`. Cancellation
  inside `HttpClient` throws its subclass `TaskCanceledException`, so catch the base type.

- `MerakiClient` now calls `MerakiClientOptions.Validate()` in its constructor
  (issue [#377](https://github.com/panoramicdata/Meraki.Api/issues/377)), as `MerakiMcpClient` already
  did. Missing credentials, both `ApiKey` and `AccessToken` set, negative timeouts,
  `MaxAttemptCount` below 1 and `HttpClientTimeoutSeconds` of zero or less now throw
  `ConfigurationException` from `new MerakiClient(...)`. **Behaviour change:** a client with an empty
  `ApiKey` fails at construction rather than on first use; construct clients lazily if the key is not
  yet known.

- Documented how the retry options interact and why the defaults are what they are
  (issue [#378](https://github.com/panoramicdata/Meraki.Api/issues/378)). The `MaxBackOffDelaySeconds`
  comment wrongly claimed the delay doubles (that is `BackOffDelayFactor = 2.0`, not the default 1.0)
  and `MaxAttemptCount` was undocumented. Both now describe actual behaviour: a flat delay at the
  defaults, with `HttpClientTimeoutSeconds` ending a throttled call. The README gains a "Retries,
  back-off and rate limiting" section with a fail-fast example. **No default or behaviour changed.**

- `OrganizationApplianceUplinksUsageByNetworkItemByUplinkItem.Sent` and `.Received` are now `long`
  (issue [#360](https://github.com/panoramicdata/Meraki.Api/issues/360)). Cumulative byte counts over
  up to 31 days routinely exceed `Int32.MaxValue`, which made the whole call fail to deserialize. Source
  break only for code that declared the type as `int` explicitly.

- **BREAKING: the `netstandard2.0` target has been dropped. This package now targets `net10.0` only.**
  Consumers who need `netstandard2.0` should stay on 1.70.79.
  - Note the version does not jump to 2.0: this package's version tracks the Meraki Dashboard API
    version it targets (see [Versioning](README.md#versioning)), so a major bump would announce a
    Meraki API v2.0 that does not exist. The break is recorded here instead.
  - The second target was not merely redundant, it behaved differently. Four `ReadAsStringAsync`
    calls could not accept a `CancellationToken` on `netstandard2.0`, so cancellation was silently
    ignored there. The retry logic compared error strings case-sensitively on `netstandard2.0` and
    case-insensitively on `net10.0`, so the two targets could disagree about whether a failure was
    retryable. Both divergences are now impossible.
  - The MCP client was excluded from `netstandard2.0` entirely (20 files, ~2,000 lines). There is now
    one public surface across the package rather than two.
  - Refit is back to a single version. 1.70.79 had to pin Refit 15.2.0 for `net10.0` and 11.2.0 for
    `netstandard2.0`, because Refit dropped `netstandard2.0` at 12.0.0.
  - All twelve `#if NETSTANDARD2_0` blocks are gone, replaced by the modern APIs they were polyfilling
    (`ArgumentNullException.ThrowIfNull`, range indexers, `Random.Shared`, `StartsWith(char)`).

- MCP: **Meraki Dashboard rate limiting is now retried transparently** (issue
  [#389](https://github.com/panoramicdata/Meraki.Api/issues/389)). The server reports a rate limit
  *inside an otherwise successful tool response*, answering the HTTP request with 200, so
  `MerakiMcpBackingOffHttpMessageHandler` never saw a 429 and its retry and back-off never engaged.
  The first rate-limited call therefore failed outright as a `MerakiMcpProtocolException`, however
  generous `MaxAttemptCount` was - confirmed against the live hosted server, which reported
  `Retries: 0` alongside the failure.
  - `SemanticSearchAsync` and `ExecuteApiAsync` now retry while the server reports a rate limit,
    honouring `MaxAttemptCount`, `BackOffDelayFactor` and `MaxBackOffDelaySeconds`, and recording
    each wait in `MerakiMcpClientStatistics` so a slow call is still explicable.
  - Once attempts are exhausted they throw `MerakiMcpRateLimitException`, which already carries the
    attempt count, rather than `MerakiMcpProtocolException`. A caller that wants to come back later
    needs to tell "busy" apart from "malformed".
  - Rate limiting is detected from both the MCP error flag and the payload error envelope, and
    matched on message text tolerantly, because the server supplies no machine-readable code for it.
  - **Other payload errors are unchanged** and still fail immediately: retrying a missing required
    parameter would spend the very budget the retry protects.

  Rate limiting is an expected condition rather than an exceptional one, since an agentic
  investigation is several capability calls in quick succession sharing the documented
  10-requests-per-second-per-organization budget with every other consumer of the same key. Callers
  should not have to reimplement retry logic the library already performs for HTTP 429s - and a
  caller that hands these operations to a language model cannot retry reliably at all, because
  whether the model retries sensibly is not a decision to delegate.


## 1.70.58

- Optional parameters across the Refit interfaces are now declared **nullable**: `string? t0 = null`
  rather than `string t0 = null!` (issue
  [#386](https://github.com/panoramicdata/Meraki.Api/issues/386)). 194 parameters in 50 interface
  files, all of them optional query or body parameters where `null` is how a caller omits the value.
  The old form asserted the opposite of the contract, so a consumer with nullable reference types
  enabled got a CS8604 at every call site that computed the value - and had no honest way to silence
  it, because sending an empty string instead is not the same request. Nullability is metadata: no
  signature, default value or runtime behaviour changed, and the test suite gives identical results
  before and after.

## 1.70.57

- Back-off after an HTTP 429 is now **jittered**, so clients sharing an API key that are throttled in
  the same window no longer all retry at the same instant
  (issue [#374](https://github.com/panoramicdata/Meraki.Api/issues/374)). Meraki's rate limit is per
  organization and `Retry-After` hands every throttled client the same value, which actively aligned
  them. `Retry-After` is still honoured exactly: jitter is only ever applied *upward*, so a retry can
  never happen earlier than the server asked, and it never exceeds `MaxBackOffDelaySeconds`. Where a
  delay has already reached that ceiling there is no headroom and it is left unchanged.
- A request that hits the per-attempt timeout (`HttpClientInnerTimeoutSeconds`, default 25 seconds)
  now **waits before retrying** instead of retrying immediately
  (issue [#376](https://github.com/panoramicdata/Meraki.Api/issues/376)). This was the only retry path
  in the client with no delay at all, while every other path already paused. The wait uses the
  configured `BackOffDelayFactor`, so it is one second at the default factor of 1.0.
- The API reference documentation is now generated from the built assembly
  (issue [#373](https://github.com/panoramicdata/Meraki.Api/issues/373)).

Both retry changes affect timing only. No option or public API changed, so no existing configuration
behaves differently beyond when it retries.

## 1.70.51
- Added first-class support for the complete **Cisco Workflows Automation API**.
  - New typed `MerakiClient.Workflows` surface generated from Cisco's published Automation OpenAPI
    document: 156 operations across 99 paths and 350 request/response schemas.
  - Covers workflows and runs plus targets, variables, schedules, rules, triggers, tables, tasks,
    webhooks, tenants, sharing, and Exchange import/export/install operations across v1, v1.1,
    v1.2, v2, and exchange/v1.
  - Projects the organization ID into every method, so a single client can safely access multiple
    organizations.
  - Reuses the existing API-region routing, read-only enforcement, rate limiter, exponential
    back-off, logging, request statistics, and timeout configuration.
  - Sends Dashboard API keys as Bearer credentials only for Workflows routes, as Cisco requires,
    while leaving authentication for the existing Dashboard and Secure Connect APIs unchanged.
  - Includes typed multipart file upload for the v1.1 workflow-start operation, generated API
    exceptions, a complete mocked Exchange-import/read/validate/execute/inspect/delete lifecycle,
    and an explicit real-service lifecycle test using the same temporary, side-effect-free
    `Completed` workflow artifact with `finally`-based cleanup.
  - Verifies that Workflows `429 rate_limit_exceeded` responses use the existing `MerakiClient`
    `Retry-After` and back-off path; the explicit lifecycle test retains the production retry policy.
  - Handles both documented workflow deletion successes: a typed response for `202 Accepted` and
    `null` for `204 No Content`.
  - Includes README guidance and a full conceptual documentation page with a minimal Exchange-import
    lifecycle example, a complete executable fixture, and test commands.

- MCP: `MerakiMcpResult` now unwraps the server's response envelope. The server returns
  `{"result":{"type":"success","capability_id":"...","data": ... }}`, so `RawJson` alone forced callers
  to unwrap it themselves and `Deserialize<T>()` could not match the REST response shapes. New
  `DataJson` (the `data` element, or null when no envelope is present) and `Payload`
  (`DataJson ?? RawJson`); `Deserialize<T>()` now uses `Payload`. `RawJson` still exposes the full
  envelope for anyone who wants `capability_id` or `product`. Also found by live smoke-testing.

## 1.70.50

- MCP: `ExecuteApiAsync` and `SemanticSearchAsync` now detect an error reported in the *payload* of an
  otherwise successful tool result and throw `MerakiMcpProtocolException`, including the server's
  `recovery_suggestion`. Found by smoke-testing against the live hosted server, which returns
  `{"result":{"type":"error","error":"Missing required parameters", ...}}` without setting the MCP
  error flag. Previously that error document was returned to the caller as though it were data.
- MCP: documented that `MerakiCapability.Score` is currently always null against the hosted server,
  so the ranking is the list order alone.

## 1.70.49

- Added first-class support for the **Cisco Meraki MCP server**
  (issue [#365](https://github.com/panoramicdata/Meraki.Api/issues/365)).
  - New `MerakiMcpClient` with typed `SemanticSearchAsync`, `ExecuteApiAsync` and
    `GetStatusAsync` operations, wrapping the server's `semantic_search` and `execute_api` tools.
  - All three deployments supported: the Cisco-hosted server at `https://mcp.meraki.com/mcp`,
    a self-hosted instance over HTTP, and a self-hosted instance launched over stdio.
  - Retry, `Retry-After` handling and exponential back-off mirroring `MerakiClient`, plus
    `MerakiMcpClientStatistics`.
  - A dedicated exception taxonomy distinguishing invalid credentials (401) from unauthorised
    organizations (403), tool-catalogue drift, rate limiting, transport failure and protocol errors.
  - Guard rails: hosted transport rejects non-default `ApiRegion` (the hosted server supports
    Meraki.com only), and `ExecuteApiAsync` refuses non-read capabilities because the MCP server
    is read-only by design. Mutations remain the job of `MerakiClient`.
  - **The MCP types are compiled for `net10.0` only.** The `netstandard2.0` target's public
    surface and dependency graph are unchanged.

## 1.70.45

- Fixed several organization-level Refit clients being left `null` by the `MerakiClient`
  constructor, which threw `NullReferenceException` on first use
  (issue [#337](https://github.com/panoramicdata/Meraki.Api/issues/337)):
  - `Organizations.Summary.SwitchPower`
  - `Organizations.Appliance.Uplinks.Usage`
  - `Organizations.Wireless.Devices.Latency`
  - `Organizations.Wireless.Devices.PacketLoss`
  - `Organizations.Wireless.Devices.ChannelUtilization`
- Fixed `IOrganizationsWirelessDevicesChannelUtilization`, which Refit could not build at
  all: all four methods spelled the parameter `orgnanizationId` while the route templates
  used `{organizationId}`, so `RestService.For<T>()` threw
  `ArgumentException: ... has parameter organizationid, but no method parameter matches`.
  The parameter is now `organizationId` throughout. Callers using named arguments would
  need to update, but the interface could not be constructed before this fix.

## 1.70.37

- Surfaced `MerakiClient.Wireless.DataRateHistory.GetNetworkWirelessDataRateHistoryAsync`,
  covering `GET /networks/{networkId}/wireless/dataRateHistory`. Returns the average,
  download and upload PHY data rates (Kbps) over time for a network, bucketed by time
  interval, with optional `band` (`2.4`/`5`/`6`) and `ssid` filters. The
  `IWirelessDataRateHistory` interface already existed but was not exposed on
  `WirelessSection`; this wires it up so it is reachable via the client.
  - Confirmed against the live API.

## 1.70.33

- Added `MerakiClient.Wireless.Radio.RfHealth.GetOrganizationWirelessRadioRfHealthOverviewByNetworkByIntervalAsync`,
  covering `GET /organizations/{organizationId}/wireless/radio/rfHealth/overview/byNetwork/byInterval`.
  Returns RF health score, high co-channel interference percentage, and channel
  change count, broken down by network, band and time interval.
  - Confirmed against the live API: `timespan` is capped at exactly `2629746`
    seconds (one second over returns a 400), and `interval` only accepts `7200`
    or `86400` (any other value returns a 400). If `interval` is omitted, the
    server silently widens its default bucket size from 7200 to 86400 once the
    requested timespan is large enough - pass `interval` explicitly for a
    predictable bucket size.

## 1.70.21

- **Breaking:** Renamed all remaining camelCase public properties in
  `Meraki.Api.Data` to PascalCase. The JSON wire format is unchanged (each
  keeps its `[DataMember(Name = "...")]`); only code referencing these
  properties by their old camelCase C# name needs updating.
- Removed the now-redundant `IDE1006` naming suppression and a stale `CA1848`
  one, dropped some dead commented-out code, and documented the DTO naming
  convention in `CONTRIBUTING.md`.

## 1.70.10

- Rewrote `GetEndOfLifeDetailsAsync` HTML parsing to match the current Meraki
  End-of-Life products page. The previous parser split the first table cell on
  spaces, which mangled multi-word product names and invented bogus regions.
  - `DeviceModelEndOfLifeDetail.DeviceModel` now contains the full product
    description exactly as published (it previously held only the first
    space-delimited token).
  - Added `DeviceModelEndOfLifeDetail.Models`: the individual model identifiers
    parsed from the row, kept verbatim including the `-HW` suffix. Note: the
    Dashboard API device model omits `-HW`, so match case-insensitively and allow
    a trailing `-HW` when relating these to devices.
  - Added `DeviceModelEndOfLifeDetail.Regions`: the region codes a row applies to
    (e.g. `US`, `UK`, `EU`, `NA`, `WW`), parsed from a parenthetical list
    (`GS110-8P (UK)`, `MA-INJ-4-XX (AU, CN, EU, UK, US)`) or a SKU suffix
    (`GX50-HW-US`). Empty for rows that are not region-specific.
  - Rejoin a model split across adjacent `<a>` tags (e.g. `MR70` + `-HW` becomes
    `MR70-HW`).
  - Expand license SKU shorthand to full SKUs, e.g.
    `LIC-MI-XS (1D, 1YR, 3YR, 5YR, 7YR, 10YR)` and `LIC-MT-3Y, 5Y, 7Y, 10Y`.
  - Parse the several published date formats (abbreviated and full month names,
    missing leading zero, and missing comma); unparseable dates now yield null
    instead of mangled values.
  - `DeviceModelEndOfLifeDetail.Region` (legacy single-region string) is retained
    for compatibility but is no longer populated; use `Regions` instead.

## 1.70.9

- Bumped Refit and Refit.Newtonsoft.Json from 10.2.0 to 11.0.1 to maintain compatibility with consuming projects that have upgraded to Refit 11

## 1.70.7

- Updated dependencies

## 1.70.6

- Added missing `Organization.Privacy` response property with supporting
  `OrganizationPrivacy` and `OrganizationPrivacyByDefault` models

## 1.70.5

- Fixed deserialization for camera quality retention profiles by adding
  `Mv84xResolution.Size1440x1080` mapped to API value `"1440x1080"`

## 1.70.0

- Updated models for Meraki Dashboard API `v1.70.0` member-level schema changes
- Added missing properties:
  `Client.RecentDeviceId`, `DeviceAppliancePrefixesDelegatedItem.StaticDelegatedPrefixId`,
  `RoutingInterfaceCreateRequest.Mtu`, `RoutingInterfaceUpdateRequest.Mtu`,
  `SwitchSettings.PortChannelFallback`, `VlanCreationRequest.Vrf`, and `VlanSpec.Vrf`
- Added preview-order resolution support with
  `OrganizationInventoryOrdersPreviewResponse.Resolution` and new
  `OrganizationInventoryOrdersPreviewResolution` model
- Added `OrganizationAssuranceAlertNetwork.Url`
- Updated `StaticRouteCreationRequest.GatewayVlanId` to nullable integer to match
  API request schema
- Updated optionality for delegated prefix fields in
  `NetworkAppliancePrefixesDelegatedStatic` and
  `DeviceAppliancePrefixesDelegatedItem`

## 1.67.37

- Added missing model properties from observed API responses: `InventoryDevice.Sku`,
  `MqttBroker.ProductType`, `NetworkSettings.Twilio`,
  `NetworkSnmpSetting.Authentication`, `NetworkSnmpSetting.Privacy`,
  `RoutingInterface.Mtu`, `Ssid.Security`, `StaticRoute.Vpn`,
  `TrafficShapingVpnExclusionsMajorApplication.Source`, `VideoSettings.Mv44X`,
  `Vlan.Vrf`, and `WirelessBilling.HasTransactions`
- Added supporting models for the new Twilio, SNMP, SSID security, static
  route VPN, MV44X, and VLAN VRF response shapes

## 1.67.36

- Added missing writable properties to `SwitchPortUpdateRequest`: `ActiveVlans`,
  `MacWhitelistLimit`, `HighSpeed`; use this request model with
  `UpdateDeviceSwitchPortAsync` to update individual fields without overwriting
  others

## 1.67.24

- Removed 30 unused model classes that were not referenced anywhere in the
  codebase: `ClientAccess`, `DenyOnlyPolicy`,
  `DeviceForUnsettingTheSwitchProfileId`, `DeviceUpdateRequest`, `DeviceUplink`,
  `FirmwareUpgradesRollback`,
  `FloorPlanBatchDevicesUpdateRequestAssignmentFloorPlan`, `Layer7RuleType`,
  `LicenseClaim`, `LinkLayerNodeDiscoveredCdp`,
  `LiveToolsThroughputTestCallbackPayload`, `LockNetworkSmDevices`,
  `NetworkVlanEnabledStatus`,
  `NetworksCampusGatewayClusterDeviceIPAddressWithGateway`,
  `OrganizationConfigTemplatesSwitchProfilesPortsMirrorUpdateResponseConfigTemplate`,
  `OrganizationLicensing`,
  `OrganizationWirelessDevicesRadsecCertificateAuthority`,
  `OrganizationWirelessDevicesRadsecCertificateAuthorityUpdateRequest`,
  `SensorGatewayConnectionsLatest`, `SensorMetricDownstreamPowerState`,
  `SensorMetricPowerApparent`, `SensorMetricPowerReal`,
  `SmAppPolarisCreationRequest`, `SmAppPolarisUpdateRequest`,
  `SmDevicesTagsUpdateRequest`,
  `SwitchPortsTopologyDiscoveryByDeviceItemPortLldp`,
  `ThirdPartyVpnPeersUpdateRequest`, `UrlObject`,
  `WanTrafficUplinkPreferencesUpdateRequest`, `WarmSpareSettingsUpdateRequest`

## 1.67.23

- Added missing `Vrrp` property to `RoutingInterface` with new
  `RoutingInterfaceVrrp`, `RoutingInterfaceVrrpIpv4`, and
  `RoutingInterfaceVrrpIpv6` models

## 1.67.17

- Added missing `Upgrade` property to `WirelessSettings` and
  `WirelessSettingsUpdateDto` with new `WirelessSettingsUpgrade` and
  `WirelessSettingsUpgradePredownload` models
- Added missing `RadiusAccountingDeviceProfiling` property to
  `SsidUpdateRequest` with new `SsidRadiusAccountingDeviceProfiling` model
- Added missing `Protocol` property to
  `TrafficShapingVpnExclusionsMajorApplication`

## 1.67.13

- Fixed `LicensingSubscriptionsSection` to implement `ILicensingSubscriptions`,
  restoring compatibility with the
  `GetAdministeredLicensingSubscriptionSubscriptionsAllAsync` extension method
- Fixed `GetAdministeredLicensingSubscriptionEntitlementsAsync` return type from
  `Task<AdministeredLicensingSubscriptionEntitlements>` to
  `Task<List<AdministeredLicensingSubscriptionEntitlements>>` to match the API
  response

## 1.67.12

- `Licensing.Subscriptions` is now a `LicensingSubscriptionsSection` (previously
  `ILicensingSubscriptions`); existing subscription methods remain accessible
  directly
- Added `Licensing.Subscriptions.Entitlements` for retrieving purchasable
  entitlements

## 1.67.11

- Added missing `RadiusAccountingUpdateOnEvent` property to `SsidUpdateRequest`
- Added missing `FilterIn` and `CommunityOut` properties to `Neighbor`
- Added missing `Source` property to `TrafficShapingVpnExclusionsCustom`
- Added missing `Uplinks` property to `Vlan` with new `VlanUplink` and
  `VlanUplinkNat` models
- Added missing `LocalRadiusServer` property to `WirelessSettings` with new
  `WirelessSettingsLocalRadiusServer` model

## 1.67.8

- Update docs and API access for SsidRadioSetting and SwitchPortSchedule

## 1.67.6

- Fixed LicensingSubscription model to match API responsee

## 1.67.1

- Added missing `Language` property to `SsidSplashSettings` model

## 1.64.45

- Added missing properties for various models

## 1.64.44

- Added missing ApiForeignKey attribute to the PortScheduleId property in
  SwitchPort class

## 1.64.42

- Updated models for missing JSON members identified from API responses

## 1.64.41

- **New Feature: API Response Codes History Endpoints (Beta)**
  - Added 4 new endpoints to track API request response codes aggregated by
    different dimensions:
    - `GetOrganizationApiRequestsResponseCodesHistoryByAdminAsync` - Lists API
      request response codes and their counts aggregated by admin
      - GET
        `/organizations/{organizationId}/apiRequests/responseCodes/history/byAdmin`
    - `GetOrganizationApiRequestsResponseCodesHistoryByApplicationAsync` - Lists
      API request response codes and their counts aggregated by application
      - GET
        `/organizations/{organizationId}/apiRequests/responseCodes/history/byApplication`
    - `GetOrganizationApiRequestsResponseCodesHistoryByOperationAsync` -
      Aggregates API usage data by operationId
      - GET
        `/organizations/{organizationId}/apiRequests/responseCodes/history/byOperation`
    - `GetOrganizationApiRequestsResponseCodesHistoryBySourceIpAsync` -
      Aggregates API usage by source IP
      - GET
        `/organizations/{organizationId}/apiRequests/responseCodes/history/bySourceIp`
  - Added new data models:
    - `ApiResponseCodeCount` - Response code and total count
    - `ApiResponseCodeCounts` - Contains byCode array and total
    - `ApiResponseCodeOverall` - Overall response code information wrapper
    - `ApiResponseCodesHistoryByAdmin` - Admin-level aggregation with adminId,
      name, email, and overall counts
    - `ApiResponseCodesHistoryByApplication` - Application-level aggregation
      with userAgentString, name, and overall counts
    - `ApiResponseCodesHistoryByOperation` - Operation-level aggregation with
      operationId and overall counts
    - `ApiResponseCodesHistoryBySourceIp` - Source IP-level aggregation with
      sourceIp and overall counts
  - Note: These endpoints are currently in beta (API v1.65.0-beta.0)

## 1.64.40

- **New Feature: OAuth Bearer Token Authentication**
  - Added `AccessToken` property to `MerakiClientOptions` for OAuth Bearer token
    authentication
  - When `AccessToken` is set, authentication uses
    `Authorization: Bearer {AccessToken}` header instead of the API key header
  - Either `ApiKey` or `AccessToken` must be set, but not both
  - Updated `Validate()` method to enforce authentication requirements

## 1.64.37

- **Testing Infrastructure Fix**: Resolved xUnit v3 compatibility issue in test
  project
- Refit updated

## 1.64.35

- Updated IsMixedDefault to read only - fixed typo

## 1.64.34

- Updated IsMixedDefault to read only

## 1.64.33

- Added `AccessControl` property to `Ssid` class (read-only) - SSID access
  control settings including:
  - `Encryption` - Encryption mode settings
  - `Bandwidth` - Bandwidth limit settings
  - `ClientIpAssignment` - Client IP assignment mode
  - `ClientsBlockedFromUsingLan` - Whether clients are blocked from using LAN
  - `WiredClientsPartOfWifiNetwork` - Whether wired clients are part of the
    Wi-Fi network
  - `Tunnel` - Tunnel enabled status and summary
  - `Vlan` - VLAN enabled status and tag
  - `SplashPage` - Splash page enabled status and theme
- Added new data models:
  - `SsidAccessControl` - Main access control settings container
  - `SsidAccessControlEncryption` - Encryption mode settings
  - `SsidAccessControlBandwidth` - Bandwidth limit settings
  - `SsidAccessControlClientIpAssignment` - Client IP assignment mode settings
  - `SsidAccessControlTunnel` - Tunnel settings with enabled status and summary
  - `SsidAccessControlVlan` - VLAN settings with enabled status and tag
  - `SsidAccessControlSplashPage` - Splash page settings with enabled status and
    theme
- Added `PayloadTemplateId` property to `WebhookHttpServerPayloadTemplate`
  class - Alternate property name for the payload template ID

## 1.64.32

- **Breaking Change**: Updated `ClaimNetworkDevicesAsync` return type from
  `Task` to `Task<DeviceClaimResponse>`
  - The API now returns a response object containing:
    - `Serials` - List of successfully claimed device serial numbers
    - `Errors` - List of errors for devices that failed to be claimed (each with
      `Serial` and list of error messages)
  - Added new data models:
    - `DeviceClaimResponse` - Response wrapper with serials and errors
    - `DeviceClaimError` - Error details for failed device claims
  - This change provides better visibility into partial success scenarios when
    claiming multiple devices
- **New Feature: Push API Support (Private Beta)**
  - Added Push API endpoints for event-driven notifications (eliminates
    polling):
    - **Topics**: GET `/organizations/{organizationId}/api/push/topics` - List
      available Push API topics
    - **Receiver Profiles**: CRUD operations for Push receiver profiles
      - GET `/organizations/{organizationId}/api/push/receivers/profiles` - List
        receiver profiles
      - POST `/organizations/{organizationId}/api/push/receivers/profiles` -
        Create receiver profile
      - DELETE
        <!-- markdownlint-disable-next-line MD013 -->
        `/organizations/{organizationId}/api/push/receivers/profiles/{receiverProfileIname}` -
        Delete receiver profile
    - **Push Profiles**: CRUD operations for Push profiles (topic subscriptions)
      - POST `/organizations/{organizationId}/api/push/profiles` - Create push
        profile (subscribe to topic)
      - PUT
        `/organizations/{organizationId}/api/push/profiles/{pushProfileIname}` -
        Update push profile
      - DELETE
        `/organizations/{organizationId}/api/push/profiles/{pushProfileIname}` -
        Delete push profile
  - Added new data models:
    - `PushTopic` - Represents a Push API topic
    - `PushTopicReference` - Topic reference for profiles
    - `PushReceiver` - Receiver configuration
    - `PushReceiverProfile` - Receiver profile with iname, name, description
    - `PushProfile` - Push profile linking topics to receivers
    - `PushProfileUpdateRequest` - Update request for push profiles
  - Added new interfaces:
    - `IOrganizationsApiPushTopics` - Push topics operations
    - `IOrganizationsApiPushReceiversProfiles` - Receiver profile operations
    - `IOrganizationsApiPushProfiles` - Push profile operations
  - Added new section hierarchy:
    - `OrganizationsApiSection` - Root section for organization API operations
    - `OrganizationsApiPushSection` - Push API section
    - `OrganizationsApiPushReceiversSection` - Push receivers section
  - Added integration tests in `Meraki.Api.Test.PushApi` namespace
  - Supported topics in private beta:
    - `organizationDevicesAvailabilitiesChangeHistory` - Device availability
      changes
    - `organizationConfigurationChanges` - Configuration changes
  - Note: Push API is currently in private beta. Requires webhook HTTP servers
    to be configured first.

## 1.64.28

- Added missing `Details` property to `Network` class (object?, read-only) -
  Undocumented additional details about the network returned by the API

## 1.64.27

- Updated to also build .NET 9.0 target along with .NET 10.0 and .NET Standard
  2.0

## 1.64.25

- **BREAKING CHANGE**: Upgraded solution to .NET 10.0 (projects now target .NET
  10.0 and .NET Standard 2.0)
- **Major Improvement**: Complete XML documentation coverage - ALL CS1591
  warnings resolved
  - Added comprehensive XML documentation for all public classes, properties,
    methods, and enum members
  - Enabled `TreatWarningsAsErrors` for documentation compliance
  - All public APIs now have proper IntelliSense documentation
- **Infrastructure**: Migrated solution to modern `.slnx` format
- **Testing**: Fixed Visual Studio Test Runner compatibility issues
- Code quality improvements and general code tidying
- Updated project dependencies

## 1.64.2

- Fixed missing JSON members identified from API responses across multiple
  models:
  - **StatusPageAuthentication**: Added `PasswordSet` property (bool?,
    read-only) - Indicates whether a password has been set for the Local Status
    Page
  - **SwitchSettings**: Added `UplinkSelection` property with supporting models:
    - `SwitchSettingsUplinkSelection` - Contains failback settings and
      candidates configuration
    - `SwitchSettingsUplinkSelectionFailback` - Controls whether failback is
      enabled
  - **InventoryDevice**: Added End-of-Life (EOL) tracking properties:
    - `EoxStatus` (string?) - End of Life status ("endOfSale", "endOfSupport",
      "nearEndOfSupport", or empty)
    - `EndOfSaleAt` (DateTime?) - End of sale date
    - `EndOfSupportAt` (DateTime?) - End of support date
  - **GroupPolicySecurityGroupTag**: Added `Value` property (int?) - Security
    group tag numeric value
  - **RoutingInterface**: Added advanced routing configuration properties:
    - `SwitchFabricId` (string?, read-only) - Switch Fabric ID for the interface
    - `StaticV4Dns1` (string?) - Primary static IPv4 DNS server
    - `StaticV4Dns2` (string?) - Secondary static IPv4 DNS server
  - **NetworkBluetoothSettings**: Added `Transmit` property
    (BluetoothTransmitSettings?) - Network-level Bluetooth beacon transmit
    configuration
  - **DeviceBluetoothSettings**: Added `Transmit` property
    (BluetoothTransmitSettings?) - Device-level Bluetooth beacon transmit
    configuration
- Created new supporting model classes:
  - `BluetoothTransmitSettings` - Contains power level, interval, and advertised
    power settings
  - `BluetoothAdvertisedPower` - Contains advertised power in dBm

## 1.63.8

- Fixed deserialization error for Bonjour forwarding services by adding missing
  `Chromecast` enum value to `BonjourService`
- Updated `BonjourForwardingRule` documentation to include `Chromecast` in the
  list of available services

## 1.63.3

- Updated for Meraki API v1.63
- Added new wireless MQTT settings endpoints for organizations:
  - **GET** `/organizations/{organizationId}/wireless/mqtt/settings` - Return
    MQTT settings for networks
  - **PUT** `/organizations/{organizationId}/wireless/mqtt/settings` - Add new
    broker config for wireless MQTT
- Added new data models for wireless MQTT settings:
  - `OrganizationWirelessMqttSettings` - Main settings model with network, mqtt,
    ble, and wifi properties
  - `OrganizationWirelessMqttSettingsNetwork` - Network information
  - `OrganizationWirelessMqttSettingsMqtt` - MQTT configuration including topic,
    message fields, publishing settings, and broker
  - `OrganizationWirelessMqttSettingsMqttPublishing` - Publishing frequency and
    QoS settings
  - `OrganizationWirelessMqttSettingsMqttBroker` - Broker reference information
  - `OrganizationWirelessMqttSettingsBle` - BLE settings including type, flush,
    allow lists, and hysteresis
  - `OrganizationWirelessMqttSettingsBleFlush` - BLE flush frequency settings
  - `OrganizationWirelessMqttSettingsBleAllowLists` - BLE UUID and MAC allow
    lists
  - `OrganizationWirelessMqttSettingsBleHysteresis` - BLE hysteresis threshold
    settings
  - `OrganizationWirelessMqttSettingsWifi` - Wi-Fi settings including type,
    flush, allow lists, and hysteresis
  - `OrganizationWirelessMqttSettingsWifiFlush` - Wi-Fi flush frequency settings
  - `OrganizationWirelessMqttSettingsWifiAllowLists` - Wi-Fi MAC allow lists
  - `OrganizationWirelessMqttSettingsWifiHysteresis` - Wi-Fi hysteresis
    threshold settings
  - `OrganizationWirelessMqttSettingsResponse` - Paginated response wrapper
  - `OrganizationWirelessMqttSettingsUpdateRequest` - Request model for updating
    settings
- Added `IOrganizationsWirelessMqtt` interface with GET and PUT methods
- Added `Mqtt` property to `OrganizationsWirelessSection`
- Added `GetOrganizationWirelessMqttSettingsAllAsync` extension method for
  automatic pagination

## 1.62.13

- Added missing JSON members identified from API responses:
  - **StatusPageAuthentication**: Added `passwordSet` property (bool, read-only)
    to indicate if a password has been set
  - **SwitchSettings**: Added `uplinkSelection` property with nested models for
    failback settings and candidate uplink selection
  - **InventoryDevice**: Added End-of-Life (EOL) properties: `eoxStatus`,
    `endOfSaleAt`, and `endOfSupportAt`
  - **GroupPolicySecurityGroupTag**: Added `value` property (int) for security
    group tag value
  - **RoutingInterface**: Added `switchFabricId`, `staticV4Dns1`, and
    `staticV4Dns2` properties for advanced routing configurations
  - **NetworkBluetoothSettings**: Added `transmit` property with nested models
    for power, interval, and advertised settings
  - **DeviceBluetoothSettings**: Added `transmit` property with nested models
    for device-specific Bluetooth beacon configuration
- Created new nested model classes following hierarchy naming convention:
  - `SwitchSettingsUplinkSelection` and `SwitchSettingsUplinkSelectionFailback`
  - `NetworkBluetoothSettingsTransmit` and
    `NetworkBluetoothSettingsTransmitAdvertised`
  - `DeviceBluetoothSettingsTransmit` and
    `DeviceBluetoothSettingsTransmitAdvertised`

## 1.61.29

- Added missing members

## 1.61.26

- Added missing members

## 1.61.25

- Fixed issue with Radius Server list for NetworkApplianceSsidUpdateRequest

## 1.61.23

- Fixed issue with type for NetworkApplianceSsidUpdateRequest

## 1.61.22

- Updates for missing members and endpoints
- Improved handling when the Meraki API hangs by offering an inner timeout/retry
  mechanism, controlled by MerakiClientOptions.HttpClientInnerTimeoutSeconds. By
  default, this value is set to 25.
- Improved handling when the Meraki API resets the connection

## 1.61.11

- Nuget package updates

## 1.61.1

- Updated for 1.61 API changes.
- Increased default timeout to 600s to accommodate longer running requests.
- Increased default MaxAttempts to 100 to accommodate more retries due to per-IP
  rate limiting on api.meraki.com

## 1.57.9

- Added GetAllFromResponsePropertyAsync extension method to handle responses
  with meta/data, e.g. SecureConnect.

## 1.57.6

- Added initial Secure Connect endpoints
- Fixing retainConfigs parameter on UnbindNetworkAsync to be set in body.

## 1.56.454

- BREAKING CHANGE: Removed support for Shard-direct API access, as this will
  cease to work due to a change being applied by Meraki in September 2025.

## 1.56.449

- Added UpdateDeviceSwitchPortSetVlanAsync to allow setting the VLAN on a switch
  port.
- Added UpdateDeviceSwitchPortSetPortScheduleIdAsync to allow setting the
  PortScheduleId on a switch port.

## 1.56.443

- Added ability to swap warm spare

## 1.56.438

- Fixed StartTime and EndTime json member name in LossAndLatencyHistory.

## 1.56.436

- Fixed LossAndLatencyHistory StartTime and EndTime field type

## 1.56.433

- Added various missing interfaces and models to improve coverage

## 1.56.195

- Fixed GetOrganizationApplianceVpnStatsAllAsync to allow retrieving all items
  when specify t0 & t1 or timespan
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

- Added an optional IRateLimiter to the MerakiClientOptions, which can be shared
  between multiple MerakiClients. The interface contains a single call public
  Task ApplyRateLimitingAsync( HttpRequestMessage httpRequestMessage,
  CancellationToken cancellationToken);
- Added a BasicRateLimiter implementation which will limit the number of
  requests per given timespan - the HttpRequestMessage is ignored.

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
- Fix for "ReservedIPRanges are not updated when executing
  UpdateDeviceSwitchRoutingInterfaceDhcpAsync" PR #292 - Kudos @LouisDMateco

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

- Fixes to GetNetworkApplianceUplinksUsageHistoryAsync(). Updated copyright
  notice.

## 1.54.5

- Reverted SwitchPort.cs changes and added overload for
  UpdateDeviceSwitchPortAsync to use SwitchPortUpdateRequest which allows
  nullable values for all properties.

## 1.54.1

- Updated for Meraki API 1.54

## 1.53.19

- Added nullable Client to ChangeLogEntry.cs to prevent deserialization errors
  for configurationChanges endpoint

## 1.53.12

- Reverted FluentAssertions to 7.0.0 due to licensing change

## 1.53.11

- Updated for Meraki API 1.53
- Updated Microsoft.CodeAnalysis.CSharp.Workspaces reference
- Updated FluentAssertions

## 1.51.51

- Added BackOffDelayFactor to MerakiClientOptions, defaults to 1.0, which allows
  automatic exponential increased delay on 429 until the maximum MaxBackOffDelay
  which defaults to 30. The API response Retry-After will be honored up to the
  MaxBackOffDelay.

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

- Region support added (for China). The default region is "Default" ("Rest of
  the world"). If you want to select China, use:

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
- Adjusted "GetAll" extensions to utilise endingBefore as well as startingAfter.
  This currently only seemed to affect getting apiRequests.

## 1.46.1

- Added/updated new endpoints.
- Some new endpoints with new paging mechanism have not had "Get All" endpoints
  added until the inconsistencies between the models have been confirmed as
  intentional by Meraki API developers.

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

- Updated model detection to match Z3\* as an Appliance

## 1.37.13

- Added missing AlertTypes

## 1.37.9

- Updated GetModelType to handle more model strings

## 1.37.7

- Updated with missing model members

## 1.37.1

- Updated for v1.37 API changes

## 1.36.30

- Updated for some missing Properties and added CW to product type detection as
  a Wireless device

## 1.36.24

- Added detection of catalyst 9200 and 9300 models as a switch

## 1.36.20

- Fixed further inconsistencies with webhook and corrected all occurrences of
  WebHooks/webHook to lowercase h.

## 1.36.19

- Fixes for Webhooks. In some places, "WebHooks" has been changed to "Webhooks
  for consistency, which is a breaking change.

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

- RefitSettings CollectionFormat now set to CollectionFormat.Multi, default was
  CSV, this allows sending multiple values for the filters.

## 1.32.2

- Updates models to reflect changes on API v1.32. Some nullability updated.

## 1.31.51

- Thanks to @rlouch2 for the PR to fix the encoding of colons in MACs being set
  in a GET query.
- Thanks to @garlic17 for the PR to catch the typo in a datamember for cidr.

## 1.31.48

- Allow all properties on an SSID Update to be nullable to allow only setting
  certain properties.

## 1.31.46

- Added MerakiClient.ApiClientVersion to return the library version which
  returns similar to 1.31.46

## 1.31.31

- Removed unnecessary AliasAs attributes to improve code maintenance
- Added analysers to detect correct AliasAs usage

## 1.31.14

- Fixed bug with missing DataContract on DeviceRemovalRequest

## 1.31.8

- Updated for 1.31 API changes
- All query endpoints that provide lists now have "[]" after the parameter name
  to allow for multiple values to be passed in and work with the Meraki API.

## 1.30.23

- Fixed GetOrganizationDevicesStatusesAsync and GetNetworkSmDevicesAsync to use
  "[]" after the parameter names for lists to work.
- Updated log messages when retry fails to include the method and url.

## 1.30.15

- Added obsolete VmConcentrator to ProductType
- Made all device properties nullable
- Modified GeoLocation Lat/Long to be non nullable as they should either both be
  present or the GeoLocation should be null

## 1.30.9

- Added LastRequestUri to MerakiClient

## 1.30.3

- Fix for GetOrganizationApiRequestsOverviewResponseCodesByIntervalAsync
  breaking client creation

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

- Fixed
  <https://developer.cisco.com/meraki/api-latest/#!get-organization-wireless-devices-ethernet-statuses>
  for:
  - port to ports, permitting deserialization
  - renamed Speed to SpeedMbps
  - renamed IsConnectd to IsConnected

## v1.25.6

- Added
  <https://developer.cisco.com/meraki/api-latest/#!get-organization-wireless-devices-ethernet-statuses>
  as `MerakiClient.Wireless.Devices.OrganizationEthernetStatuses`

## v1.25.1

- Added appliance SSID endpoints -
  <https://developer.cisco.com/meraki/api-v1/#!get-network-appliance-ssids>

## v1.24.19

- Modified network settings local page authentication to allow setting password.

## v1.24.1

- Changed all floats to double.
- Modified several models to be nullable where the response model is also used
  in requests to allow only setting certain properties.
- Added missing endpoints
- Updated existing models
- No change made yet to Client to support new documentation "Platform" layout.
  Intention is to add "Platform" at the root level with duplicate references to
  sections and interfaces to allow easily finding calls matching documentation.

## v1.23.9

- Updates for Meraki API v1.23

## v1.22.19

- Renamed AuthMode enum entries
  - \_8021xmeraki to Auth8021xmeraki
  - \_8021xradius to Auth8021xradius

- Renamed DhcpLeaseTime enum entries
  - \_30minutes to Duration30Minutes
  - \_1hour to Duration1Hour
  - \_4hours to Duration4Hours
  - \_12hours to Duration12Hours
  - \_1day to Duration1Day
  - \_1week to Duration1Week

## v1.22.15

- Added JsonMissingMemberAction which will execute when
  Options.JsonMissingMemberHandling is set to something other than Ignore.

## v1.22.4

- Added Gateway to StaticRoute

## v1.22.3

- Changed AdaptivePolicyGroup CreatedAt and UpdatedAt to be DateTime
- Changed AdaptivePolicyPolicies to correct nullability. Changed timestamps to
  DateTime
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
- Added JsonMissingMemberResponseLogLevel to MerakiClientOptions. When set to
  something other than None, this will log the actual JSON response from the API
  when a member is missing from the response.
- Added "concentrator" to Wireless SSID VPN Settings.
- Added "alerts" to DHCP Server Policy.

## v1.19.78

- Updated the following method names to follow naming conventions:
  - `RemoveNetworkDeviceAsync` -> `RemoveNetworkDevicesAsync`
  - `GetNetworksWebhooksPayloadTemplatesAsync` ->
    `GetNetworkWebhooksPayloadTemplatesAsync`
  - `GetNetworkWebhooksPayloadTemplateAsync` ->
    `GetNetworkWebhooksPayloadTemplateAsync`
  - `UpdateNetworksWebhooksPayloadTemplatesAsync` ->
    `UpdateNetworkWebhooksPayloadTemplateAsync`
  - `GetNetworkSsidL3FirewallRulesAsync` ->
    `GetNetworkWirelessSsidFirewallL3FirewallRulesAsync`
  - `UpdateNetworkSsidL3FirewallRulesAsync` ->
    `UpdateNetworkWirelessSsidFirewallL3FirewallRulesAsync`
  - `GetNetworkCellularGatewaySettingsUplinkAsync` ->
    `GetNetworkCellularGatewayUplinkAsync`
  - `UpdateNetworkCellularGatewaySettingsUplinkAsync` ->
    `UpdateNetworkCellularGatewayUplinkAsync`
  - `GetNetworkCellularGatewaySettingsSubnetPoolAsync` ->
    `GetNetworkCellularGatewaySubnetPoolAsync`
  - `UpdateNetworkCellularGatewaySettingsSubnetPoolAsync` ->
    `UpdateNetworkCellularGatewaySubnetPoolAsync`
  - `UpdateOrganizationAdaptivePolicyGroup`->
    `UpdateOrganizationAdaptivePolicyGroupAsync`
- Changed other function names to match documentation operation ids.
- Modified models to correct ApiAccess attributes.

## v1.19.60

- Fixed NetworkTraffic.Port type from int to object, as the API can return
  either an int or a string
- Fixed Client.Manufacturer type from string to string?
- Fixed Client.Switchport type from string to string?
- BREAKING CHANGE: OrganizationDeviceStatus.productType renamed to ProductType
  (capitalized)
- Correctly implemented Wifi class (previously no fields were correctly mapping)

## v1.19.52

- Added LinkNegotiationCapabilities to SwitchProfilePorts and Switchport.
