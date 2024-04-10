// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Affinda.API.Models
{
    /// <summary> The unit of distance to use for location based searches. </summary>
    public readonly partial struct ResumeSearchConfigDistanceUnit : IEquatable<ResumeSearchConfigDistanceUnit>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ResumeSearchConfigDistanceUnit"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ResumeSearchConfigDistanceUnit(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string MiValue = "mi";
        private const string KmValue = "km";

        /// <summary> mi. </summary>
        public static ResumeSearchConfigDistanceUnit Mi { get; } = new ResumeSearchConfigDistanceUnit(MiValue);
        /// <summary> km. </summary>
        public static ResumeSearchConfigDistanceUnit Km { get; } = new ResumeSearchConfigDistanceUnit(KmValue);
        /// <summary> Determines if two <see cref="ResumeSearchConfigDistanceUnit"/> values are the same. </summary>
        public static bool operator ==(ResumeSearchConfigDistanceUnit left, ResumeSearchConfigDistanceUnit right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ResumeSearchConfigDistanceUnit"/> values are not the same. </summary>
        public static bool operator !=(ResumeSearchConfigDistanceUnit left, ResumeSearchConfigDistanceUnit right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ResumeSearchConfigDistanceUnit"/>. </summary>
        public static implicit operator ResumeSearchConfigDistanceUnit(string value) => new ResumeSearchConfigDistanceUnit(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ResumeSearchConfigDistanceUnit other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ResumeSearchConfigDistanceUnit other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}