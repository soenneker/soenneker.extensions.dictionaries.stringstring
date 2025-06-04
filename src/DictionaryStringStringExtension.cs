using System.Collections.Generic;

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
    public static Dictionary<string, object> ToObjectDictionary(this IDictionary<string, string> source)
    {
        // Pre‐allocate to exactly the number of elements to avoid internal resizing
        var result = new Dictionary<string, object>(source.Count);

        foreach (KeyValuePair<string, string> kvp in source)
        {
            // Boxing happens once per value when storing as object
            result.Add(kvp.Key, kvp.Value);
        }

        return result;
    }
}