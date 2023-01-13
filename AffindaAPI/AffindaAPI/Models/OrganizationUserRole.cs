// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Affinda.API.Models
{
    /// <summary> The role of the logged in user within the organization. </summary>
    public readonly partial struct OrganizationUserRole : IEquatable<OrganizationUserRole>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="OrganizationUserRole"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public OrganizationUserRole(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AdminValue = "admin";
        private const string MemberValue = "member";

        /// <summary> admin. </summary>
        public static OrganizationUserRole Admin { get; } = new OrganizationUserRole(AdminValue);
        /// <summary> member. </summary>
        public static OrganizationUserRole Member { get; } = new OrganizationUserRole(MemberValue);
        /// <summary> Determines if two <see cref="OrganizationUserRole"/> values are the same. </summary>
        public static bool operator ==(OrganizationUserRole left, OrganizationUserRole right) => left.Equals(right);
        /// <summary> Determines if two <see cref="OrganizationUserRole"/> values are not the same. </summary>
        public static bool operator !=(OrganizationUserRole left, OrganizationUserRole right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="OrganizationUserRole"/>. </summary>
        public static implicit operator OrganizationUserRole(string value) => new OrganizationUserRole(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is OrganizationUserRole other && Equals(other);
        /// <inheritdoc />
        public bool Equals(OrganizationUserRole other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
