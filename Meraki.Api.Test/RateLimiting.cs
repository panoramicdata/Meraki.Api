using FluentAssertions;
using Meraki.Api.Data;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Xunit;

namespace Meraki.Api.Test
{
	public class RateLimiting : MerakiClientTest
	{
		[Fact]
		public async void GetAll_Succeeds()
		{
			var stopwatch = new Stopwatch();
			var timerList = new List<TimeSpan?>();
			foreach (var _ in Enumerable.Range(0, 10000))
			{
				try
				{
					stopwatch.Restart();
					var result = await MerakiClient
					.Organizations
					.GetAsync(Configuration.TestOrganizationId)
					.ConfigureAwait(false);
					result.Should().BeOfType<Organization>();
					timerList.Add(stopwatch.Elapsed);
				}
				catch
				{
					timerList.Add(null);
				}
			}
			var failedCallCount = timerList.Count(t => t is null);
			failedCallCount.Should().Be(0);
		}
	}
}
