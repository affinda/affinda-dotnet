// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Affinda.API.Models
{
    internal static partial class SearchLocationUnitExtensions
    {
        public static string ToSerialString(this SearchLocationUnit value) => value switch
        {
            SearchLocationUnit.Km => "km",
            SearchLocationUnit.Mi => "mi",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown SearchLocationUnit value.")
        };

        public static SearchLocationUnit ToSearchLocationUnit(this string value)
        {
            if (string.Equals(value, "km", StringComparison.InvariantCultureIgnoreCase)) return SearchLocationUnit.Km;
            if (string.Equals(value, "mi", StringComparison.InvariantCultureIgnoreCase)) return SearchLocationUnit.Mi;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown SearchLocationUnit value.");
        }
    }
}
