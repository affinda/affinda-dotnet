// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Affinda.API.Models
{
    /// <summary> The Enum18. </summary>
    public readonly partial struct Enum18 : IEquatable<Enum18>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="Enum18"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public Enum18(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ResumesValue = "resumes";
        private const string JobDescriptionsValue = "job_descriptions";

        /// <summary> resumes. </summary>
        public static Enum18 Resumes { get; } = new Enum18(ResumesValue);
        /// <summary> job_descriptions. </summary>
        public static Enum18 JobDescriptions { get; } = new Enum18(JobDescriptionsValue);
        /// <summary> Determines if two <see cref="Enum18"/> values are the same. </summary>
        public static bool operator ==(Enum18 left, Enum18 right) => left.Equals(right);
        /// <summary> Determines if two <see cref="Enum18"/> values are not the same. </summary>
        public static bool operator !=(Enum18 left, Enum18 right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="Enum18"/>. </summary>
        public static implicit operator Enum18(string value) => new Enum18(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is Enum18 other && Equals(other);
        /// <inheritdoc />
        public bool Equals(Enum18 other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}