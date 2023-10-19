// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Affinda.API.Models
{
    /// <summary> The Get8ItemsItem. </summary>
    public readonly partial struct Get8ItemsItem : IEquatable<Get8ItemsItem>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="Get8ItemsItem"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public Get8ItemsItem(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string FileNameValue = "file_name";
        private const string ExtractorValue = "extractor";
        private const string CreatedDtValue = "created_dt";

        /// <summary> file_name. </summary>
        public static Get8ItemsItem FileName { get; } = new Get8ItemsItem(FileNameValue);
        /// <summary> extractor. </summary>
        public static Get8ItemsItem Extractor { get; } = new Get8ItemsItem(ExtractorValue);
        /// <summary> created_dt. </summary>
        public static Get8ItemsItem CreatedDt { get; } = new Get8ItemsItem(CreatedDtValue);
        /// <summary> Determines if two <see cref="Get8ItemsItem"/> values are the same. </summary>
        public static bool operator ==(Get8ItemsItem left, Get8ItemsItem right) => left.Equals(right);
        /// <summary> Determines if two <see cref="Get8ItemsItem"/> values are not the same. </summary>
        public static bool operator !=(Get8ItemsItem left, Get8ItemsItem right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="Get8ItemsItem"/>. </summary>
        public static implicit operator Get8ItemsItem(string value) => new Get8ItemsItem(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is Get8ItemsItem other && Equals(other);
        /// <inheritdoc />
        public bool Equals(Get8ItemsItem other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}