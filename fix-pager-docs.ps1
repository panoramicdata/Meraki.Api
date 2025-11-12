# Fix remaining MerakiClientPager documentation
$file = "Meraki.Api\MerakiClientPager.cs"
$content = Get-Content $file -Raw

# Add doc before the third GetAllAsync (line ~132)
$pattern1 = '(?s)(return allEntries;\s+}\s+)(public static async Task<List<T>> GetAllAsync<T>\(\s+#pragma warning disable CS3001.*?\s+Func<string\?, string\?, CancellationToken, Task<ApiResponse<List<T>>>> pageFactoryAsync,)'
$replacement1 = @'
$1
	/// <summary>
	/// Retrieves all items using pagination with ApiResponse wrapper
	/// </summary>
	/// <typeparam name="T">The type of items to retrieve</typeparam>
	/// <param name="pageFactoryAsync">The function to call for each page of results</param>
	/// <param name="cancellationToken">The cancellation token</param>
	/// <returns>A list of all items</returns>
	$2
'@
$content = $content -replace $pattern1, $replacement1

# Add doc before the fourth GetAllAsync (line ~193)
$pattern2 = '(?s)(return allEntries;\s+}\s+)(public static async Task<List<T>> GetAllAsync<T>\(\s+#pragma warning disable CS3001.*?\s+Func<string\?, string\?, string\?, string\?, double\?, CancellationToken, Task<ApiResponse<List<T>>>> pageFactoryAsync,)'
$replacement2 = @'
$1
	/// <summary>
	/// Retrieves all items using pagination with time-based parameters
	/// </summary>
	/// <typeparam name="T">The type of items to retrieve</typeparam>
	/// <param name="pageFactoryAsync">The function to call for each page of results</param>
	/// <param name="t0">The beginning of the timespan</param>
	/// <param name="t1">The end of the timespan</param>
	/// <param name="timeSpan">The timespan duration</param>
	/// <param name="cancellationToken">The cancellation token</param>
	/// <returns>A list of all items</returns>
	$2
'@
$content = $content -replace $pattern2, $replacement2

# Add doc before the fifth GetAllAsync (line ~257)
$pattern3 = '(?s)(return allEntries;\s+}\s+)(public static async Task<List<T>> GetAllAsync<T>\(\s+#pragma warning disable CS3001.*?\s+Func<int\?, string\?, string\?, CancellationToken, Task<ApiResponse<List<T>>>> pageFactoryAsync,)'
$replacement3 = @'
$1
	/// <summary>
	/// Retrieves all items using pagination with per-page count and ApiResponse wrapper
	/// </summary>
	/// <typeparam name="T">The type of items to retrieve</typeparam>
	/// <param name="pageFactoryAsync">The function to call for each page of results</param>
	/// <param name="perPage">The number of items per page</param>
	/// <param name="cancellationToken">The cancellation token</param>
	/// <returns>A list of all items</returns>
	$2
'@
$content = $content -replace $pattern3, $replacement3

Set-Content -Path $file -Value $content -NoNewline
Write-Host "Fixed MerakiClientPager documentation" -ForegroundColor Green
