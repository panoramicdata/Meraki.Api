﻿using FluentAssertions;
using Meraki.Api.Data;
using PanoramicData.SheetMagic;
using Refit;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using Xunit;

namespace Meraki.Api.Test
{
	public class RateLimiting : MerakiClientTest
	{
		[Fact]
		public async void GetAll_Succeeds()
		{
			var stopwatch = new Stopwatch();
			var timerList = new List<QueryResult>();
			foreach (var _ in Enumerable.Range(0, 1000))
			{
				var queryResult = new QueryResult();
				try
				{
					stopwatch.Restart();
					var result = await MerakiClient
					.Organizations
					.GetAsync(Configuration.TestOrganizationId)
					.ConfigureAwait(false);
					result.Should().BeOfType<Organization>();
				}
				catch (ApiException apiException)
				{
					queryResult.StatusCode = apiException.StatusCode;
					queryResult.ExceptionMessage = apiException.Message;
				}
				catch (Exception exception)
				{
					queryResult.ExceptionMessage = exception.Message;
				}
				finally
				{
					queryResult.DurationMs = stopwatch.ElapsedMilliseconds;
					timerList.Add(queryResult);
				}
			}
			var fileInfo = new FileInfo(Path.GetTempFileName() + ".xlsx");
			using var magicSpreadsheet = new MagicSpreadsheet(fileInfo);
			magicSpreadsheet.AddSheet(timerList);
			magicSpreadsheet.Save();
		}
	}

	public class QueryResult
	{
		public long DurationMs { get; set; }

		public HttpStatusCode? StatusCode { get; set; }

		public string? ExceptionMessage { get; set; }
	}
}
