[![](https://img.shields.io/nuget/v/soenneker.extensions.dictionaries.stringstring.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.extensions.dictionaries.stringstring/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.extensions.dictionaries.stringstring/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.extensions.dictionaries.stringstring/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.extensions.dictionaries.stringstring.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.extensions.dictionaries.stringstring/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.extensions.dictionaries.stringstring/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.extensions.dictionaries.stringstring/actions/workflows/codeql.yml)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.Extensions.Dictionaries.StringString
Extension methods for converting and transforming string-keyed, string-valued dictionaries while preserving important dictionary behavior such as key comparison.

## Installation

```bash
dotnet add package Soenneker.Extensions.Dictionaries.StringString
```

## Usage

```csharp
using Soenneker.Extensions.Dictionaries.StringString;

var source = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
{
    ["Region"] = "us-east"
};

Dictionary<string, object> values = source.ToObjectDictionary();
object region = values["region"]; // "us-east"
```

The result is a separate dictionary; changing it does not change the source. When the source is a concrete `Dictionary<string, string>`, its key comparer is preserved, which is why the case-insensitive lookup above works. A null source throws `ArgumentNullException`.
