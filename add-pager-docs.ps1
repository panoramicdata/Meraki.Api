# Add documentation to MerakiClientPager GetAllAsync methods
$file = "Meraki.Api\MerakiClientPager.cs"
$content = Get-Content $file -Raw

# Replace each GetAllAsync method with documented version
$content = $content -replace '(?m)^\s*public async Task<List<T>> GetAllAsync<T>\(\r?\n\s*Func<int, string\?, string\?, CancellationToken, Task<List<T>>> getAllFunc',
@'
	/// <summary>
	/// Retrieves all items using pagination with a per-page count parameter
	/// </summary>
	/// <typeparam name="T">The type of items to retrieve</typeparam>
	/// <param name="getAllFunc">The function to call for each page of results</param>
'@

$content = $content -replace '(?m)^\s*public async Task<List<T>> GetAllAsync<T>\(\r?\n\s*Func<string\?, string\?, CancellationToken, Task<List<T>>> getAllFunc',
@'
	/// <summary>
	/// Retrieves all items using pagination with startingAfter/endingBefore parameters
	/// </summary>
	/// <typeparam name="T">The type of items to retrieve</typeparam>
	/// <param name="getAllFunc">The function to call for each page of results</param>
'@

$content = $content -replace '(?m)^\s*public static async Task<List<T>> GetAllAsync<T>\(\r?\n\s*this MerakiClient merakiClient,\r?\n\s*Func<string\?, string\?, CancellationToken, Task<ApiResponse<List<T>>>> getAllFunc',
@'
	/// <summary>
	/// Retrieves all items using pagination with ApiResponse wrapper
	/// </summary>
	/// <typeparam name="T">The type of items to retrieve</typeparam>
	/// <param name="merakiClient">The Meraki client instance</param>
	/// <param name="getAllFunc">The function to call for each page of results</param>
'@

$content = $content -replace '(?m)^\s*public static async Task<List<T>> GetAllAsync<T>\(\r?\n\s*this MerakiClient merakiClient,\r?\n\s*Func<string\?, string\?, string\?, string\?, double\?, CancellationToken, Task<ApiResponse<List<T>>>> getAllFunc',
@'
	/// <summary>
	/// Retrieves all items using pagination with time-based parameters
	/// </summary>
	/// <typeparam name="T">The type of items to retrieve</typeparam>
	/// <param name="merakiClient">The Meraki client instance</param>
	/// <param name="getAllFunc">The function to call for each page of results</param>
'@

$content = $content -replace '(?m)^\s*public static async Task<List<T>> GetAllAsync<T>\(\r?\n\s*this MerakiClient merakiClient,\r?\n\s*Func<int\?, string\?, string\?, CancellationToken, Task<ApiResponse<List<T>>>> getAllFunc',
@'
	/// <summary>
	/// Retrieves all items using pagination with per-page count and ApiResponse wrapper
	/// </summary>
	/// <typeparam name="T">The type of items to retrieve</typeparam>
	/// <param name="merakiClient">The Meraki client instance</param>
	/// <param name="getAllFunc">The function to call for each page of results</param>
'@

Set-Content -Path $file -Value $content -NoNewline
Write-Host "Added documentation to MerakiClientPager" -ForegroundColor Green
