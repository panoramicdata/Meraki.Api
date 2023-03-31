# From an elevated PowerShell prompt:
# Install-Package Meraki.Api -ProviderName NuGet
# ./Example.ps1

Import-Module Microsoft.Extensions.Logging
Import-Module Microsoft.Extensions.Logging.Console
Import-Module Meraki.Api


function Wait-Task {
    param(
        [Parameter(Mandatory, ValueFromPipeline)]
        [System.Threading.Tasks.Task[]]$Task
    )

    Begin {
        $Tasks = @()
    }

    Process {
        $Tasks += $Task
    }

    End {
        While (-not [System.Threading.Tasks.Task]::WaitAll($Tasks, 200)) {}
        $Tasks.ForEach( { $_.GetAwaiter().GetResult() })
    }
}

Set-Alias -Name await -Value Wait-Task -Force

$factory = [Microsoft.Extensions.Logging.LoggerFactory]::Create({
    param($builder)
    $builder.AddConsole()
})
$logger = $factory.CreateLogger('MyLogger')

$Options = New-Object Meraki.Api.MerakiClientOptions -Property @{ApiKey="XXX"; UserAgent = "MyApp/1.0 Me"}
$Client = New-Object -TypeName Meraki.Api.MerakiClient -ArgumentList $Options $logger

$Organizations = await $Client::Organizations.GetOrganizationsAsync([System.Threading.CancellationToken]::None)