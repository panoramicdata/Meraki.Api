// This file is used by Code Analysis to maintain SuppressMessage
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given
// a specific target and scoped to a namespace, type, member, etc.

using System.Diagnostics.CodeAnalysis;

[assembly: SuppressMessage(
	 "Design",
	 "CA1056:Uri properties should not be strings",
	 Justification = "Uri would not deserilize properly.",
	 Scope = "namespaceanddescendants",
	 Target = "~N:Meraki.Api.Data")]

[assembly: SuppressMessage(
	 "Style",
	 "IDE1006:Naming Styles",
	 Justification = "This can't be right!",
	 Scope = "namespaceanddescendants",
	 Target = "~N:Meraki.Api.Data")]

[assembly: SuppressMessage(
	 "Globalization",
	 "CA1303:Do not pass literals as localized parameters",
	 Justification = "Not localising.",
	 Scope = "member",
	 Target = "~M:Meraki.Api.MerakiClientOptions.Validate")]

[assembly: SuppressMessage(
	 "Design",
	 "CA1054:Uri parameters should not be strings",
	 Justification = "Uri would not deserialize properly.",
	 Scope = "member",
	 Target = "~M:Meraki.Api.Interfaces.IWebhookLogs.GetOrganizationWebhookLogs(System.String,System.String,System.String,System.Nullable{System.Double},System.Nullable{System.Int32},System.String,System.String,System.String)~System.Threading.Tasks.Task{System.Object}")]
[assembly: SuppressMessage("Naming", "CA1707:Identifiers should not contain underscores", Justification = "<Pending>", Scope = "member", Target = "~P:Meraki.Api.Data.Destination._Default")]
[assembly: SuppressMessage("Naming", "CA1707:Identifiers should not contain underscores", Justification = "<Pending>", Scope = "type", Target = "~T:Meraki.Api.Data.DhcpLeaseTime")]
[assembly: SuppressMessage("Naming", "CA1720:Identifier contains type name", Justification = "<Pending>", Scope = "member", Target = "~F:Meraki.Api.Data.DhcpOptionType.Integer")]
[assembly: SuppressMessage("Usage", "CA2227:Collection properties should be read only", Justification = "<Pending>", Scope = "member", Target = "~P:Meraki.Api.Data.TrafficUplinkPreferences.TrafficFilters")]
[assembly: SuppressMessage("Naming", "CA1716:Identifiers should not match keywords", Justification = "<Pending>", Scope = "type", Target = "~T:Meraki.Api.Data.Operator")]
