﻿namespace Meraki.Api.Sections.General.Networks;

public class NetworksSensorSection
{
	public NetworksSensorAlertsSection Alerts { get; internal set; } = new();

	public INetworksSensorSchedules Schedules { get; internal set; } = null!;
}
