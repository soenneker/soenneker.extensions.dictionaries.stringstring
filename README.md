[![](https://img.shields.io/nuget/v/soenneker.extensions.dictionaries.stringstring.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.extensions.dictionaries.stringstring/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.extensions.dictionaries.stringstring/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.extensions.dictionaries.stringstring/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.extensions.dictionaries.stringstring.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.extensions.dictionaries.stringstring/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.extensions.dictionaries.stringstring/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.extensions.dictionaries.stringstring/actions/workflows/codeql.yml)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.Extensions.Dictionaries.StringString
A collection of helpful Dictionary{string, string} extension methods.

## Installation

```bash
dotnet add package Soenneker.Extensions.Dictionaries.StringString
```

## Quick start

```csharp
using Soenneker.Extensions.Dictionaries.StringString;
```

Import the namespace, then call the extension methods directly on the matching value.

## Common operations

- `ToObjectDictionary()` - Creates a new Dictionary<string, object> with the same entries as the source, pre‐sized to avoid rehashed buckets and without any LINQ overhead.
