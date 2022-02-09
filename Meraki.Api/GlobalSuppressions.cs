// This file is used by Code Analysis to maintain SuppressMessage
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given
// a specific target and scoped to a namespace, type, member, etc.

using System.Diagnostics.CodeAnalysis;

[assembly: CLSCompliant(true)]

[assembly: SuppressMessage(
	"Performance", "CA1848:Use the LoggerMessage delegates",
	Justification = "TODO - remove this suppression.",
	Scope = "namespaceanddescendants",
	Target = "~N:Meraki.Api.Data")
]
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
