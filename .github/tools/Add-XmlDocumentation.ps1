<#
.SYNOPSIS
    Adds XML documentation comments to C# files using the Meraki OpenAPI specification.

.DESCRIPTION
    This script downloads the Meraki OpenAPI specification and uses it to add or update
    XML documentation comments (///) for C# classes, properties, and methods that are
    missing documentation, thereby resolving CS1591 warnings.

.PARAMETER SourcePath
    The root path containing the C# source files to update. Defaults to the Meraki.Api directory.

.PARAMETER FilePath
    Process only a specific file instead of scanning all files.

.PARAMETER OpenApiUrl
    The URL to the Meraki OpenAPI specification. Defaults to the v1-beta spec.

.PARAMETER PreviewOnly
    Shows what would be changed without actually making changes.

.EXAMPLE
    .\Add-XmlDocumentation.ps1
    
.EXAMPLE
    .\Add-XmlDocumentation.ps1 -FilePath "Meraki.Api\Data\Device.cs" -PreviewOnly

.EXAMPLE
    .\Add-XmlDocumentation.ps1 -SourcePath "C:\MyProject\Meraki.Api" -PreviewOnly

.NOTES
    Author: Panoramic Data
    This script helps maintain XML documentation for the Meraki.Api library
    by extracting descriptions from the official Meraki OpenAPI specification.
    
    OpenAPI Spec: https://raw.githubusercontent.com/meraki/openapi/refs/heads/v1-beta/openapi/spec3.json
#>

[CmdletBinding()]
param(
    [Parameter()]
    [string]$SourcePath = ".\Meraki.Api",
    
    [Parameter()]
    [string]$FilePath = "",
    
    [Parameter()]
    [string]$OpenApiUrl = "https://raw.githubusercontent.com/meraki/openapi/refs/heads/v1-beta/openapi/spec3.json",
    
    [Parameter()]
    [switch]$PreviewOnly
)

$ErrorActionPreference = 'Stop'

function Write-ColorOutput {
    param(
        [Parameter(Mandatory)]
        [string]$Message,
        
        [Parameter()]
        [ConsoleColor]$ForegroundColor = [ConsoleColor]::White
    )
    
    $previousColor = $host.UI.RawUI.ForegroundColor
    $host.UI.RawUI.ForegroundColor = $ForegroundColor
    Write-Output $Message
    $host.UI.RawUI.ForegroundColor = $previousColor
}

function Get-OpenApiSpec {
    param([string]$Url)
    
    Write-ColorOutput "Downloading OpenAPI specification from: $Url" -ForegroundColor Cyan
    
    try {
        $response = Invoke-RestMethod -Uri $Url -Method Get -ContentType "application/json"
        Write-ColorOutput "Successfully downloaded OpenAPI specification (version: $($response.info.version))" -ForegroundColor Green
        return $response
    }
    catch {
        Write-ColorOutput "Failed to download OpenAPI specification: $_" -ForegroundColor Red
        throw
    }
}

function Get-PropertyDescription {
    param(
        [Parameter(Mandatory)]
        $OpenApiSpec,
        
        [Parameter(Mandatory)]
        [string]$PropertyName,
        
        [Parameter()]
        [string]$ProjectPath = ".\Meraki.Api",
        
        [Parameter()]
        [string]$FilePath = ""
    )
    
    # Try to extract context from the file path (e.g., Switch, Wireless, Appliance, Camera)
    $productContext = $null
    if ($FilePath) {
        if ($FilePath -match '\\(Switch|Wireless|Appliance|Camera|Sensor|CellularGateway|Sm)\\') {
            $productContext = $Matches[1].ToLower()
        }
    }
    
    # First try to find corresponding Refit interface and extract its documentation
    try {
        # If PropertyName is already an interface name (starts with I), use it as-is
        # Otherwise, prepend I to make it an interface name
        $interfaceName = if ($PropertyName -match '^I[A-Z]') {
            $PropertyName
        } else {
            "I$PropertyName"
        }
        
        $interfaceFiles = Get-ChildItem -Path $ProjectPath -Filter "$interfaceName.cs" -Recurse -ErrorAction SilentlyContinue
        
        if ($interfaceFiles) {
            $interfaceFile = $interfaceFiles[0]
            $content = Get-Content -Path $interfaceFile.FullName

            # Find the first method summary (appears after interface declaration)
            $foundInterfaceDeclaration = $false
            
            for ($i = 0; $i -lt $content.Count; $i++) {
                $line = $content[$i]
                
                # Detect interface declaration (may have leading whitespace)
                if ($line -match '^\s*public interface') {
                    $foundInterfaceDeclaration = $true
                    continue
                }
                
                # Only look for summaries after we've found the interface declaration
                if ($foundInterfaceDeclaration -and $line -match '^\s*/// <summary>') {
                    # Check if this is followed by a description line
                    if ($i + 1 -lt $content.Count -and $content[$i + 1] -match '^\s*/// (.+)$') {
                        $description = $Matches[1].Trim()
                        
                        # Make sure this isn't an interface-level summary
                        # (interface summary usually says "Represents a collection" or similar)
                        if ($description -notmatch '^Represents a collection') {
                            return $description
                        }
                    }
                }
            }
        }
    }
    catch {
        # Silently continue if interface lookup fails
    }
    
    # Try to find description in OpenAPI spec paths with context-aware matching
    $bestMatch = $null
    $bestMatchScore = 0
    
    foreach ($path in $OpenApiSpec.paths.PSObject.Properties) {
        foreach ($method in $path.Value.PSObject.Properties) {
            $operation = $method.Value
            
            # Skip if not an operation (could be parameters, etc.)
            if (-not $operation.operationId) {
                continue
            }
            
            # Check if operation matches the property name
            if ($operation.operationId -match $PropertyName) {
                $score = 1
                
                # Boost score if product context matches the path
                if ($productContext -and $path.Name -match "/$productContext/") {
                    $score += 10
                }
                
                # Boost score for exact property name match at word boundaries
                # Pattern 1: Ends with PropertyName (e.g., "getIdentitiesMe")
                if ($operation.operationId -match "$PropertyName`$") {
                    $score += 5
                }
                # Pattern 2: PropertyName followed by capital letter (e.g., "getMeApiKeys")
                elseif ($operation.operationId -match "$PropertyName[A-Z]") {
                    $score += 3
                }
                # Pattern 3: PropertyName with word boundaries (catches most cases)
                elseif ($operation.operationId -match "\b$PropertyName\b") {
                    $score += 4
                }
                
                # Prefer Get/List operations over others
                if ($operation.operationId -match '^(get|list)') {
                    $score += 2
                }
                
                # Update best match if this score is higher
                if ($score > $bestMatchScore) {
                    $bestMatchScore = $score
                    $description = $operation.description
                    if (-not $description) {
                        $description = $operation.summary
                    }
                    if ($description) {
                        $bestMatch = $description.Trim()
                    }
                }
            }
        }
    }
    
    if ($bestMatch) {
        return $bestMatch
    }
    
    # Try to find the property in OpenAPI schemas (if they exist)
    if ($OpenApiSpec.components -and $OpenApiSpec.components.schemas) {
        foreach ($schemaName in $OpenApiSpec.components.schemas.PSObject.Properties.Name) {
            $schema = $OpenApiSpec.components.schemas.$schemaName
            
            if ($schema.properties -and $schema.properties.$PropertyName) {
                $property = $schema.properties.$PropertyName
                
                if ($property.description) {
                    return $property.description.Trim()
                }
            }
            
            # Also check allOf, anyOf, oneOf constructs
            if ($schema.allOf) {
                foreach ($item in $schema.allOf) {
                    if ($item.properties -and $item.properties.$PropertyName -and $item.properties.$PropertyName.description) {
                        return $item.properties.$PropertyName.description.Trim()
                    }
                }
            }
        }
    }
    
    return $null
}

function ConvertTo-SafeXmlComment {
    param(
        [Parameter(Mandatory)]
        [string]$Text
    )
    
    if ([string]::IsNullOrWhiteSpace($Text)) {
        return ""
    }
    
    # Clean up whitespace
    $cleaned = $Text.Trim() -replace '\r\n', ' ' -replace '\n', ' ' -replace '\s+', ' '
    
    # Escape XML special characters
    $cleaned = $cleaned -replace '&', '&amp;' -replace '<', '&lt;' -replace '>', '&gt;' -replace '"', '&quot;'
    
    return $cleaned
}

function ConvertTo-EnglishDescription {
    param(
        [Parameter(Mandatory)]
        [string]$Name,
        
        [Parameter()]
        [string]$MemberType = "property"
    )
    
    # Remove common suffixes
    $cleanName = $Name -replace 'Section$', '' -replace 'Request$', '' -replace 'Response$', '' -replace 'Config$', '' -replace 'Settings$', ''
    
    # Insert spaces before capital letters (de-camel-case)
    $spaced = $cleanName -creplace '([a-z])([A-Z])', '$1 $2'
    $spaced = $spaced -creplace '([A-Z]+)([A-Z][a-z])', '$1 $2'
    
    # Convert to sentence case
    $words = $spaced -split '\s+'
    
    # Create appropriate description based on member type
    switch ($MemberType.ToLower()) {
        "class" {
            # For section classes
            if ($Name -match 'Section$') {
                return "Provides access to $($spaced.ToLower()) API endpoints"
            }
            # For request/response classes
            elseif ($Name -match '(Request|Response)$') {
                return $spaced
            }
            # For general classes
            else {
                return $spaced
            }
        }
        "interface" {
            return $spaced
        }
        "property" {
            # Check if it looks like a boolean
            if ($Name -match '^(Is|Has|Can|Should|Enable|Disable)') {
                # Extract the condition part after the prefix
                $condition = $Name -replace '^(Is|Has|Can|Should)', ''
                $conditionSpaced = $condition -creplace '([a-z])([A-Z])', '$1 $2'
                $conditionSpaced = $conditionSpaced -creplace '([A-Z]+)([A-Z][a-z])', '$1 $2'
                
                # Create more natural phrasing based on prefix
                if ($Name -match '^Is') {
                    return "Whether $($conditionSpaced.ToLower())"
                }
                elseif ($Name -match '^Has') {
                    return "Whether it has $($conditionSpaced.ToLower())"
                }
                elseif ($Name -match '^Can') {
                    return "Whether it can $($conditionSpaced.ToLower())"
                }
                elseif ($Name -match '^Should') {
                    return "Whether it should $($conditionSpaced.ToLower())"
                }
                # For Enable/Disable without a suffix, just use "whether" + the word
                elseif ($Name -match '^(Enabled|Disabled)$') {
                    return "Whether $($spaced.ToLower())"
                }
                # For Enable/Disable with a suffix (e.g., EnableLogging), use "whether to"
                elseif ($Name -match '^(Enable|Disable)') {
                    return "Whether to $($spaced.ToLower())"
                }
            }
            # Check if it ends with common collection indicators
            elseif ($Name -match 's$' -and $Name -notmatch 'Status$|Address$') {
                return "Gets the $($spaced.ToLower())"
            }
            # Default for properties
            else {
                return "Gets the $($spaced.ToLower())"
            }
        }
        "method" {
            # Remove Async suffix for description
            $methodName = $Name -replace 'Async$', ''
            $methodSpaced = $methodName -creplace '([a-z])([A-Z])', '$1 $2'
            $methodSpaced = $methodSpaced -creplace '([A-Z]+)([A-Z][a-z])', '$1 $2'
            
            # Determine verb
            if ($methodName -match '^Get') {
                $action = $methodSpaced -replace '^Get\s+', 'Gets the '
                return $action.ToLower()
            }
            elseif ($methodName -match '^Create') {
                $action = $methodSpaced -replace '^Create\s+', 'Creates a new '
                return $action.ToLower()
            }
            elseif ($methodName -match '^Update') {
                $action = $methodSpaced -replace '^Update\s+', 'Updates the '
                return $action.ToLower()
            }
            elseif ($methodName -match '^Delete') {
                $action = $methodSpaced -replace '^Delete\s+', 'Deletes the '
                return $action.ToLower()
            }
            else {
                return $methodSpaced
            }
        }
        default {
            return $spaced
        }
    }
}

function Get-DataMemberName {
    param(
        [Parameter(Mandatory)]
        [AllowEmptyCollection()]
        [string[]]$PreviousLines
    )
    
    # Look for [DataMember(Name = "propertyName")] attribute
    if ($PreviousLines.Count -eq 0) {
        return $null
    }
    
    foreach ($line in $PreviousLines) {
        if ($line -match '\[DataMember\(Name\s*=\s*"([^"]+)"\)') {
            return $Matches[1]
        }
    }
    
    return $null
}

function Add-MissingXmlDoc {
    param(
        [Parameter(Mandatory)]
        [string]$FilePath,
        
        [Parameter(Mandatory)]
        $OpenApiSpec,
        
        [Parameter()]
        [switch]$PreviewOnly
    )
    
    Write-Verbose "Processing file: $FilePath"
    
    $lines = Get-Content -Path $FilePath
    $modified = $false
    $newLines = New-Object System.Collections.ArrayList
    $changesCount = 0
    
    for ($i = 0; $i -lt $lines.Count; $i++) {
        $line = $lines[$i]
        
        # Skip if this line already has XML documentation
        if ($i -gt 0 -and $lines[$i - 1] -match '^\s*///') {
            [void]$newLines.Add($line)
            continue
        }
        
        # Check for public class, interface, enum, struct
        if ($line -match '^\s*public\s+(class|interface|enum|struct)(\s+\w+)?\s+(\w+)') {
            $memberType = $Matches[1]
            $memberName = $Matches[3]
            
            # Check if previous non-empty line has XML doc or is an attribute
            $hasDocs = $false
            $hasAttribute = $false
            $firstAttributeLineIndex = -1
            
            # Look backwards to find attributes and check for existing docs
            for ($j = $i - 1; $j -ge 0; $j--) {
                if ($lines[$j] -match '^\s*///') {
                    $hasDocs = $true
                    break
                }
                if ($lines[$j] -match '^\s*\[') {
                    $hasAttribute = $true
                    $firstAttributeLineIndex = $j
                    continue
                }
                if ($lines[$j] -notmatch '^\s*$' -and $lines[$j] -notmatch '^\s*[{}]\s*$') {
                    break
                }
            }
            
            if (-not $hasDocs) {
                Write-ColorOutput "  [Line $($i + 1)] Adding docs for $memberType '$memberName'" -ForegroundColor Cyan
                
                $indent = if ($line -match '^(\s+)') { $Matches[1] } else { "" }
                $englishDescription = ConvertTo-EnglishDescription -Name $memberName -MemberType $memberType
                
                # If there are attributes, insert docs BEFORE the first attribute
                if ($hasAttribute -and $firstAttributeLineIndex -ge 0) {
                    # Insert at the position of the first attribute
                    $newLines.Insert($firstAttributeLineIndex, "$indent/// </summary>")
                    $newLines.Insert($firstAttributeLineIndex, "$indent/// $englishDescription")
                    $newLines.Insert($firstAttributeLineIndex, "$indent/// <summary>")
                }
                else {
                    # No attributes, add docs right before the class declaration
                    [void]$newLines.Add("$indent/// <summary>")
                    [void]$newLines.Add("$indent/// $englishDescription")
                    [void]$newLines.Add("$indent/// </summary>")
                }
                
                $modified = $true
                $changesCount++
            }
        }
        # Check for public properties
        elseif ($line -match '^\s*public\s+(\w+(<[^>]+>)?(\?)?)\s+(\w+)\s*\{') {
            $propertyType = $Matches[1]
            $propertyName = $Matches[4]
            
            # Check previous lines for docs
            $hasDocs = $false
            $hasAttribute = $false
            $previousNonEmptyLines = @()
            
            for ($j = $i - 1; $j -ge 0 -and $j -ge $i - 10; $j--) {
                if ($lines[$j] -match '^\s*///') {
                    $hasDocs = $true
                    break
                }
                if ($lines[$j] -match '^\s*\[') {
                    $hasAttribute = $true
                    $previousNonEmptyLines += $lines[$j]
                    continue
                }
                # If we hit a non-empty, non-attribute line, break
                # This prevents scanning into previous properties/methods
                if ($lines[$j] -notmatch '^\s*$' -and $lines[$j] -notmatch '^\s*[{}]\s*$') {
                    break
                }
            }
            
            if (-not $hasDocs) {
                # Try to get the DataMember name
                $dataMemberName = Get-DataMemberName -PreviousLines $previousNonEmptyLines
                
                # Determine project root from file path
                $fileDir = Split-Path -Path $FilePath -Parent
                $projectRoot = $fileDir
                while ($projectRoot -and -not (Test-Path (Join-Path $projectRoot "*.csproj"))) {
                    $projectRoot = Split-Path -Path $projectRoot -Parent
                }
                if (-not $projectRoot) {
                    $projectRoot = $fileDir
                }
                
                # Try to find description from OpenAPI spec or interface
                # Use property type (e.g., ISwitchProfiles) for interface matching
                # Use property name or DataMember name for OpenAPI lookup
                $description = $null
                
                # First try with property type (for interface matching)
                $description = Get-PropertyDescription -OpenApiSpec $OpenApiSpec -PropertyName $propertyType -ProjectPath $projectRoot -FilePath $FilePath
                
                # If not found and we have a DataMember name, try that
                if (-not $description -and $dataMemberName) {
                    $description = Get-PropertyDescription -OpenApiSpec $OpenApiSpec -PropertyName $dataMemberName -ProjectPath $projectRoot -FilePath $FilePath
                }
                
                # If still not found, try the property name itself
                if (-not $description) {
                    $description = Get-PropertyDescription -OpenApiSpec $OpenApiSpec -PropertyName $propertyName -ProjectPath $projectRoot -FilePath $FilePath
                }
                
                # If no OpenAPI/interface description, generate English description
                if (-not $description) {
                    $description = ConvertTo-EnglishDescription -Name $propertyName -MemberType "property"
                }
                
                if ($description) {
                    $safeDescription = ConvertTo-SafeXmlComment -Text $description
                    Write-ColorOutput "  [Line $($i + 1)] Adding docs for property '$propertyName': $safeDescription" -ForegroundColor Green
                }
                else {
                    Write-ColorOutput "  [Line $($i + 1)] Adding docs for property '$propertyName' (no description generated)" -ForegroundColor Yellow
                }
                
                $indent = if ($line -match '^(\s+)') { $Matches[1] } else { "`t" }
                
                # Find the first attribute line (if any) to insert docs before it
                $firstAttributeIndex = -1
                for ($k = $i - 1; $k -ge 0 -and $k -ge $i - 10; $k--) {
                    if ($lines[$k] -match '^\s*\[') {
                        $firstAttributeIndex = $k
                    }
                    elseif ($lines[$k] -notmatch '^\s*$') {
                        break
                    }
                }
                
                # If there are attributes, insert BEFORE the first one
                if ($firstAttributeIndex -ge 0) {
                    # Calculate the position in newLines array
                    # We need to insert at the corresponding position
                    $insertPosition = $newLines.Count - ($i - $firstAttributeIndex)
                    
                    # No blank line when attributes are present
                    $newLines.Insert($insertPosition, "$indent/// </summary>")
                    $newLines.Insert($insertPosition, "$indent/// $safeDescription")
                    $newLines.Insert($insertPosition, "$indent/// <summary>")
                }
                else {
                    # No attributes, add right before property with blank line after
                    [void]$newLines.Add("$indent/// <summary>")
                    [void]$newLines.Add("$indent/// $safeDescription")
                    [void]$newLines.Add("$indent/// </summary>")
                    [void]$newLines.Add("")
                }
                
                $modified = $true
                $changesCount++
            }
        }
        # Check for public methods
        elseif ($line -match '^\s*public\s+(\w+(<[^>]+>)?(\?)?)\s+(\w+)\s*\(') {
            $returnType = $Matches[1]
            $methodName = $Matches[4]
            
            # Check previous lines for docs
            $hasDocs = $false
            
            for ($j = $i - 1; $j -ge 0; $j--) {
                if ($lines[$j] -match '^\s*///') {
                    $hasDocs = $true
                    break
                }
                if ($lines[$j] -match '^\s*\[') {
                    continue
                }
                if ($lines[$j] -notmatch '^\s*$' -and $lines[$j] -notmatch '^\s*[{}]\s*$') {
                    break
                }
            }
            
            if (-not $hasDocs) {
                $englishDescription = ConvertTo-EnglishDescription -Name $methodName -MemberType "method"
                Write-ColorOutput "  [Line $($i + 1)] Adding docs for method '$methodName': $englishDescription" -ForegroundColor Cyan
                
                $indent = if ($line -match '^(\s+)') { $Matches[1] } else { "`t" }
                [void]$newLines.Add("$indent/// <summary>")
                [void]$newLines.Add("$indent/// $englishDescription")
                [void]$newLines.Add("$indent/// </summary>")
                $modified = $true
                $changesCount++
            }
        }
        
        [void]$newLines.Add($line)
    }
    
    if ($modified) {
        Write-ColorOutput "`nTotal changes: $changesCount`n" -ForegroundColor White
        
        if ($PreviewOnly) {
            Write-ColorOutput "PREVIEW: Would update file (no changes made)" -ForegroundColor Yellow
        }
        else {
            Write-ColorOutput "Writing changes to file..." -ForegroundColor Green
            $newLines | Set-Content -Path $FilePath -Encoding UTF8
            Write-ColorOutput "File updated successfully!" -ForegroundColor Green
        }
        return $true
    }
    else {
        Write-ColorOutput "No changes needed - all members already have documentation" -ForegroundColor Green
    }
    
    return $false
}

# Main script execution
try {
    Write-ColorOutput "`n=== Meraki.Api XML Documentation Generator ===" -ForegroundColor Cyan
    Write-ColorOutput "This script adds XML documentation comments to resolve CS1591 warnings`n" -ForegroundColor Cyan
    
    if ($PreviewOnly) {
        Write-ColorOutput "PREVIEW MODE: No files will be modified`n" -ForegroundColor Yellow
    }
    
    # Download OpenAPI specification
    $openApiSpec = Get-OpenApiSpec -Url $OpenApiUrl
    
    # Process single file or all files
    if ($FilePath) {
        # Single file mode
        $resolvedFile = Resolve-Path -Path $FilePath -ErrorAction SilentlyContinue
        if (-not $resolvedFile) {
            Write-ColorOutput "File not found: $FilePath" -ForegroundColor Red
            exit 1
        }
        
        Write-ColorOutput "Processing single file: $resolvedFile`n" -ForegroundColor White
        
        $updated = Add-MissingXmlDoc -FilePath $resolvedFile -OpenApiSpec $openApiSpec -PreviewOnly:$PreviewOnly
        
        Write-ColorOutput "`n=== Complete ===" -ForegroundColor Cyan
    }
    else {
        # Bulk mode
        $resolvedPath = Resolve-Path -Path $SourcePath -ErrorAction SilentlyContinue
        if (-not $resolvedPath) {
            Write-ColorOutput "Source path not found: $SourcePath" -ForegroundColor Red
            exit 1
        }
        
        Write-ColorOutput "Source path: $resolvedPath" -ForegroundColor White
        
        # Find all C# files
        $csFiles = Get-ChildItem -Path $resolvedPath -Filter "*.cs" -Recurse | 
            Where-Object { 
                $_.FullName -notlike "*\obj\*" -and 
                $_.FullName -notlike "*\bin\*" -and
                $_.FullName -notlike "*.g.cs" -and
                $_.FullName -notlike "*\generated\*"
            }
        
        Write-ColorOutput "`nFound $($csFiles.Count) C# files to process`n" -ForegroundColor White
        
        $updatedCount = 0
        
        foreach ($file in $csFiles) {
            $updated = Add-MissingXmlDoc -FilePath $file.FullName -OpenApiSpec $openApiSpec -PreviewOnly:$PreviewOnly
            if ($updated) {
                $updatedCount++
            }
        }
        
        Write-ColorOutput "`n=== Summary ===" -ForegroundColor Cyan
        if ($PreviewOnly) {
            Write-ColorOutput "Would update $updatedCount file(s)" -ForegroundColor Yellow
            Write-ColorOutput "`nRun without -PreviewOnly to apply changes" -ForegroundColor Yellow
        }
        else {
            Write-ColorOutput "Updated $updatedCount file(s)" -ForegroundColor Green
        }
        Write-ColorOutput "Complete!`n" -ForegroundColor Green
    }
}
catch {
    Write-ColorOutput "`nError: $_" -ForegroundColor Red
    Write-ColorOutput $_.ScriptStackTrace -ForegroundColor Red
    exit 1
}
