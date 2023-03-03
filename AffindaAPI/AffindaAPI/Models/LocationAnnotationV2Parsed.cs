// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Affinda.API.Models
{
    /// <summary> The LocationAnnotationV2Parsed. </summary>
    public partial class LocationAnnotationV2Parsed : Location
    {
        /// <summary> Initializes a new instance of LocationAnnotationV2Parsed. </summary>
        /// <param name="rawInput"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="rawInput"/> is null. </exception>
        internal LocationAnnotationV2Parsed(string rawInput) : base(rawInput)
        {
            if (rawInput == null)
            {
                throw new ArgumentNullException(nameof(rawInput));
            }
        }

        /// <summary> Initializes a new instance of LocationAnnotationV2Parsed. </summary>
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
        internal LocationAnnotationV2Parsed(string formatted, string postalCode, string state, string country, string countryCode, string rawInput, string streetNumber, string street, string apartmentNumber, string city, float? latitude, float? longitude) : base(formatted, postalCode, state, country, countryCode, rawInput, streetNumber, street, apartmentNumber, city, latitude, longitude)
        {
        }
    }
}
