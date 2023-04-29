// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Affinda.API.Models
{
    /// <summary> Data points of &quot;text&quot; type support only &quot;equals&quot; filterType, others support both &quot;equals&quot; and &quot;range&quot;. </summary>
    public readonly partial struct SearchParametersCustomDataFilterType : IEquatable<SearchParametersCustomDataFilterType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SearchParametersCustomDataFilterType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SearchParametersCustomDataFilterType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EqualsValueValue = "equals";
        private const string RangeValue = "range";

        /// <summary> equals. </summary>
        public static SearchParametersCustomDataFilterType EqualsValue { get; } = new SearchParametersCustomDataFilterType(EqualsValueValue);
        /// <summary> range. </summary>
        public static SearchParametersCustomDataFilterType Range { get; } = new SearchParametersCustomDataFilterType(RangeValue);
        /// <summary> Determines if two <see cref="SearchParametersCustomDataFilterType"/> values are the same. </summary>
        public static bool operator ==(SearchParametersCustomDataFilterType left, SearchParametersCustomDataFilterType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SearchParametersCustomDataFilterType"/> values are not the same. </summary>
        public static bool operator !=(SearchParametersCustomDataFilterType left, SearchParametersCustomDataFilterType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SearchParametersCustomDataFilterType"/>. </summary>
        public static implicit operator SearchParametersCustomDataFilterType(string value) => new SearchParametersCustomDataFilterType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SearchParametersCustomDataFilterType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SearchParametersCustomDataFilterType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
