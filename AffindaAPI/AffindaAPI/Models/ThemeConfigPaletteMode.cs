// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Affinda.API.Models
{
    /// <summary> The ThemeConfigPaletteMode. </summary>
    public readonly partial struct ThemeConfigPaletteMode : IEquatable<ThemeConfigPaletteMode>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ThemeConfigPaletteMode"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ThemeConfigPaletteMode(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string LightValue = "light";
        private const string DarkValue = "dark";

        /// <summary> light. </summary>
        public static ThemeConfigPaletteMode Light { get; } = new ThemeConfigPaletteMode(LightValue);
        /// <summary> dark. </summary>
        public static ThemeConfigPaletteMode Dark { get; } = new ThemeConfigPaletteMode(DarkValue);
        /// <summary> Determines if two <see cref="ThemeConfigPaletteMode"/> values are the same. </summary>
        public static bool operator ==(ThemeConfigPaletteMode left, ThemeConfigPaletteMode right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ThemeConfigPaletteMode"/> values are not the same. </summary>
        public static bool operator !=(ThemeConfigPaletteMode left, ThemeConfigPaletteMode right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ThemeConfigPaletteMode"/>. </summary>
        public static implicit operator ThemeConfigPaletteMode(string value) => new ThemeConfigPaletteMode(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ThemeConfigPaletteMode other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ThemeConfigPaletteMode other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
