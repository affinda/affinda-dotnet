// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Affinda.API.Models
{
    /// <summary> The DocumentFormat. </summary>
    public readonly partial struct DocumentFormat : IEquatable<DocumentFormat>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DocumentFormat"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DocumentFormat(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string JsonValue = "json";
        private const string XmlValue = "xml";
        private const string HrXmlValue = "hr-xml";

        /// <summary> json. </summary>
        public static DocumentFormat Json { get; } = new DocumentFormat(JsonValue);
        /// <summary> xml. </summary>
        public static DocumentFormat Xml { get; } = new DocumentFormat(XmlValue);
        /// <summary> hr-xml. </summary>
        public static DocumentFormat HrXml { get; } = new DocumentFormat(HrXmlValue);
        /// <summary> Determines if two <see cref="DocumentFormat"/> values are the same. </summary>
        public static bool operator ==(DocumentFormat left, DocumentFormat right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DocumentFormat"/> values are not the same. </summary>
        public static bool operator !=(DocumentFormat left, DocumentFormat right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="DocumentFormat"/>. </summary>
        public static implicit operator DocumentFormat(string value) => new DocumentFormat(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DocumentFormat other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DocumentFormat other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
