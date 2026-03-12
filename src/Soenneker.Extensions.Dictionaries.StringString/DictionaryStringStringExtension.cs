using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;

namespace Soenneker.Extensions.Dictionaries.StringString;

/// <summary>
/// A collection of helpful Dictionary{string, string} extension methods
/// </summary>
public static class DictionaryStringStringExtension
{
    /// <summary>
    /// Creates a new Dictionary&lt;string, object&gt; with the same entries as the source,
    /// pre‐sized to avoid rehashed buckets and without any LINQ overhead.
    /// </summary>
    [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Dictionary<string, object> ToObjectDictionary(this IDictionary<string, string> source)
    {
        if (source is null)
            throw new ArgumentNullException(nameof(source));

        // Reuse the source comparer when available (important if it's OrdinalIgnoreCase, etc.)
        IEqualityComparer<string>? comparer = (source as Dictionary<string, string>)?.Comparer;

        // EnsureCapacity avoids rehashing even if caller passes a weird Count implementation
        var result = comparer is null
            ? new Dictionary<string, object>(source.Count)
            : new Dictionary<string, object>(source.Count, comparer);

        result.EnsureCapacity(source.Count);

        foreach (var kvp in source)
            result.Add(kvp.Key, kvp.Value); // no boxing; string is already a reference type

        return result;
    }
}