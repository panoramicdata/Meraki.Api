// This file is used by Code Analysis to maintain SuppressMessage
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given
// a specific target and scoped to a namespace, type, member, etc.

using System.Diagnostics.CodeAnalysis;

[assembly: CLSCompliant(true)]

[assembly: SuppressMessage(
	"Naming",
	"CA1707:Identifiers should not contain underscores",
	Justification = "Useful for unit tests",
	Scope = "namespaceanddescendants",
	Target = "~N:Meraki.Api.Test"
)]
[assembly: SuppressMessage(
	"Reliability",
	"CA2007:Consider calling ConfigureAwait on the awaited task",
	Justification = "Fine for unit tests",
	Scope = "namespaceanddescendants",
	Target = "~N:Meraki.Api.Test"
)]
[assembly: SuppressMessage(
	"Design",
	"CA1031:Do not catch general exception types",
	Justification = "Fine for unit tests",
	Scope = "namespaceanddescendants",
	Target = "~N:Meraki.Api.Test"
)]
[assembly: SuppressMessage(
	"Maintainability",
	"CA1515:Consider making public types internal",
	Justification = "This class needs to be public due to inheritance",
	Scope = "type",
	Target = "~T:Meraki.Api.Test.MerakiClientTest")]
