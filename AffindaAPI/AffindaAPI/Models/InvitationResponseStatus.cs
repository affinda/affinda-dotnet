// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Affinda.API.Models
{
    /// <summary> The InvitationResponseStatus. </summary>
    public readonly partial struct InvitationResponseStatus : IEquatable<InvitationResponseStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="InvitationResponseStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public InvitationResponseStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AcceptedValue = "accepted";
        private const string DeclinedValue = "declined";

        /// <summary> accepted. </summary>
        public static InvitationResponseStatus Accepted { get; } = new InvitationResponseStatus(AcceptedValue);
        /// <summary> declined. </summary>
        public static InvitationResponseStatus Declined { get; } = new InvitationResponseStatus(DeclinedValue);
        /// <summary> Determines if two <see cref="InvitationResponseStatus"/> values are the same. </summary>
        public static bool operator ==(InvitationResponseStatus left, InvitationResponseStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="InvitationResponseStatus"/> values are not the same. </summary>
        public static bool operator !=(InvitationResponseStatus left, InvitationResponseStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="InvitationResponseStatus"/>. </summary>
        public static implicit operator InvitationResponseStatus(string value) => new InvitationResponseStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is InvitationResponseStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(InvitationResponseStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
