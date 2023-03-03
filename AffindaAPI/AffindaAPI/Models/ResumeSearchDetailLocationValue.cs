// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Affinda.API.Models
{
    /// <summary> The ResumeSearchDetailLocationValue. </summary>
    public partial class ResumeSearchDetailLocationValue : Location
    {
        /// <summary> Initializes a new instance of ResumeSearchDetailLocationValue. </summary>
        /// <param name="rawInput"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="rawInput"/> is null. </exception>
        internal ResumeSearchDetailLocationValue(string rawInput) : base(rawInput)
        {
            if (rawInput == null)
            {
                throw new ArgumentNullException(nameof(rawInput));
            }
        }

        /// <summary> Initializes a new instance of ResumeSearchDetailLocationValue. </summary>
        /// <param name="formatted"></param>
        /// <param name="postalCode"></param>
        /// <param name="state"></param>
        /// <param name="country"></param>
        /// <param name="countryCode"> Two letter country code (ISO 3166-1 alpha-2). </param>
        /// <param name="rawInput"></param>
        /// <param name="streetNumber"></param>
        /// <param name="street"></param>
        /// <param name="apartmentNumber"></param>
        /// <param name="city"></param>
        /// <param name="latitude"></param>
        /// <param name="longitude"></param>
        /// <param name="match"></param>
        internal ResumeSearchDetailLocationValue(string formatted, string postalCode, string state, string country, string countryCode, string rawInput, string streetNumber, string street, string apartmentNumber, string city, float? latitude, float? longitude, bool? match) : base(formatted, postalCode, state, country, countryCode, rawInput, streetNumber, street, apartmentNumber, city, latitude, longitude)
        {
            Match = match;
        }

        /// <summary> Gets the match. </summary>
        public bool? Match { get; }
    }
}
