using System;
using System.Linq;

namespace Roadmap12Weeks.Common
{
    /// <summary>
    /// Central place for reusable literal values used across the solution.
    /// </summary>
    public static class MagicStrings
    {
        public static readonly string[] BaseNames =
            new[] { "James", "Mary", "Kylian", "Lucie" };

        /// <summary>
        /// Create a larger array by repeating the base names N times.
        /// </summary>
        public static string[] CreateLargeNames(int repeats)
        {
            if (repeats <= 0) return Array.Empty<string>();
            return Enumerable.Range(0, repeats)
                             .SelectMany(_ => BaseNames)
                             .ToArray();
        }
    }
}
